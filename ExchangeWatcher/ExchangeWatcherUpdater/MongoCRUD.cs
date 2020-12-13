using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExchangeWatcherUpdater
{
    class MongoCRUD
    {
        private IMongoDatabase db;

        public MongoCRUD(string database)
        {
            var client = new MongoClient("mongodb+srv://docMinike:D2bgSWT7M3XGWJwP@exchangeratescluster.mwakl.mongodb.net/ExchangeRates?retryWrites=true&w=majority");
            db = client.GetDatabase(database);
        }

        public void InsertRecordList<T>(string table, List<T> records)
        {
            var collection = db.GetCollection<T>(table);
            collection.InsertMany(records);

        }     

    }
}
