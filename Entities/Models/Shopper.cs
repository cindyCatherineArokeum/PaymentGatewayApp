using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Models
{
    [Table("shopper")]
    public class Shopper
    {
        [Key]
        private int id { get; set; }

        [Required(ErrorMessage = "first name is required")]
        [StringLength(45, ErrorMessage = "first name can't be longer than 45 characters")]
        private string firstName {get;set;}

        [Required(ErrorMessage = "surname is required")]
        [StringLength(45, ErrorMessage = "surname can't be longer than 45 characters")]
        private string surname { get; set; }

        [Required(ErrorMessage ="postal address is required")]
        private Address physicalAddress { get; set; }

        [Required(ErrorMessage = "email address is required")]
        private string email { get; set; }

        [Required(ErrorMessage = "mobile phone number is required")]
        private string mobileNumber { get; set; }

    }
}
