using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Models
{
    [Table("order")]
    public class Order
    {
        [Key]
        public int id { get; set; }

        [ForeignKey("shopperFK")]
        [Required (ErrorMessage ="An order cannot exist on its own, a shopper ID is required")]
        public int shopperID { get; set; }
        
        public int paymentID { get; set; }
        
        public DateTime orderDate { get; set; }

        public Boolean paid { get; set; }
        public string status { get; set; }
    }
}
