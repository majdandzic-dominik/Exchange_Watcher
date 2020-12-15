using System;
using System.Collections.Generic;
using System.Text;

namespace ExchangeWatcherEmailSender
{
    //currently not in use, delete if not able to find other solution
    class MiddleRatesByCurrency
    {
        //mr = middle rate
        private string currency;
        private double mrPercentChange;
        private string mrToday;
        private string mrYesterday;

        public string Currency { get => currency; set => currency = value; }
        public double MrPercentChange { get => mrPercentChange; set => mrPercentChange = value; }
        public string MrToday { get => mrToday; set => mrToday = value; }
        public string MrYesterday { get => mrYesterday; set => mrYesterday = value; }

        public MiddleRatesByCurrency(string currency, string mrToday, string mrYesterday)
        {
            this.currency = currency;
            this.mrToday = mrToday;
            this.mrYesterday = mrYesterday;
            this.mrPercentChange = Math.Abs(((Convert.ToDouble(mrToday) - Convert.ToDouble(mrYesterday)) / Convert.ToDouble(mrYesterday)) * 100);
        }

        public void PrintString()
        {
            Console.WriteLine(Currency + " " + MrPercentChange.ToString());
        }
    }
}
