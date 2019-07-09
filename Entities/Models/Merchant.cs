using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Models
{
    [Table("merchant")]
    class Merchant
    {
        public int id { get; set; }
        public string businessName { get; set; }
        public string contactName { get; set; }
        public string email { get; set; }
        public string phoneNumber { get; set; }
        public Address address { get; set; }
    }
}
