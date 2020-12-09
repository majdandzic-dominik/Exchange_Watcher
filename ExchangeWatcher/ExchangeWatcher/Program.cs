using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json;

namespace ExchangeWatcher
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }

        public static string GetText()
        {
            WebClient client = new WebClient();
            String exchangeRatesJSON = client.DownloadString("http://api.hnb.hr/tecajn/v2");

            dynamic dynamicExchangeRates = JsonConvert.DeserializeObject<dynamic>(exchangeRatesJSON);

            List<ExchangeRate> ExchangeRatesList = new List<ExchangeRate>();


            for (int i = 0; i < 14; i++)
            {
                ExchangeRatesList.Add(
                    new ExchangeRate(
                        Convert.ToDateTime(dynamicExchangeRates[i]["datum_primjene"]),
                        dynamicExchangeRates[i]["drzava"].ToString(),
                        dynamicExchangeRates[i]["valuta"].ToString(),
                        Convert.ToInt32(dynamicExchangeRates[i]["jedinica"]),
                        Convert.ToDecimal(dynamicExchangeRates[i]["srednji_tecaj"])
                        )
                );
            }

            string textToShow = "";

            foreach (ExchangeRate exchangeRate in ExchangeRatesList)
            {
                textToShow += exchangeRate.GetAllValuesString();
                textToShow += "\r\n";
            }

            return textToShow;

        }
    }
}
