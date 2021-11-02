using ChallengeLeanTechJA.Modelo;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeLeanTechJA.Context
{
    public class ContextDataAccess: DbContext
    {
        private string _connectionString = "";

        public string ConnectionString 
        { 
            get { return _connectionString; } 
            set { _connectionString = value;  } 
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            _connectionString = @"Server=DESKTOP-MSCL69Q\SQLEXPRESS;Integrated Security=true; initial catalog=challenge";
            optionsBuilder.UseSqlServer(_connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Products>().HasKey(p => new { p.ProductId });
            //modelBuilder.Entity<Products>().Property(p => p.ProductId).UseIdentityColumn().Metadata.SetAfterSaveBehavior(Microsoft.EntityFrameworkCore.Metadata.PropertySaveBehavior.Ignore);

        }

        public DbSet<Products> Products { get; set; }

    }
}
