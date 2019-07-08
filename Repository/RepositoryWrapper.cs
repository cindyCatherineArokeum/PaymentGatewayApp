using System;
using System.Collections.Generic;
using System.Text;
using Contracts;
using Entities;

namespace Repository
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private RepositoryContext _repoContext;
        private IShopperRepository _shopper;
        private IOrderRepository _order;
        private IPaymentRepository _payment;


        public IShopperRepository Shopper
        {
            get
            {
                if (_shopper == null)
                {
                    _shopper = new ShopperRepository(_repoContext);
                }
                return _shopper;
            }
        }

        public IOrderRepository Order
        {
            get
            {
                if (_order == null)
                {
                    _order = new OrderRepository(_repoContext);
                }
                return _order;
            }
        }

        public IPaymentRepository Payment
        {
            get
            {
                if (_payment == null)
                {
                    _payment = new PaymentRepository(_repoContext);
                }
                return _payment;
            }
        }



        public void Save()
        {
            _repoContext.SaveChanges();
        }
    }
}
