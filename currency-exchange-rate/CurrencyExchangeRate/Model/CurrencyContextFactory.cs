using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace CurrencyExchangeRate.Model
{
    public class CurrencyContextFactory : IDesignTimeDbContextFactory<CurrencyContext>
    {
        public CurrencyContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<CurrencyContext>();
            optionsBuilder.UseMySQL("Server=localhost:3306;Database=kerosozluk;Uid=root;Pwd=.");
            ;

            return new CurrencyContext(optionsBuilder.Options);
        }
    }
}