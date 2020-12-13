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
            string exchangeRatesJSON = webClient.DownloadString("http://api.hnb.hr/tecajn/v2");

            dynamic dynamicExchangeRates = JsonConvert.DeserializeObject<dynamic>(exchangeRatesJSON);

            
            
            
            //store data from json file into list of objects
            List<ExchangeRate> ExchangeRatesList = new List<ExchangeRate>();

            string today = DateTime.UtcNow.ToString("yyyy-MM-dd");
            int numOfAddedObjects = 0;
            foreach (dynamic dynamicObject in dynamicExchangeRates)
            {
                if(!string.Equals(today, dynamicObject["datum_primjene"].ToString()))
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
                    numOfAddedObjects++;
                }
            }


            //upload data from list to database 
            if(numOfAddedObjects != 0)
            {
                string collection = "ExchangeRates";
                string table = "ExchangeRatesList";
                MongoCRUD exchangeRatesDB = new MongoCRUD(collection);
                exchangeRatesDB.InsertRecordList<ExchangeRate>(table, ExchangeRatesList);
            }
             
           
            

           


        }

    }
}
