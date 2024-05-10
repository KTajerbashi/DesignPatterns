using DesignPatterns.Bridge.MailService.Models;

namespace DesignPatterns.Bridge.MailService.Implementors
{
    public class GmailService : IMailServiceImplementor
    {
        public List<EmailDTO> GetEmails()
        {
            throw new NotImplementedException();
        }

        public void SendMail(string reciver, string body)
        {
            /// Gmail Send Codes from another services
            Console.WriteLine($"Gmail Send Successfully to {reciver} with body \n{body}\nby service {nameof(GmailService)}");
        }
    }
}
