using System;
using System.Collections.Generic;
using System.Text;
using Entities.Models.Enumerations;
namespace Entities.Models
{
    public class ValidationResponse
    {
        private int id { get; set; }
        private int shopperId { get; set; }
        private int orderId { get; set; }
        private decimal amount { get; set; }
        public BankResponseCodes responseCode { get; set; }

    }

}