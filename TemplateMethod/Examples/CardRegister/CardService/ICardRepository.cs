using DesignPatterns.TemplateMethod.Examples.CardRegister.MailRepository;

namespace DesignPatterns.TemplateMethod.Examples.CardRegister.CardService
{
    public interface ICardRepository
    {
        void Execute();
    }
    public abstract class CardService : ICardRepository
    {
        protected void ChangeStock()
        {
            Console.WriteLine($"CardService.ChangeStock() Run ...");
        }

        protected void RegisterOrder()
        {
            Console.WriteLine($"CardService.RegisterOrder() Run ...");
        }

        protected void SelectedOrder()
        {
            Console.WriteLine($"CardService.SelectedOrder() Run ...");
        }

        protected abstract void SendNotification();


        public void Execute()
        {
            SelectedOrder();
            RegisterOrder();
            ChangeStock();
            SendNotification();
        }
    }

    public class ConcreteCardServiceGmailService : CardService
    {
        private readonly IMailRepository mailRepository;
        public ConcreteCardServiceGmailService()
        {
            mailRepository = new GmailService();
        }

        protected override void SendNotification()
        {
            mailRepository.Send();
        }
    }

    public class ConcreteCardServiceYahooService : CardService
    {
        private readonly IMailRepository mailRepository;
        public ConcreteCardServiceYahooService()
        {
            mailRepository = new YahooService();
        }
        protected override void SendNotification()
        {
            mailRepository.Send();
        }
    }

    public class ClientRegisterCardOrder
    {
        public static void Execute(CardService cardService)
        {
            cardService.Execute();
        }
    }

}
