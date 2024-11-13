using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smartsheet
{
    public class AppDbContext : DbContext
    {
        public DbSet<Users> Users { get; set; }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<ProductCategory> ProductCategory { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<Reports> Reports { get; set; }
        public DbSet<Sales> Sales { get; set; }
        public DbSet<Stocks> Stocks { get; set; }
        public DbSet<Suppliers> Suppliers { get; set; }
        //public DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=smartsheetDb;User ID=sa;Password=Abc123+;Trusted_Connection=True;TrustServerCertificate=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Categories>()
                //.HasKey(c => c.CategoryId);  // Define the primary key here
            modelBuilder.Entity<ProductCategory>().HasNoKey();

            base.OnModelCreating(modelBuilder);
        }
    }
}
