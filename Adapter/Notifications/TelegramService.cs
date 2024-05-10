namespace DesignPatterns.Adapter.Notifications
{
    public class TelegramService : ISendMessage
    {
        public void Send()
        {
            Console.WriteLine("TelegramService.Send()");
        }
    }
}
