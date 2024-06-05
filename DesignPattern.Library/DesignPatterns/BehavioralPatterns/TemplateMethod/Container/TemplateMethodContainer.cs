using DesignPatterns.BehavioralPatterns.TemplateMethod.Examples.CardRegister.CardService;
using DesignPatterns.BehavioralPatterns.TemplateMethod.Pattern;
using DesignPatterns.Extensions;

namespace DesignPatterns.BehavioralPatterns.TemplateMethod.Container
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
            //Client.RunTemplateMethod(new Example.ConcreteClassA());
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

        internal void Execute()
        {
            throw new NotImplementedException();
        }
    }
}
