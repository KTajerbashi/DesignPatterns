using DesignPatterns.StructuralPatterns.Adapter.Examples.Notifications.ExternalServices;

namespace DesignPatterns.StructuralPatterns.Adapter.Examples.Notifications
{
    public interface ISendMessage
    {
        void Send();
    }
    public class TelegramService : ISendMessage
    {
        public void Send()
        {
            Console.WriteLine("TelegramService.Send()");
        }
    }
    public class WhatsAppService : ISendMessage
    {
        public void Send()
        {
            Console.WriteLine("WhatsAppService.Send()");
        }
    }
    public class GmailAdapter : ISendMessage
    {
        ExternalService ExternalService = new ExternalService();

        public void Send()
        {
            ExternalService.Execute();
        }
    }
}
