﻿using DesignPatterns.Bridge.MailService.Models;

namespace DesignPatterns.Bridge.MailService.Implementors
{
    public class YahooService : IMailServiceImplementor
    {
        public List<EmailDTO> GetEmails()
        {
            throw new NotImplementedException();
        }

        public void SendMail(string reciver, string body)
        {
            /// Gmail Send Codes from another services
            Console.WriteLine($"Yahoo Mail Send Successfully to {reciver} with body \n{body}\nby service {nameof(YahooService)}");
        }
    }
}