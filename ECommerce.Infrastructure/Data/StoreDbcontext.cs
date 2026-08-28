using ECommerce.Domain.Entities.Products;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Infrastructure.Data
{
    public class StoreDbcontext:DbContext
    {
        public StoreDbcontext(DbContextOptions<StoreDbcontext> options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductsBrand> ProductsBrands { get; set; }
        public DbSet<ProductsType> ProductsTypes   { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(StoreDbcontext).Assembly);
        }

    }
}
