using Microsoft.EntityFrameworkCore;
using RestaurantManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementSystem.Contexts
{
    public class RestaurantContext:DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.;Database=RestaurantManagementSystem;Trusted_Connection=True;TrustServerCertificate=True;");
        }


        public DbSet<Customer>Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Product>Products { get; set; }
        public DbSet<Rezervation> Rezervations { get; set; }
        public DbSet<Orders>Orders { get; set; }
        public DbSet<Category>Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

    }
}
