using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExchangeWatcherEmailSender
{
    class MongoCRUD
    {
        private IMongoDatabase db;

        public MongoCRUD(string database)
        {
            var client = new MongoClient("mongodb+srv://docMinike:D2bgSWT7M3XGWJwP@exchangeratescluster.mwakl.mongodb.net/ExchangeRates?retryWrites=true&w=majority");
            db = client.GetDatabase(database);
        }

        public List<T> LoadRecordByDate<T>(string table, string date)
        {
            var collection = db.GetCollection<T>(table);
            var filter = Builders<T>.Filter.Eq("Date", date);

            return collection.Find(filter).ToList();
        }


        //DOESN'T WORK ------------------------------
        //date format yyyy-mm-dd
        //public List<T> LoadMiddleRatesByCurrencyAndDate<T>(string table, string today, string yesterday)
        //{
        //    var collection = db.GetCollection<T>(table);

        //    //var match = new BsonDocument
        //    //    {
        //    //        {
        //    //            "$match",
        //    //            new BsonDocument
        //    //                {
        //    //                    {"Date", today},
        //    //                    {"Date", yesterday}
        //    //                }
        //    //        }
        //    //    };



        //    //var group = new BsonDocument
        //    //    {
        //    //        { "$group",
        //    //            new BsonDocument
        //    //                {
        //    //                    { "_id", new BsonDocument
        //    //                        {
        //    //                            {
        //    //                                "Currency","$Currency"
        //    //                            }
        //    //                        }
        //    //                    },
        //    //                    { "today", new BsonDocument
        //    //                        {
        //    //                            {
        //    //                                "$first", "$MiddleRate"
        //    //                            }
        //    //                        }
        //    //                    },
        //    //                    { "yesterday", new BsonDocument
        //    //                        {
        //    //                            {
        //    //                                "$last", "$MiddleRate"
        //    //                            }
        //    //                        }
        //    //                    }
        //    //                }
        //    //         }
        //    //      };

        //    //var pipeline = new[] { match, group };
        //    //var mrList = collection.Aggregate<T>(pipeline);


        //    var filter = (Builders<T>.Filter.Eq("Date", today) | Builders<T>.Filter.Eq("Date", yesterday));

        //    //var mrList = collection.Aggregate()
        //    //    .Match()
        //    //    .Group()
        //    //    .Project()

        //    var mrList = collection.Find(filter).Project<T>(Builders<T>.Projection.Exclude("_id")).ToList();
        //    return mrList;
        //}

    }
}
