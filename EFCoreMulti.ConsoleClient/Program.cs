using EFCoreMulti.Infrastucture;
using EFCoreMulti.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Reflection;

namespace EFCoreMulti.ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var environmentName = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");

            IConfiguration Configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: false)
                .AddJsonFile($"appsettings.{environmentName}.json", optional: true)
                .Build();

            var optionsBuilder = new DbContextOptionsBuilder<MyContext>();

            string connectionString = Configuration.GetConnectionString("MyConnection");
            string configurationsFromAssembly = Configuration["ConfigurationsFromAssembly"];

            Console.WriteLine(connectionString);
            Console.WriteLine(configurationsFromAssembly);

            optionsBuilder.UseSqlServer(connectionString)
                .EnableSensitiveDataLogging();

            using (MyContext context = new MyContext(optionsBuilder.Options))
            {
                context.Customers.Add(new Customer { FirstName = "John", LastName = "Smith", Growth = 175, Weight = 79 });
                context.SaveChanges();
            }
        }
    }
}
