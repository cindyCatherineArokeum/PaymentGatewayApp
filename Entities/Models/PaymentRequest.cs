using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Models
{
    public class PaymentRequest
    {
        int id { get; set; }
        int merchantId { get; set; }
        int shopperId { get; set; }
        PaymentCardDetails paymentCardDetails { get; set; }
    }
}
