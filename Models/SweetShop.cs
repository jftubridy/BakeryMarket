using Microsoft.EntityFrameworkCore;

namespace SweetShop.Models
{
    public class SweetShopContext : DbContext
    {
        public DbSet<Treat> Treats { get; set; }
        public virtual DbSet<Flavor> Flavors { get; set; }
        public DbSet<FlavorTreat> FlavorTreat { get; set; }

        public SweetShopContext(DbContextOptions options) : base(options) { }
    }
}