using DesignPatterns.Bridge.MailService.Implementors;
using DesignPatterns.Bridge.MailService.Models;

namespace DesignPatterns.Bridge.MailService.Abstraction
{
    public abstract class MailServiceAbstraction
    {
        private readonly IMailServiceImplementor mailServiceImplementor;

        protected MailServiceAbstraction()
        {
            mailServiceImplementor = Implementation.GetImplementor();
        }

        public virtual void SendEmail(EmailDTO email)
        {
            mailServiceImplementor.SendMail(email.Reciever, email.Message);
        }
    }
    //// انتزاع را از پیاده سازی جدا میکنیم
    public class RefinedMailService : MailServiceAbstraction
    {

    }
}
