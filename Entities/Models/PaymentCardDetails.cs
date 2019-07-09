using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Models
{
   //Details of payment cards are not saved in database because of high sensitivity
    class PaymentCardDetails
    {
        private int id { get; set; }
        private string cardNumber { get; set; }
        private string cvvCode { get; set; }
        private string cardHolderName { get; set; }
    }
}
