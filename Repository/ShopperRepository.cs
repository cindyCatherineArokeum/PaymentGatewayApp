using System;
using System.Collections.Generic;
using System.Text;
using Contracts;
using Entities;
using Entities.Models;

namespace Repository
{
    public class ShopperRepository : RepositoryBase<Shopper>, IShopperRepository
    {
        public ShopperRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
