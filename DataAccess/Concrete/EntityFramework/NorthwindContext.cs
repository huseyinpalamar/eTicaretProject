﻿using Core.Entities.Concrate;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class NorthwindContext:DbContext
    {
        // Veri tabanını gösterdiğimiz alan
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Northwind; Trusted_Connection=true ");
        }

        // product tablosu veri tabanındaki products tablosuna karşılık gelmekte.
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Order> Orders { get; set; }
        public DbSet <User> Users { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet <UserOperationClaim> UserOperationClaims { get; set; }
    }
}
