using DesignPatterns.Adapter.Notifications.ExternalServices;

namespace DesignPatterns.Adapter.Notifications.Pattern
{
    public class GmailAdapter : ISendMessage
    {
        ExternalService ExternalService = new ExternalService();

        public void Send()
        {
            ExternalService.Execute();
        }
    }
}
