using System;
using System.Threading.Tasks;

namespace CurrencyExchangeRate
{
    class Program
    {
        static async Task Main(string[] args)
        {
            CurrencyManager cm = new CurrencyManager(int.Parse(args[0]),int.Parse(args[1]),int.Parse(args[2]));
            await cm.GetCurrencyAsync();
        }
    }
}
