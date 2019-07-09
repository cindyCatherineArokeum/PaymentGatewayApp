using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contracts;
using Entities.Models.Enumerations;
using Microsoft.AspNetCore.Mvc;
using Entities.Models;
using System.Net.Http;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PaymentGatewayApp
{
    [Route("api/payment")]
    public class PaymentsController : ControllerBase
    {
        private ILoggerManager _logger;
        private IRepositoryWrapper _repository;
        static HttpClient client = new HttpClient();
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

        static async Task<Uri> ProcessPaymentAsync(PaymentRequest paymentRequest)
        {
            HttpResponseMessage response = await  
        }
        public String ProcessPayment(PaymentRequest paymentRequest)
        {
            var response = "response";//call to call acquiring bank

            if (!(response.Equals(BankResponseCodes.Approved )|| !response.Equals(BankResponseCodes.PartialApproval))){

                _logger.LogInfo("Please enter a new card, the following error has been encountered:" + response);
                
            }
            {
                _repository.Payment.Create();
                //code to process payment
                //set payment status to successful 
                //write to database
            }

            return null;
        }
    }
}
