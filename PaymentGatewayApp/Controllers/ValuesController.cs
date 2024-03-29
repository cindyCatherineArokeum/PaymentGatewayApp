﻿using System;
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
        private IRepositoryWrapper _repoWrapper;

        public ValuesController(IRepositoryWrapper repoWrapper)
        {
            _repoWrapper = repoWrapper;
        }
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
          //  var domesticAccounts = _repoWrapper.Order.FindByCondition(x => x.AccountType.Equals("Domestic"));
            var orders = _repoWrapper.Order.FindAll();

            return new string[] { "value1", "value2" };
        }




    }
 
}

