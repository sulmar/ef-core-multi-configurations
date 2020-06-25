using EFCoreMulti.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Reflection;

namespace EFCoreMulti.Infrastucture
{
    public class MyContext : DbContext
    {
        private readonly string configurationsFromAssembly;

        public MyContext(DbContextOptions options) : base(options)
        {
            configurationsFromAssembly = "EFCoreMulti.Configurations.A";
        }

        public DbSet<Customer> Customers { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // TODO: 
            var assembly = Assembly.Load(configurationsFromAssembly);
            modelBuilder.ApplyConfigurationsFromAssembly(assembly);

            // modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(modelBuilder);
        }


    }

   
}
