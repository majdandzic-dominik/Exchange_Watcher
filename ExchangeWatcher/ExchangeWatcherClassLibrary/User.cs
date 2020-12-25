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

        public User(string userName, string userNameUpper, string email, string password)
        {
            this.UserName = userName;
            this.UserNameUpper = userNameUpper;
            this.Email = email;
            this.Password = password;
        }
        public User()
        {
            UserName = "";
            UserNameUpper = "";
            Email = "";
            Password = "";
        }

        public string UserName { get => userName; set => userName = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public Guid Id1 { get => Id; set => Id = value; }
        public string UserNameUpper { get => userNameUpper; set => userNameUpper = value; }
    }
}
