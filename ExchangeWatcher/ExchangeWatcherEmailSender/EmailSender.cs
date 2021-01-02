using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace ExchangeWatcherEmailSender
{
    class EmailSender
    {
        SmtpClient client;
        MailAddress fromEmail;
        MailAddress toEmail;
        MailMessage message;
        string subjectTxt;
        List<MRChangeByCurrency> watchedCurrencies;
        int updateCount;


        public EmailSender()
        {
            this.fromEmail = new MailAddress("exchange.watcher.updates@gmail.com", "Exchange Watcher Team");
            this.message = new MailMessage();

            this.subjectTxt = "Exchange rates changes, update";
            this.message = new MailMessage()
            {
                From = fromEmail,
                Subject = subjectTxt
            };

            watchedCurrencies = new List<MRChangeByCurrency>();

            updateCount = 0;
        }

        public EmailSender(string toEmail, string emailReceiver)
        {
            this.fromEmail = new MailAddress("exchange.watcher.updates@gmail.com", "Exchange Watcher Team");
            this.toEmail = new MailAddress(toEmail, emailReceiver);

            this.subjectTxt = "Exchange rates changes, update";
            this.message = new MailMessage()
            {
                From = fromEmail,
                Subject = subjectTxt
            };

            watchedCurrencies = new List<MRChangeByCurrency>();

            updateCount = 0;
        }

        public void ChangeReceiver(string toEmail, string emailReceiver)
        {
            this.toEmail = new MailAddress(toEmail, emailReceiver);
        }

        public void InitializeSmtpClient()
        {
            this.client = new SmtpClient()
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
        }

        public void SendEmail()
        {
            this.message.Body = AutoSetMessageText();
            message.To.Add(toEmail);
            if (updateCount > 0)
            {
                try
                {
                    client.Send(message);
                    Console.WriteLine("Mail sent successfully");
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error:\n" + e.Message);
                }
            }
            message.To.Clear();
        }

        public string AutoSetMessageText()
        {
            string msgTxt = "";
            msgTxt += "The exchange rate changes for today are: \r\n";
            foreach (var v in watchedCurrencies)
            {                 
                msgTxt += (v.Currency + ": " + Math.Round(v.MrPercentChange, 4).ToString() + "%\r\n");
            }
            return msgTxt;
        }

        public void AddWatchedCurrency(string currency, double currencyChange)
        {
            watchedCurrencies.Add(new MRChangeByCurrency(currency, currencyChange));
            updateCount++;
        }

        public void ClearWatchedCurrencies()
        {
            watchedCurrencies.Clear();
            updateCount = 0;
        }


        public List<MRChangeByCurrency> GetWatchedCurrenciesList()
        {
            return watchedCurrencies;
        }


        //used for easier testing
        //public string gettext()
        //{
        //    string a = "";
        //    a += toEmail + "\r\n";
        //    a += AutoSetMessageText();
        //    return a;
        //}
    }
}
