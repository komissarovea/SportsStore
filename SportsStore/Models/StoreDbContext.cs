using Microsoft.EntityFrameworkCore;

namespace SportsStore.Models
{
    public class StoreDbContext : DbContext
    {
        public StoreDbContext(DbContextOptions<StoreDbContext> options)
            : base(options) { 
                System.Console.WriteLine("StoreDbContext ctor");
            }

            public DbSet<Product> Products => Set<Product>();
    }
}