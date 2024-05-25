using DesignPatterns.AbstractFactory.Container;
using DesignPatterns.Adapter.Container;
using DesignPatterns.Bridge.Container;
using DesignPatterns.Builder.Container;
using DesignPatterns.ChainOfResponsibility.Container;
using DesignPatterns.Commands.Container;
using DesignPatterns.Composite.Container;
using DesignPatterns.Decorator.Container;
using DesignPatterns.Extensions.Exceptions.Container;
using DesignPatterns.Extensions.Logger.Log4Net.Container;
using DesignPatterns.Extensions.Logger.MicrosoftLogger.Container;
using DesignPatterns.Extensions.Logger.NLog.Container;
using DesignPatterns.Extensions.Logger.Serilog.Container;
using DesignPatterns.Extensions.Tools;
using DesignPatterns.Facade.Container;
using DesignPatterns.Factory.Container;
using DesignPatterns.Flyweight.Container;
using DesignPatterns.Interpreter.Container;
using DesignPatterns.Iterator.Container;
using DesignPatterns.Mediator.Container;
using DesignPatterns.Memento.Container;
using DesignPatterns.Observer.Container;
using DesignPatterns.Prototype.Container;
using DesignPatterns.Proxy.Container;
using DesignPatterns.Singleton.Container;
using DesignPatterns.State.Container;
using DesignPatterns.Strategy.Container;
using DesignPatterns.TemplateMethod.Container;
using DesignPatterns.Visitor.Container;
using Microsoft.Extensions.Logging;

namespace DesignPatterns
{
    public class MainApplication
    {
        private readonly ILogger logger;
        public MainApplication(ILoggerFactory logger)
        {
            this.logger = logger.CreateLogger("Tajerbashi");

        }
        public void Execute(string key)
        {
            DesignConsole Console = DesignConsole.DesignInstance();
            switch (key)
            {
                case "0":
                    {
                        Console.WriteLine("Microsoft Logger");
                        logger.Log(LogLevel.Trace, "=======> Log Level Trace");
                        logger.Log(LogLevel.Debug, "=======> Log Level Debug");
                        logger.Log(LogLevel.Information, LogEventId.InsertItem, "=======> Log Level Information");
                        logger.Log(LogLevel.Warning, "=======> Log Level Warning");
                        logger.Log(LogLevel.Error, "=======> Log Level Error");
                        logger.Log(LogLevel.Critical, "=======> Log Level Critical");
                        logger.Log(LogLevel.None, "=======> Log Level None");
                        MicrosoftLoggerContainer main = new();
                        main.Execute();
                        break;
                    }
                case "1":
                    {
                        Console.WriteLine("Singleton");
                        SingletonContainer main = new();
                        main.Execute();
                        break;
                    }
                case "2":
                    {
                        Console.WriteLine("Factory");
                        FactoryContainer main = new();
                        main.Execute();
                        break;
                    }
                case "3":
                    {
                        Console.WriteLine("Abstract Factory");
                        AbstractFactoryContainer main = new();
                        main.Execute();
                        break;
                    }
                case "4":
                    {
                        Console.WriteLine("Builder");
                        BuilderContainer main =new();
                        main.Execute();
                        break;
                    }
                case "5":
                    {
                        Console.WriteLine("Prototype");
                        PrototypeContainer main =new();
                        main.Execute();
                        break;
                    }
                case "6":
                    {
                        Console.WriteLine("Adapter");
                        AdapterContainer main =new();
                        main.Execute();
                        break;
                    }
                case "7":
                    {
                        Console.WriteLine("Bridge");
                        BridgeContainer main =new();
                        main.Execute();
                        break;
                    }
                case "8":
                    {
                        Console.WriteLine("Composite");
                        CompositeContainer main =new();
                        main.Execute();
                        break;
                    }
                case "9":
                    {
                        Console.WriteLine("Decorator");
                        DecoratorContainer main =new();
                        main.Execute();
                        break;
                    }
                case "10":
                    {
                        Console.WriteLine("Facade");
                        FacadeContainer main =new();
                        main.Execute();
                        break;
                    }
                case "11":
                    {
                        Console.WriteLine("Flyweight");
                        FlyweightContainer main =new();
                        main.Execute();
                        break;
                    }
                case "12":
                    {
                        Console.WriteLine("Proxy");
                        ProxyContainer main =new();
                        main.Execute();
                        break;
                    }
                case "13":
                    {
                        Console.WriteLine("Chain of Responsibility");
                        ChainOfResponsibilityContainer main =new();
                        main.Execute();
                        break;
                    }
                case "14":
                    {
                        Console.WriteLine("Command");
                        CommandContainer main =new();
                        main.Execute();
                        break;
                    }
                case "15":
                    {
                        Console.WriteLine("Interpreter");
                        InterpreterContainer main =new();
                        main.Execute();
                        break;
                    }
                case "16":
                    {
                        Console.WriteLine("Iterator");
                        IteratorContainer main =new();
                        main.Execute();
                        break;
                    }
                case "17":
                    {
                        Console.WriteLine("Mediator");
                        MediatorContainer main =new();
                        main.Execute();
                        break;
                    }
                case "18":
                    {
                        Console.WriteLine("Memento");
                        MementoContainer main =new();
                        main.Execute();
                        break;
                    }
                case "19":
                    {
                        Console.WriteLine("Observer");
                        ObserverContainer main =new();
                        main.Execute();
                        break;
                    }
                case "20":
                    {
                        Console.WriteLine("State");
                        StateContainer main =new();
                        main.Execute();
                        break;
                    }
                case "21":
                    {
                        Console.WriteLine("Strategy");
                        StrategyContainer main =new();
                        main.Execute();
                        break;
                    }
                case "22":
                    {
                        Console.WriteLine("Template Method");
                        TemplateMethodContainer main =new();
                        main.Execute();
                        break;
                    }
                case "23":
                    {
                        Console.WriteLine("Visitor");
                        VisitorContainer main =new();
                        main.Execute();
                        break;
                    }
                case "24":
                    {
                        Console.WriteLine("Serilog");
                        SerilogContainer main =new();
                        main.Execute();
                        break;
                    }
                case "25":
                    {
                        Console.WriteLine("NLog");
                        NLogContainer main =new();
                        main.Execute();
                        break;
                    }
                case "26":
                    {
                        Console.WriteLine("Log4Net");
                        Log4NetContainer main =new();
                        main.Execute();
                        break;
                    }
                case "27":
                    {
                        Console.WriteLine("Log4Net");
                        ExceptionContainer main =new();
                        main.Execute();
                        break;
                    }
                case "cls":
                case "CLS":
                    {
                        Console.Clear();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Invalid Key");
                        break;
                    }
            }
        }
    }
}
