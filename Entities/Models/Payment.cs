using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Models
{
    [Table("payment")]
    public class Payment
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("orderFK")]
        public int OrderId { get; set; }
        public DateTime PaymentDate { get; set; }
    }
}
