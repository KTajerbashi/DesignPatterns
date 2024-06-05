using DesignPatterns.StructuralPatterns.Bridge.Examples.MailService.Models;

namespace DesignPatterns.StructuralPatterns.Bridge.Examples.MailService.Implementors
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
