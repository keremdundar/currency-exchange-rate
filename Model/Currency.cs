using System;
using System.Xml.Serialization;

namespace CurrencyExchangeRate.Model
{
    [Serializable()]
    [XmlRoot("Currency")]
    public class Currency
    {
        [XmlIgnore]
        public DateTime CurrencyDate{get;set;}
        [XmlAttribute("CurrencyCode")]
        public string CurrencyCode{get;set;}
        public string CurrencyName{get;set;}
        [XmlElement(IsNullable = true)]
        public decimal? ForexBuying{get;set;}
        [XmlElement(IsNullable = true)]
        public decimal? ForexSelling{get;set;}
        [XmlElement(IsNullable = true)]
        public decimal? BanknoteBuying{get;set;}
        [XmlElement(IsNullable = true)]
        public decimal? BanknoteSelling{get;set;}
        
    }
}