using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeWatcher
{
    class User
    {
        [BsonId]
        private Guid Id;
        private string userName;
        private string email;
        private string password;

        public User(string userName, string email, string password)
        {
            this.UserName = userName;
            this.Email = email;
            this.Password = password;
        }
        public User()
        {
            UserName = "";
            Email = "";
            Password = "";
        }

        public string UserName { get => userName; set => userName = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public Guid Id1 { get => Id; set => Id = value; }
    }
}
