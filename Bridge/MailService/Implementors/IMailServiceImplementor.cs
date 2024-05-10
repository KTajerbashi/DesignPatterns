using DesignPatterns.Bridge.MailService.Models;

namespace DesignPatterns.Bridge.MailService.Implementors
{
    public interface IMailServiceImplementor
    {
        void SendMail(string reciver, string body);

        List<EmailDTO> GetEmails();
    }
}
