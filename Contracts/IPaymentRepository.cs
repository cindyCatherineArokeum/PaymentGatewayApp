using System;
using System.Collections.Generic;
using System.Text;
using Entities.Models;

namespace Contracts
{
    public interface IPaymentRepository : IRepositoryBase<Payment>
    {
         IEnumerable<Payment> GetAllPayments();
    }
}
