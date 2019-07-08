using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts
{
    public interface IRepositoryWrapper
    {
        IShopperRepository Shopper { get; }
        IOrderRepository Order { get; }

        void Save();
    }   
}
