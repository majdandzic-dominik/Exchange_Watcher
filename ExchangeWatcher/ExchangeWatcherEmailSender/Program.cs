using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;

namespace ExchangeWatcherEmailSender
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Email: ");
            //string email = Console.ReadLine();
            //string subjectText = "FIller subject";
            //string messageText = "FIller message";

            //Console.WriteLine("Currency: ");
            //string currency = Console.ReadLine();
            //Console.WriteLine("Percentage: ");
            //string percentage = Console.ReadLine();



            MongoCRUD db = new MongoCRUD("ExchangeRates");

            string today = DateTime.UtcNow.ToString("yyyy-MM-dd");
            string yesterday = DateTime.UtcNow.AddDays(-1).ToString("yyyy-MM-dd");

            var percentageTodayList = db.LoadRecordByDate<ExchangeRate>("ExchangeRatesList", today);
            var percentageYesterdayList = db.LoadRecordByDate<ExchangeRate>("ExchangeRatesList", yesterday);
            List<double> percentageChangeList = new List<double>();

            double percentageToday;
            double percentageYesterday;

            int i = 0;
            foreach (var v in percentageTodayList)
            {
                percentageToday = Convert.ToDouble(v.MiddleRate);
                percentageYesterday = Convert.ToDouble(percentageYesterdayList[i].MiddleRate);
                percentageChangeList.Add(Math.Abs(((percentageToday - percentageYesterday) / percentageYesterday)));
                i++;
            }

            foreach(var v in percentageChangeList)
            {
                Console.WriteLine(v.ToString());
            }

           













            //sending the mail
            //SmtpClient client = new SmtpClient()
            //{
            //    Host = "smtp.gmail.com",
            //    Port = 587,
            //    EnableSsl = true,
            //    DeliveryMethod = SmtpDeliveryMethod.Network,
            //    UseDefaultCredentials = false,
            //    Credentials = new NetworkCredential()
            //    {
            //        UserName = "exchange.watcher.updates@gmail.com",
            //        Password = "kpjsklytglnjsolg"

            //    }
            //};

            //MailAddress fromEmail = new MailAddress("exchange.watcher.updates@gmail.com", "Exchange Watcher Team");
            //MailAddress toEmail = new MailAddress(email, "filler name");

            //MailMessage message = new MailMessage()
            //{
            //    From = fromEmail,
            //    Subject = subjectText,
            //    Body = messageText
            //};
            //message.To.Add(toEmail);

            //try
            //{
            //    client.Send(message);
            //    Console.WriteLine("Mail sent successfully");
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("Error:\n" + e.Message);
            //}

            //DOESNT WORK -----------------------------------------------------------------------------
            //client.SendCompleted += Client_SendCompleted;
            //client.SendMailAsync(message);

        }

        //private static void Client_SendCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        //{
        //    if(e.Error != null)
        //    {
        //        Console.WriteLine("Error \n" + e.Error.Message);
        //        return;
        //    }
        //    Console.WriteLine("Mail sent successfuly");
        //}






    }
}
