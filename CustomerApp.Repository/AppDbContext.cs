using CustomerApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CustomerApp.Repository
{
    public class AppDbContext : DbContext
    { 
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Customer> Customers { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
            if (Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") == "Development")
            {
                modelBuilder.Entity<Customer>().HasData(
                    new Customer
                    {
                        CustomerId = 1,
                        CustomerCode = "000001",
                        CustomerName = "User Pertama",
                        CustomerAddress = "Jl. Mangga Dua Raya",
                        CreatedBy = 1,
                        CreatedAt = new DateTime(2025, 8, 1, 0, 0, 0, DateTimeKind.Utc)
                    }
                );
            }
        }

    }
}
