using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contracts;
using Entities.Models.Enumerations;
using Microsoft.AspNetCore.Mvc;
using Entities.Models;
using System.Net.Http;
using Newtonsoft.Json;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PaymentGatewayApp
{
    [Route("api/payment")]
    public class PaymentsController : ControllerBase
    {
        private ILoggerManager _logger;
        private IRepositoryWrapper _repository;

   

        public PaymentsController(ILoggerManager logger, IRepositoryWrapper repository)
        {
            _logger = logger;
            _repository = repository;
        }


        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpGet("findPreviousPayment/{shopperId}/{PaymentDate}")]
    
        public IQueryable<Payment> GetPreviousPayment([FromRoute] int shopperId, [FromRoute] string PaymentDate)
        {
            IQueryable < Payment > paymentHistory = null;
            //find orders for a specific shoppe 
           
            if (shopperId != 0)
            {
          
                IQueryable<Order> ordersList = _repository.Order.FindByCondition(o => o.shopperID == shopperId);

                if (ordersList.Count() != 0)
                {
                    foreach (Order order in ordersList)
                    {
                        //For each order, retrieve payment
                        paymentHistory = _repository.Payment.FindByCondition(payment => payment.OrderId == order.id);
     
                    }

                }
            }
            if (PaymentDate != null)
            {
                paymentHistory = _repository.Payment.FindByCondition(payment => payment.PaymentDate.Equals(PaymentDate));
            }

            //Else, get all payments
            paymentHistory = _repository.Payment.FindAll();


            return paymentHistory;
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        public async Task<HttpResponseMessage> GetPaymentValidationAsync(PaymentRequest paymentRequest)
        {
            ValidationResponse validationResponse = null;

            var client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:8080");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = await client.PostAsJsonAsync("api/acquiringbank", paymentRequest);

            if (response.IsSuccessStatusCode)
            {
                var data = response.ToString();
                validationResponse = (ValidationResponse)JsonConvert.DeserializeObject(data);
                BankResponseCodes bankresponse = validationResponse.responseCode;
                


                if (!(bankresponse.Equals(BankResponseCodes.Approved) || !bankresponse.Equals(BankResponseCodes.PartialApproval)))
                {

                    _logger.LogInfo("Please enter a new card, the following error has been encountered:" + response);
                    return response;
                }
                { //Process payment is successful
                    Payment payment = new Payment();
                    payment.OrderId = paymentRequest.Order.id;
                    payment.PaymentDate = DateTime.Now;
                    payment.paid = true;

                    _repository.Payment.Create(payment);
                }
            }

            return response;
        }


    }
}
