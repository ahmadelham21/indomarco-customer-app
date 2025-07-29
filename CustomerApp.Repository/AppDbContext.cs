using CustomerApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CustomerApp.Repository
{
    public class AppDbContext : DbContext
    { 
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Customer> Customers { get; set; }

    }
}
