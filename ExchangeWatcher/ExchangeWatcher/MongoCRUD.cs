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

        public void InsertUser<User>(string table, User user)
        {
            var collection = db.GetCollection<User>(table);
            collection.InsertOneAsync(user);
           

        }

        public string GetUserLogInErrorMsg<User>(string table, string userName, string email)
        {
            var collection = db.GetCollection<User>(table);
            if (GetNumOfUsers<User>(table, userName) == 0 && GetNumOfEmails<User>(table, email) == 0)
            {
                return "";
            }

            else if (GetNumOfUsers<User>(table, userName) != 0 && GetNumOfEmails<User>(table, email) == 0)
            {
                return "User name already in use";
            }

            else if (GetNumOfUsers<User>(table, userName) == 0 && GetNumOfEmails<User>(table, email) != 0)
            {
                return "Email already in use";
            }

            return "Both user name and email are already in use";
        }

        public int GetNumOfUsers<T>(string table, string userName)
        {
            var collection = db.GetCollection<T>(table);
            var filterUserName = Builders<T>.Filter.Eq("UserName", userName);

            return collection.Find(filterUserName).ToList().Count;
        }

        private int GetNumOfEmails<T>(string table, string email)
        {
            var collection = db.GetCollection<T>(table);
            var filterEmail = Builders<T>.Filter.Eq("Email", email);

            return collection.Find(filterEmail).ToList().Count;
        }

        public string GetUserPasswordHash(string table, string userName)
        {
            var collection = db.GetCollection<User>(table);
            var filter = Builders<User>.Filter.Eq("UserName", userName);

            return collection.Find(filter).ToList()[0].Password;
        }


        public List<T> LoadRecordByDate<T>(string table, string date)
        {
            var collection = db.GetCollection<T>(table);
            var filter = Builders<T>.Filter.Eq("Date", date);

            return collection.Find(filter).ToList();
        }




    }
}
