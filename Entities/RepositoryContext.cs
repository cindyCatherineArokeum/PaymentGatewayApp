﻿using Entities.Models;
using Microsoft.EntityFrameworkCore;
namespace Entities
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options)
            : base(options)
        {
        }
         DbSet<Shopper> Shoppers { get; set; }
         DbSet<Order> Orders { get; set; }
         DbSet<Payment> Payment { get; set; }
         DbSet<ValidationResponse> ValidationResponse { get; set; }
           
       
       
    }
}