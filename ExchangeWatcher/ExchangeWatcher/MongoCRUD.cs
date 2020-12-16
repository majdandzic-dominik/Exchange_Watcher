using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeWatcher
{
    class MongoCRUD
    {
        private IMongoDatabase db;

        public MongoCRUD(string database)
        {
            var client = new MongoClient("mongodb+srv://docMinike:D2bgSWT7M3XGWJwP@exchangeratescluster.mwakl.mongodb.net/ExchangeRates?retryWrites=true&w=majority");
            db = client.GetDatabase(database);
        }

        public string InsertUserIfNotExist<T>(string table, T user, string userName, string email)
        {
            var collection = db.GetCollection<T>(table);

            var filterUserName = Builders<T>.Filter.Eq("UserName", userName);
            var filterEmail = Builders<T>.Filter.Eq("Email", email);

            if (collection.Find(filterUserName).ToList().Count == 0 && collection.Find(filterEmail).ToList().Count == 0)
            {
                collection.InsertOneAsync(user);
                return "Sign up successfull.";
            }

            else if (collection.Find(filterUserName).ToList().Count != 0 && collection.Find(filterEmail).ToList().Count == 0)
            {
                return "User name already in use";
            }

            else if (collection.Find(filterUserName).ToList().Count == 0 && collection.Find(filterEmail).ToList().Count != 0)
            {
                return "Email already in use";
            }

            return "Both user name and email are already in use";


        }
    }
}
