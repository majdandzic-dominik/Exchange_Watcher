using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeWatcherClassLibrary
{
    public class Notification
    {
        [BsonId]
        private Guid Id;
        private string currency;
        private double percentageChange;

        public Notification(double percentageChange, string currency)
        {
            this.percentageChange = percentageChange;
            this.Currency = currency;
        }

        public Guid Id1 { get => Id; set => Id = value; }
        public double PercentageChange { get => percentageChange; set => percentageChange = value; }
        public string Currency { get => currency; set => currency = value; }
    }
}
