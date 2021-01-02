using System;
using System.Collections.Generic;
using System.Net;
using Newtonsoft.Json;
using MongoDB.Driver;
using ExchangeWatcherClassLibrary;


namespace ExchangeWatcherUpdater
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //get json file
            WebClient webClient = new WebClient();
            string exchangeRatesJSON = webClient.DownloadString("http://api.hnb.hr/tecajn/v2");

            dynamic dynamicExchangeRates = JsonConvert.DeserializeObject<dynamic>(exchangeRatesJSON);


            //connect to database
            string database = "ExchangeRates";
            string collection = "ExchangeRatesList";
            MongoCRUD exchangeRatesDB = new MongoCRUD(database);



            //store data from json file into list of objects
            List<ExchangeRate> ExchangeRatesList = new List<ExchangeRate>();

            string today = DateTime.UtcNow.ToString("yyyy-MM-dd");
            foreach (dynamic dynamicObject in dynamicExchangeRates)
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
                       
            exchangeRatesDB.InsertRecordListByDate<ExchangeRate>(collection, ExchangeRatesList, today);
                                    
        }

    }
}
