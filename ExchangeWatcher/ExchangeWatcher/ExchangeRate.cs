using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeWatcher
{
    class ExchangeRate
    {
        [BsonId]
        private Guid Id;
        private string date;
        private string country;
        private string currency;
        private string unit;
        private string middleRate;

        public ExchangeRate(string date, string country, string currency, string unit, string middleRate)
        {
            this.date = date;
            this.country = country;
            this.currency = currency;
            this.unit = unit;
            this.middleRate = middleRate;
        }

        public string Date { get => date; set => date = value; }
        public string Country { get => country; set => country = value; }
        public string Currency { get => currency; set => currency = value; }
        public string Unit { get => unit; set => unit = value; }
        public string MiddleRate { get => middleRate; set => middleRate = value; }
        public Guid Id1 { get => Id; set => Id = value; }
    }
}
