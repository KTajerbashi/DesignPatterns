using DesignPatterns.Commands.Examples.MailService;
using DesignPatterns.Commands.Pattern;
using DesignPatterns.Tools;
using System;

namespace DesignPatterns.Commands.Container
{
    public class CommandContainer
    {
        DesignConsole _Console;
        public CommandContainer()
        {
            _Console = DesignConsole.DesignInstance();
        }
        public void Pattern()
        {
            Receiver receiver = new();
            Command command = new ConcreteCommand(receiver);
            Invoker invoker = new();

            invoker.SetCommand(command);
            invoker.ExecuteCommand();
        }

        public void MailService()
        {
            MailServiceInvoker mailServiceInvoker = new MailServiceInvoker();
            string key = Console.ReadLine();
            while (key != "exit()" || key != "close()")
            {
                if (key == "U")
                {
                    key = mailServiceInvoker.Undo();
                    Console.WriteLine($"Undo {key}");
                }
                else if (key == "R")
                {
                    key = mailServiceInvoker.Redo();
                    Console.WriteLine($"Redo {key}");
                }
                else
                {
                    key = mailServiceInvoker.ExecuteCommand(key);
                    Console.WriteLine($"Invoked {key}");
                }
                _Console.ForeColor();
                key = Console.ReadLine();
            }
        }
    }
}
