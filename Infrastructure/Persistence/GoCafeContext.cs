using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
namespace Infrastructure.Persistence
{
        public class GoCafeContext : DbContext
    {
        public GoCafeContext(DbContextOptions<GoCafeContext> options)
            : base(options)
        {
        }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Bill> Bills { get; set; }
        public DbSet<InfoBill> InfoBills { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(GoCafeContext).Assembly);
        }
    }
}