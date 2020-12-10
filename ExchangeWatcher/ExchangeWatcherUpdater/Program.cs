using System;
using System.Collections.Generic;
using System.Net;
using Newtonsoft.Json;
using MongoDB.Driver;


namespace ExchangeWatcherUpdater
{
    class Program
    {
        static void Main(string[] args)
        {            
            WebClient webClient = new WebClient();
            String exchangeRatesJSON = webClient.DownloadString("http://api.hnb.hr/tecajn/v2");

            dynamic dynamicExchangeRates = JsonConvert.DeserializeObject<dynamic>(exchangeRatesJSON);

            
            
            
            List<ExchangeRate> ExchangeRatesList = new List<ExchangeRate>();

            foreach(dynamic dynamicObject in dynamicExchangeRates)
            {
                ExchangeRatesList.Add(
                    new ExchangeRate(
                        dynamicObject["datum_primjene"].ToString(),
                        dynamicObject["drzava"].ToString(),
                        dynamicObject["valuta"].ToString(),
                        dynamicObject["jedinica"].ToString(),
                        dynamicObject["srednji_tecaj"].ToString()
                        )
                );
            }

            string textToShow = "";

            foreach(ExchangeRate exchangeRate in ExchangeRatesList)
            {
                textToShow += exchangeRate.GetAllValuesString();
                textToShow += "\r\n";
            }

            Console.WriteLine(textToShow);


            IMongoClient dbClient = new MongoClient("mongodb+srv://docMinike:5zPjAOGRX1Dwu3XK@exchangeratescluster.h4mjo.mongodb.net/docMinike?retryWrites=true&w=majority");
            IMongoDatabase exchangeRatesDB = dbClient.GetDatabase("TestDB3");
            var objectListCollection = exchangeRatesDB.GetCollection<ExchangeRate>("ExchangeRatesList");
            objectListCollection.InsertMany(ExchangeRatesList);

                       
        }

    }
}
