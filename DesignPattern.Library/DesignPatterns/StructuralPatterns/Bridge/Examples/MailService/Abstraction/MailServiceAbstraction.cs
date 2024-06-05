using DesignPatterns.StructuralPatterns.Bridge.Examples.MailService.Implementors;
using DesignPatterns.StructuralPatterns.Bridge.Examples.MailService.Models;

namespace DesignPatterns.StructuralPatterns.Bridge.Examples.MailService.Abstraction
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
