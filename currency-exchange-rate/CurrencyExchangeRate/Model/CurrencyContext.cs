using Microsoft.EntityFrameworkCore;

namespace CurrencyExchangeRate.Model
{
    public class CurrencyContext : DbContext
    {
        public CurrencyContext(DbContextOptions options) : base(options) { }
        public DbSet<Currency> Currency{get;set;}
        protected override void OnModelCreating(ModelBuilder modelBuilder){
            modelBuilder.HasDefaultSchema("Currency");
            base.OnModelCreating(modelBuilder);
        }
    }
}