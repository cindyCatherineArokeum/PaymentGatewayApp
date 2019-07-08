using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Models
{
   //Details of payment cards are not saved in database because of high sensitivity
    class PaymentCardDetails
    {
        int id { get; set; }
        string cardNumber { get; set; }
        string cvvCode { get; set; }
        string cardHolderName { get; set; }
    }
}
