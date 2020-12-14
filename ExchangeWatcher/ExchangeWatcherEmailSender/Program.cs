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
            Console.WriteLine("Email: ");
            string email = Console.ReadLine();
            string subjectText = "FIller subject";
            string messageText = "FIller message";

            Console.WriteLine("Currency: ");
            string currency = Console.ReadLine();
            Console.WriteLine("Percentage: ");
            string percentage = Console.ReadLine();


            string collection = "ExchangeRates";
            string table = "ExchangeRatesList";

            MongoCRUD exchangeRatesDB = new MongoCRUD(collection);

            string today = DateTime.UtcNow.ToString("yyyy-MM-dd");
            string yesterday = DateTime.UtcNow.AddDays(-1).ToString("yyyy-MM-dd");

            var percentageTodayList = exchangeRatesDB.LoadRecordByDate<ExchangeRate>(table, today);
            var percentageYesterdayList = exchangeRatesDB.LoadRecordByDate<ExchangeRate>(table, yesterday);
            List<double> percentageChangeList = new List<double>();
      
            
            //store percentage change of middle rate by currency
            var listTest = percentageTodayList.Join(percentageYesterdayList,
                                                    arg => arg.Currency, arg => arg.Currency, (first, second) =>
                                                    new { Currency = first.Currency, 
                                                        MRChange = Math.Abs(((Convert.ToDouble(first.MiddleRate) - Convert.ToDouble(second.MiddleRate)) / Convert.ToDouble(second.MiddleRate)) * 100) });






            //DOESN'T WORK-------------------------------
            //List<MiddleRatesByCurrency> listMR = new List<MiddleRatesByCurrency>();
            //var listMR2 = exchangeRatesDB.LoadMiddleRatesByCurrencyAndDate<MiddleRatesByCurrency>(table, today, yesterday);
            //Console.WriteLine(listMR2.Count.ToString());
            //i = 0;
            //foreach (var v in listMR2)
            //{
            //    listMR.Add(new MiddleRatesByCurrency(v.Currency, v.MrToday, v.MrYesterday));
            //    listMR[i].PrintString();
            //    i++;
            //}





            //sending the mail
            SmtpClient client = new SmtpClient()
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential()
                {
                    UserName = "exchange.watcher.updates@gmail.com",
                    Password = "kpjsklytglnjsolg"

                }
            };

            MailAddress fromEmail = new MailAddress("exchange.watcher.updates@gmail.com", "Exchange Watcher Team");
            MailAddress toEmail = new MailAddress(email, "filler name");

            MailMessage message = new MailMessage()
            {
                From = fromEmail,
                Subject = subjectText,
                Body = messageText
            };
            message.To.Add(toEmail);

            try
            {
                client.Send(message);
                Console.WriteLine("Mail sent successfully");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error:\n" + e.Message);
            }

            //DOESN'T WORK -----------------------------------------------------------------------------
            //client.SendCompleted += Client_SendCompleted;
            //client.SendMailAsync(message);

        }

        private static void Client_SendCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                Console.WriteLine("Error \n" + e.Error.Message);
                return;
            }
            Console.WriteLine("Mail sent successfuly");
        }






    }
}
