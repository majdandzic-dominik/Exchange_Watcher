using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeWatcherClassLibrary
{
    public class MongoCRUD
    {
        private IMongoDatabase db;

        public MongoCRUD(string database)
        {
            var client = new MongoClient("mongodb+srv://docMinike:D2bgSWT7M3XGWJwP@exchangeratescluster.mwakl.mongodb.net/ExchangeRates?retryWrites=true&w=majority");
            db = client.GetDatabase(database);
        }

        public void InsertData<T>(string table, T data)
        {
            var collection = db.GetCollection<T>(table);
            collection.InsertOneAsync(data);
        }

        public List<T> LoadAllRecords<T>(string table)
        {
            var collection = db.GetCollection<T>(table);
            return collection.Find(_ => true).ToList();
        }

        public string GetUserLogInErrorMsg<User>(string table, string userNameUpper, string email)
        {
            if (GetNumOfUsers<User>(table, userNameUpper) == 0 && GetNumOfEmails<User>(table, email) == 0)
            {
                return "";
            }

            else if (GetNumOfUsers<User>(table, userNameUpper) != 0 && GetNumOfEmails<User>(table, email) == 0)
            {
                return "User name already in use";
            }

            else if (GetNumOfUsers<User>(table, userNameUpper) == 0 && GetNumOfEmails<User>(table, email) != 0)
            {
                return "Email already in use";
            }

            return "Both user name and email are already in use";
        }

        public int GetNumOfUsers<T>(string table, string userNameUpper)
        {
            var collection = db.GetCollection<T>(table);
            var filterUserName = Builders<T>.Filter.Eq("UserNameUpper", userNameUpper);

            return collection.Find(filterUserName).ToList().Count;
        }

        public User GetUser(string table, string userNameUpper)
        {
            var collection = db.GetCollection<User>(table);
            var filter = Builders<User>.Filter.Eq("UserNameUpper", userNameUpper);

            return collection.Find(filter).ToList()[0];
        }

        private int GetNumOfEmails<T>(string table, string email)
        {
            var collection = db.GetCollection<T>(table);
            var filterEmail = Builders<T>.Filter.Eq("Email", email);

            return collection.Find(filterEmail).ToList().Count;
        }

        public string GetUserPasswordHash(string table, string userNameUpper)
        {
            var collection = db.GetCollection<User>(table);
            var filter = Builders<User>.Filter.Eq("UserNameUpper", userNameUpper);

            return collection.Find(filter).ToList()[0].Password;
        }


        public List<T> LoadRecordByDate<T>(string table, string date)
        {
            var collection = db.GetCollection<T>(table);
            var filter = Builders<T>.Filter.Eq("Date", date);

            return collection.Find(filter).ToList();
        }

        public List<Notification> LoadUsersNotifications<T>(string table, string userNameUpper)
        {
            var collection = db.GetCollection<Notification>(table);
            var filter = Builders<Notification>.Filter.Eq("UserNameUpper", userNameUpper);
            return collection.Find(filter).ToList();
        }

        public void UpdateNotification(string table, Notification notification)
        {
            var collection = db.GetCollection<Notification>(table);
            var filter = Builders<Notification>.Filter.Eq("UserNameUpper", notification.UserNameUpper)
                & Builders<Notification>.Filter.Eq("Currency", notification.Currency);

            var update = Builders<Notification>.Update.Set("PercentageChange", notification.PercentageChange);

            collection.UpdateOne(filter, update);
        }

        public void InsertNotification(string table, Notification notification)
        {
            var collection = db.GetCollection<Notification>(table);
            var filter = Builders<Notification>.Filter.Eq("UserNameUpper", notification.UserNameUpper)
                & Builders<Notification>.Filter.Eq("Currency", notification.Currency);


            if (collection.Find(filter).ToList().Count == 0)
            {
                collection.InsertOne(new Notification(notification.Email, notification.UserNameUpper, notification.PercentageChange, notification.Currency));
            }
        }

        public void DeleteNotification(string table, Notification notification)
        {
            var collection = db.GetCollection<Notification>(table);
            var filter = Builders<Notification>.Filter.Eq("UserNameUpper", notification.UserNameUpper)
                & Builders<Notification>.Filter.Eq("Currency", notification.Currency);


            collection.DeleteOne(filter);
        }

        public bool DoesNotificationExist(string table, Notification notification)
        {
            var collection = db.GetCollection<Notification>(table);
            var filter = Builders<Notification>.Filter.Eq("UserNameUpper", notification.UserNameUpper)
                & Builders<Notification>.Filter.Eq("Currency", notification.Currency);

            
            if (collection.Find(filter).ToList().Count != 0)
            {
                return true;
            }
            return false;
        }



        public List<Notification> LoadUserNotifications(string table, string userNameUpper)
        {
            var colletction = db.GetCollection<Notification>(table);
            var filter = Builders<Notification>.Filter.Eq("UserNameUpper", userNameUpper);

            return colletction.Find(filter).ToList();
        }


        public void InsertRecordListByDate<T>(string table, List<T> records, string today)
        {
            var collection = db.GetCollection<T>(table);

            var filter = Builders<T>.Filter.Eq("Date", today);

            if (collection.Find(filter).ToList().Count == 0)
            {
                collection.InsertMany(records);
            }

        }


        public List<T> LoadAllDistinctOneField<T>(string table, string field)
        {
            var collection = db.GetCollection<T>(table);
            return collection.Distinct<T>(field, new BsonDocument()).ToList();
        }

    }
}
