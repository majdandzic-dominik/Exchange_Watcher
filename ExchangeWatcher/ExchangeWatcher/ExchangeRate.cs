using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ExchangeWatcher
{
    class ExchangeRate
    {
        DateTime date;
        private string country;
        private string currency;
        private int unit;
        private decimal middleRate;

        public ExchangeRate(DateTime date, string country, string currency, int unit, decimal middleRate)
        {
            this.date = date;
            this.country = country;
            this.currency = currency;
            this.unit = unit;
            this.middleRate = middleRate;
        }

        public DateTime Date { get => date; set => date = value; }
        public string Country { get => country; set => country = value; }
        public string Currency { get => currency; set => currency = value; }
        public int Unit { get => unit; set => unit = value; }
        public decimal MiddleRate { get => middleRate; set => middleRate = value; }

        public string GetAllValuesString()
        {
            string text = date.ToString() + " " + country + " " + currency + " " + unit.ToString() + " " + middleRate.ToString();

            return text;
        }
    }
}
