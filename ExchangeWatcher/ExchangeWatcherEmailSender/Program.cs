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
            string emailCollection = "EmailNotifications";
            string userField = "UserName";
            string emailField = "Email";

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
            var emailList = userDB.LoadAllDistinctOneField<string>(emailCollection, emailField);

            var notificationList = new List<Notification>();

            EmailSender emailSender = new EmailSender();
            emailSender.InitializeSmtpClient();

            foreach (var user in userList)
            {
                Console.WriteLine(user);
                foreach (var email in emailList)
                {
                    Console.WriteLine(email);
                    if(userDB.DoesUserEmailComboExist(emailCollection, user, email))
                    {
                        notificationList = userDB.LoadUserEmailCombo(emailCollection, user, email);
                        emailSender.ChangeReceiver(email, user);
                        foreach(var notification in notificationList)
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
            


            
            //emailSender.ChangeReceiver("doc000000@gmail.com", "filler username");
            //emailSender.AddWatchedCurrency("EUR", 0.1); //percentage is the change the user want's to track, not the actual change
            ////test values
            //emailSender.AddWatchedCurrency("AUD", 0.2);
            //emailSender.AddWatchedCurrency("CAD", 3.4);
            //emailSender.AddWatchedCurrency("JPY", 0.001);



            

            //foreach (var v in mrChangeList)
            //{
            //    for (int i = 0; i < emailSender.GetNumOfWatcherCurrencies(); i++)
            //    {
            //        if(emailSender.GetWatchedCurrencyAtIndex(i) == v.Currency)
            //        {
            //            if(emailSender.GetPercentChangeAtIndex(i) <= v.MRChange)
            //            {
            //                emailSender.SetPercentChangeAtIndex(i, v.MRChange);                            
            //            }
            //            else
            //            {
            //                emailSender.RemoveWatchedCurrency(i);
            //            }
            //        }                

            //    }
            //}


            

            //double mrChangeForWatchedCurrency;
            //for (int i = 0; i < emailSender.GetNumOfWatcherCurrencies(); i++)
            //{
            //    mrChangeForWatchedCurrency = mrChangeList.First(cur => cur.Currency == emailSender.GetWatchedCurrencyAtIndex(i)).MRChange;
            //    if (mrChangeForWatchedCurrency < emailSender.GetPercentChangeAtIndex(i))
            //    {
            //        emailSender.RemoveWatchedCurrency(i);
            //        if (emailSender.GetNumOfWatcherCurrencies() > 1)
            //        {
            //            i--;
            //        }
            //    }
            //    else
            //    {
            //        emailSender.SetPercentChangeAtIndex(i, mrChangeForWatchedCurrency);
            //    }
                
            //}

            








        }
    }
}
