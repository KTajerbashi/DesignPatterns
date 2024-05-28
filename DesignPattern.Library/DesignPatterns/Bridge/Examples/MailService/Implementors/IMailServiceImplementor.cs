using DesignPatterns.Bridge.Examples.MailService.Models;

namespace DesignPatterns.Bridge.Examples.MailService.Implementors
{
    public interface IMailServiceImplementor
    {
        void SendMail(string reciver, string body);

        List<EmailDTO> GetEmails();
    }
}
