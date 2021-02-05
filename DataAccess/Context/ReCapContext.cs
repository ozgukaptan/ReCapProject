using System;
using System.Collections.Generic;
using System.Text;
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
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-6N7UTE9\SQLEXPRESS;Database=ReCapProject;Trusted_Connection=true");
        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Color> Colors { get; set; }
    }
}
