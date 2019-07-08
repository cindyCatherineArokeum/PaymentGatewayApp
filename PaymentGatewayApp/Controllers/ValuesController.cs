using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contracts;
using Microsoft.AspNetCore.Mvc;

namespace PaymentGatewayApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private ILoggerManager _logger;

        private IRepositoryWrapper _repoWrapper;

        public ValuesController(IRepositoryWrapper repoWrapper)
        {
            _repoWrapper = repoWrapper;
        }
        // GET api/test
        [HttpGet]
        public IEnumerable<string> GetValues()
        {
            //var shoppers = _repoWrapper.Shopper.FindByCondition(x => x.id.Equals("1"));
            var order = _repoWrapper.Order.FindAll();
            
            
            return new string[] { "value1", "value2" };
        }
        //public ValuesController(ILoggerManager logger)
        //{
        //    _logger = logger;
        //}
        // GET api/values
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    _logger.LogInfo("Here is info message from our values controller.");
        //    _logger.LogDebug("Here is debug message from our values controller.");
        //    _logger.LogWarn("Here is warn message from our values controller.");
        //    _logger.LogError("Here is error message from our values controller.");

        //    return new string[] { "value1", "value2" };
        //}
    }
}
