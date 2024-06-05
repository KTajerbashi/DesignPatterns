using DesignPatterns.StructuralPatterns.Bridge.Examples.MailService.Models;

namespace DesignPatterns.StructuralPatterns.Bridge.Examples.MailService.Implementors
{
    public interface IMailServiceImplementor
    {
        void SendMail(string reciver, string body);

        List<EmailDTO> GetEmails();
    }
}
