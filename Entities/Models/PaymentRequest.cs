using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Models
{
    public class PaymentRequest
    {
        public int id { get; set; }
        public int merchantId { get; set; }
        public Order Order { get; set; }
        

    }
}
