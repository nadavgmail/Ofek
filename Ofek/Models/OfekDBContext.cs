using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using EntityFramework.MemoryJoin;

namespace Ofek
{
    public class OfekDBContext : DbContext
    {

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<CustomerProduct> CustomerProducts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //this is called fluent API

            ////to prevent foreign key
            //modelBuilder.Entity<HistoryCustomerProduct>().Map(m =>
            //{
            //    m.MapInheritedProperties();
            //    m.ToTable("HistoryCustomerProduct");
            //});

        }


    }
}