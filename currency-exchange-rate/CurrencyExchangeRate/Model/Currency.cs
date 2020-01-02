using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;

namespace CurrencyExchangeRate.Model
{
    [Serializable()]
    [XmlRoot("Currency")]
    public class Currency
    {
        [XmlIgnore]
        [Key]
        public int Id{get;set;}
        [XmlIgnore]
        public DateTime CurrencyDate{get;set;}
        [XmlAttribute("CurrencyCode")]
        public string CurrencyCode{get;set;}
        [XmlElement]
        public string CurrencyName{get;set;}
        [XmlElement]
        [NotMapped]
        public string ForexBuying{get;set;}
        [XmlIgnore]
        [Column("ForexBuying")]
        public decimal ForexBuyingNumeric{get{
            return Decimal.Parse(ForexBuying);
        }}
        [XmlElement]
        [NotMapped]
        public string ForexSelling{get;set;}
        [XmlIgnore]
        [Column("ForexSelling")]
        public decimal ForexSellingNumeric{get{
            return Decimal.Parse(ForexSelling);
        }}
        [XmlElement]
        [NotMapped]
        public string BanknoteBuying{get;set;}
        [XmlIgnore]
        [Column("BanknoteBuying")]
        public decimal BanknoteBuyingNumeric{get{
            return Decimal.Parse(BanknoteBuying);
        }}
        [XmlElement]
        [NotMapped]
        public string BanknoteSelling{get;set;}
        [XmlIgnore]
        [Column("BanknoteSelling")]
        public decimal BanknoteSellingNumeric{get{
            return Decimal.Parse(BanknoteSelling);
        }}
        
    }
}