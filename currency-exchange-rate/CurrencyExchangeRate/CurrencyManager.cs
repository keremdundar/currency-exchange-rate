using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using CurrencyExchangeRate.Helper;
using CurrencyExchangeRate.Model;

namespace CurrencyExchangeRate
{
    public class CurrencyManager
    {
        private readonly string tcmbUrl;
        private readonly DateTime date;
        public CurrencyManager(DateTime date)
        {
            tcmbUrl = "https://www.tcmb.gov.tr/kurlar/" + string.Format("{0:yyyyMM}",date) + "/" + string.Format("{0:ddMMyyyy}",date) + ".xml";   
            this.date = date;
        }
        public async Task<List<Currency>> GetCurrencyAsync(){
            List<Currency> currencyList = new List<Currency>();
            using (var client = new HttpClient()){
                var response = await client.GetAsync(tcmbUrl);
                using(HttpContent content = response.Content){
                    var result = await content.ReadAsStreamAsync();
                    CustomXmlSerializer<Currency> serializer = new CustomXmlSerializer<Currency>();
                    currencyList = serializer.Build("Tarih_Date").GetList(result);
                }
            }
            currencyList.ForEach(p=>{
                p.CurrencyDate = date;
                });            
            return currencyList;
        }
    }
}