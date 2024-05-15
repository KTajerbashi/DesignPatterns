using DesignPatterns.TemplateMethod.CardRegister.CardService;
using DesignPatterns.TemplateMethod.Pattern;
using DesignPatterns.Tools;
namespace DesignPatterns.TemplateMethod.Container
{
    public class TemplateMethodContainer
    {
        DesignConsole Console;
        public TemplateMethodContainer()
        {
            Console = DesignConsole.DesignInstance();
        }
        public void Pattern()
        {
            Console.ForeColor();
            Client.Run(new ConcreteAbstractClassA());
            Console.ForeColor();
            Client.Run(new ConcreteAbstractClassB());
        }

        public void Example()
        {
            DesignPatterns.TemplateMethod.Example.Client.RunTemplateMethod(new DesignPatterns.TemplateMethod.Example.ConcreteClassA());
        }


        public void RegisterOrder()
        {
            Console.ForeColor();
            ClientRegisterCardOrder.Execute(new ConcreteCardServiceGmailService());
            Console.ForeColor();
            Console.Section();
            Console.ForeColor();
            ClientRegisterCardOrder.Execute(new ConcreteCardServiceYahooService());
        }
    }
}
