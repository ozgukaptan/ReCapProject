﻿using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities.Concrete;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Context
{
    public class ReCapContext : DbContext
    {
        #region  Field
        //private static string CS
        //{
        //    get { return ConfigurationManager.ConnectionStrings["CSNortContext"].ConnectionString; }
        //}
        #endregion

        //public NortContext() : base(CS)
        //{
        //    Database.SetInitializer<NortContext>(null);
        //}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-AC15D00\SQLEXPRESS02;Database=ReCapProject;Trusted_Connection=true");
            //optionsBuilder.UseSqlServer(@"Server=DESKTOP-6N7UTE9\SQLEXPRESS;Database=ReCapProject;Trusted_Connection=true");
        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Rental> Rentals { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CarImage> CarImages { get; set; }
        public DbSet<CreditCard> CreditCards { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
    }
}
