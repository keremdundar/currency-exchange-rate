using System;
using System.Threading.Tasks;
using Xunit;

namespace CurrencyExchangeRate.Tests
{
    public class CurrencyManagerTest
    {
        [Fact]
        public async Task GetCurrency_WhenCurrencyManagerConstructWithToday_ShouldGetTodaysCurrencyExchangeRates()
        {
            DateTime now = DateTime.Now;
            CurrencyManager cm = new CurrencyManager(now.Year,now.Month,now.Day);
            var result = await cm.GetCurrencyAsync();
            Assert.NotEmpty(result);
        }
    }
}
