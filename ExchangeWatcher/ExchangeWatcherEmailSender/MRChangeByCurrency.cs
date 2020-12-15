using System;
using System.Collections.Generic;
using System.Text;

namespace ExchangeWatcherEmailSender
{
    class MRChangeByCurrency
    {
        private string currency;
        private double mrPercentChange;

        public MRChangeByCurrency(string currency, double mrPercentChange)
        {
            this.currency = currency;
            this.mrPercentChange = mrPercentChange;
        }

        

        public string Currency { get => currency; set => currency = value; }
        public double MrPercentChange { get => mrPercentChange; set => mrPercentChange = value; }

    }
}
