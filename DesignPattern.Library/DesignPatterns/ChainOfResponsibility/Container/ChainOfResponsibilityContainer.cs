using DesignPatterns.ChainOfResponsibility.Examples.Snapp;
using DesignPatterns.ChainOfResponsibility.Pattern;
using DesignPatterns.Extensions;

namespace DesignPatterns.ChainOfResponsibility.Container
{
    public class ChainOfResponsibilityContainer
    {
        DesignConsole Console;
        public ChainOfResponsibilityContainer()
        {
            Console = DesignConsole.DesignInstance();
        }
        public void Pattern()
        {
            Console.ForeColor();
            Handler handlerA = new ConcreteHandlerA();
            Handler handlerB = new ConcreteHandlerB();
            Console.Section("ChainOfResponsibility");
            handlerA.SetSuccessor(handlerB);
            Console.ForeColor();
            handlerA.HandleRequest(10);
            Console.ForeColor();
            handlerA.HandleRequest(150);
        }


        public void Snapp()
        {
            CheckActiveUser checkActive = new();
            CheckTest checkTest = new();
            CreateOrder createOrder = new();
            SendToDriver sendToDriver = new();
            Console.ForeColor();
            createOrder.SetNext(sendToDriver);

            Console.ForeColor();
            checkActive
                .SetNext(checkTest)
                .SetNext(createOrder)
                .SetNext(sendToDriver);
            Console.ForeColor();
            checkActive.Execute(new RequestContext
            {
                UserId = 1,
                Origin = new Point { Lat = 34.4343, Lang = 78.9077 },
                Destination = new Point { Lat = 54.32423, Lang = 43.2324 }
            });
        }

        internal void Execute()
        {
            throw new NotImplementedException();
        }
    }
}
