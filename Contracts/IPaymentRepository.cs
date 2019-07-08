using System;
using System.Collections.Generic;
using System.Text;
using Entities.Models;

namespace Contracts
{
    public interface IPaymentRepository : IRepositoryBase<Payment>
    {
         bool ProcessPayment(Order order);
         IList<Payment> RetrievePaymentDetails();
    }
}
