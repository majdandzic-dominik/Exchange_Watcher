using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using ExchangeWatcherClassLibrary;

namespace ExchangeWatcherEmailSender
{
    class Program
    {
        static void Main(string[] args)
        {
            string exchangeRatesDatabase = "ExchangeRates";
            string exchangeRatesCollection = "ExchangeRatesList";

            string userDatabase = "Users";
            string userCollection = "UsersList";
            string emailCollection = "EmailNotifications";
            string userField = "UserNameUpper";


            MongoCRUD exchangeRatesDB = new MongoCRUD(exchangeRatesDatabase);

            string today = DateTime.UtcNow.ToString("yyyy-MM-dd");
            string yesterday = DateTime.UtcNow.AddDays(-1).ToString("yyyy-MM-dd");

            var percentageTodayList = exchangeRatesDB.LoadRecordByDate<ExchangeRate>(exchangeRatesCollection, today);
            var percentageYesterdayList = exchangeRatesDB.LoadRecordByDate<ExchangeRate>(exchangeRatesCollection, yesterday);
      
            
            //store percentage change of middle rate by currency
            var mrChangeList = percentageTodayList.Join(percentageYesterdayList,
                                                    arg => arg.Currency, arg => arg.Currency, (first, second) =>
                                                    new { Currency = first.Currency, 
                                                        MRChange = Math.Abs(((Convert.ToDouble(first.MiddleRate) - Convert.ToDouble(second.MiddleRate)) / Convert.ToDouble(second.MiddleRate)) * 100) }).ToList();

            foreach(var v in mrChangeList)
            {
                Console.WriteLine(v.Currency + " " + v.MRChange.ToString());
            }




            MongoCRUD userDB = new MongoCRUD(userDatabase);
            var userList = userDB.LoadAllDistinctOneField<string>(emailCollection, userField);

            var notificationList = new List<Notification>();

            EmailSender emailSender = new EmailSender();
            emailSender.InitializeSmtpClient();

            foreach (var user in userList)
            {
                Console.WriteLine(user);

                Console.WriteLine(userDB.GetUser(userCollection, user).Email);
                
                notificationList = userDB.LoadUserNotifications(emailCollection, user);
                emailSender.ChangeReceiver(userDB.GetUser(userCollection, user).Email, userDB.GetUser(userCollection, user).UserName);
                foreach (var notification in notificationList)
                {
                    var currencyChange = mrChangeList.Find(c => c.Currency == notification.Currency).MRChange;
                    if (currencyChange >= notification.PercentageChange)
                    {
                        Console.WriteLine(notification.Currency + ": " + notification.PercentageChange.ToString());
                        emailSender.AddWatchedCurrency(notification.Currency, currencyChange);
                    }
                }
                Console.WriteLine(emailSender.gettext());
                emailSender.SendEmail();
                emailSender.ClearWatchedCurrencies();
                notificationList.Clear();
                
            }
            





        }
    }
}
