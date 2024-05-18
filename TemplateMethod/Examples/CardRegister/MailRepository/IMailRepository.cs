namespace DesignPatterns.TemplateMethod.Examples.CardRegister.MailRepository
{
    public interface IMailRepository
    {
        void Send();
    }
    public abstract class MailService : IMailRepository
    {
        public abstract void Send();
    }
    public class GmailService : MailService
    {
        public override void Send()
        {
            Console.WriteLine("GmailService.Send()");
        }
    }
    public class YahooService : MailService
    {
        public override void Send()
        {
            Console.WriteLine("YahooService.Send()");
        }
    }
}
