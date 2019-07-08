using System;
using System.Collections.Generic;
using System.Text;
using Entities.Models;
using Contracts;
using Entities;

namespace Repository
{
    public class PaymentRepository : RepositoryBase<Payment>, IPaymentRepository
    {
        public PaymentRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public bool ProcessPayment(Order order)
        {
            throw new NotImplementedException();
        }

        public IList<Payment> RetrievePaymentDetails()
        {
            throw new NotImplementedException();
        }
    }
}
