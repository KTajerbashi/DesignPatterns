namespace DesignPatterns.Commands.Pattern
{
    public interface ICommand
    {

        void Execute();
    }
    public abstract class Command : ICommand
    {
        protected Receiver Receiver;

        protected Command(Receiver receiver)
        {
            Receiver = receiver;
        }
        public abstract void Execute();
    }
    public class ConcreteCommand : Command
    {
        public ConcreteCommand(Receiver receiver) : base(receiver)
        {
        }

        public override void Execute()
        {
            Receiver.Action();
        }
    }
    public class Receiver
    {
        public void Action()
        {
            Console.WriteLine("Receiver.Action() Run ...");
        }
    }
    public class Invoker
    {
        private Command Command;
        public void SetCommand(Command command)
        {
            Command = command;
        }
        public void ExecuteCommand()
        {
            Command.Execute();
        }

        private List<Command> Commands;
        public void SetCommands(List<Command> commands)
        {
            Commands = commands;
        }
        public void ExecuteCommands()
        {
            Commands.ForEach(item => item.Execute());
        }
    }
}
