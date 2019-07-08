using Contracts;
using Entities;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class OrderRepository : RepositoryBase<Order>,IOrderRepository
    {
        public OrderRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }

        public bool ProcessOrders()
        {
            throw new NotImplementedException();
        }

        public bool ProcessPayment()
        {
            throw new NotImplementedException();
        }

        public IList<Order> retrieveOrders()
        {
            throw new NotImplementedException();
        }
    }
}
