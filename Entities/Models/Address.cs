using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Models
{
    public class Address
    {
        public int id { get; set; }
        public string addressLine1 { get; set; }
        public string addressLine2 { get; set; }
        public string town { get; set; }
        public string postalCode { get; set; }
        public string country { get; set; }
    }
}
