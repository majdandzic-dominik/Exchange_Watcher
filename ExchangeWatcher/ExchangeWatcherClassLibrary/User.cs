using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeWatcherClassLibrary
{
    public class User
    {
        [BsonId]
        private Guid Id;
        private string userName;
        private string userNameUpper;
        private string email;
        private string password;
        private List<Notification> notifications;

        public User(string userName, string userNameUpper, string email, string password, List<Notification> notifications)
        {
            this.UserName = userName;
            this.UserNameUpper = userNameUpper;
            this.Email = email;
            this.Password = password;
            this.Notifications = notifications;
        }
        public User()
        {
            UserName = "";
            UserNameUpper = "";
            Email = "";
            Password = "";
            this.Notifications = new List<Notification>();
        }

        public string UserName { get => userName; set => userName = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public Guid Id1 { get => Id; set => Id = value; }
        public string UserNameUpper { get => userNameUpper; set => userNameUpper = value; }
        public List<Notification> Notifications { get => notifications; set => notifications = value; }

        public void addNotification(Notification notification)
        {
            Notifications.Add(notification);
        }
        public void deleteNotificationByCurrency(string currency)
        {
            var itemToRemove = Notifications.Single(r => r.Currency == currency);
            Notifications.Remove(itemToRemove);
        }
        public void updateNotificationByCurrency(string currency, double percentageChange)
        {
            foreach(var n in Notifications)
            {
                if(n.Currency == currency)
                {
                    n.PercentageChange = percentageChange;
                    return;
                }
            }
        }


    }
}
