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
        private string email;
        private string userName;
        private string currency;
        private double percentageChange;

        public Notification(string email, string userName, double percentageChange, string currency)
        {
            this.email = email;
            this.userName = userName;
            this.percentageChange = percentageChange;
            this.Currency = currency;
        }

        public Guid Id1 { get => Id; set => Id = value; }
        public string Email { get => email; set => email = value; }
        public string UserName { get => userName; set => userName = value; }
        public double PercentageChange { get => percentageChange; set => percentageChange = value; }
        public string Currency { get => currency; set => currency = value; }
    }
}
