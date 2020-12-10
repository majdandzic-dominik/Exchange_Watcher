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
            
            //get json file
            WebClient webClient = new WebClient();
            String exchangeRatesJSON = webClient.DownloadString("http://api.hnb.hr/tecajn/v2");

            dynamic dynamicExchangeRates = JsonConvert.DeserializeObject<dynamic>(exchangeRatesJSON);

            
            
            
            //store data from json file into list of objects
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

          
            //upload data from list to database  
            IMongoClient dbClient = new MongoClient("mongodb+srv://docMinike:5zPjAOGRX1Dwu3XK@exchangeratescluster.h4mjo.mongodb.net/docMinike?retryWrites=true&w=majority");
            IMongoDatabase exchangeRatesDB = dbClient.GetDatabase("TestDB4");
            var objectListCollection = exchangeRatesDB.GetCollection<ExchangeRate>("ExchangeRatesList");
            objectListCollection.InsertMany(ExchangeRatesList);

                       
        }

    }
}
