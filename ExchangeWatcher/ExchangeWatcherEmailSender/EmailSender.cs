﻿using System;
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
        }

        public string AutoSetMessageText()
        {
            string msgTxt = "";
            foreach (var v in watchedCurrencies)
            { 
                msgTxt += "The exchange rate changes for today are: \r\n";
                msgTxt += (v.Currency + ": " + v.MrPercentChange.ToString() + "%\r\n");
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

        public int GetNumOfWatcherCurrencies()
        {
            return watchedCurrencies.Count;
        }

        public void RemoveWatchedCurrency(int i)
        {
            watchedCurrencies.RemoveAt(i);
            updateCount--;
        }

        public string GetWatchedCurrencyAtIndex(int i)
        {
            return watchedCurrencies[i].Currency;
        }

        public double GetPercentChangeAtIndex(int i)
        {
            return watchedCurrencies[i].MrPercentChange;
        }

        public void SetPercentChangeAtIndex(int i, double percentChange)
        {
            watchedCurrencies[i].MrPercentChange = Math.Round(percentChange, 4);
        }

    }
}
