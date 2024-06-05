namespace DesignPatterns.BehavioralPatterns.Commands.Examples.MailService
{
    public class MailServiceInvoker
    {
        List<MailServiceCommand> DataList = new List<MailServiceCommand>();
        int CurrentIndex = 0;
        MailServiceReceiver receiver = new();

        public string ExecuteCommand(string input)
        {
            MailServiceCommand serviceCommand = new MailServiceConcrete(receiver);
            var result = serviceCommand.Execute(input);

            DataList.Add(serviceCommand);
            CurrentIndex++;

            return result;
        }
        public string Undo()
        {
            MailServiceCommand command = DataList[--CurrentIndex];
            return command.UnExecute(command.CurrentText);
        }
        public string Redo()
        {
            MailServiceCommand command = DataList[CurrentIndex++];
            return command.Execute(command.CurrentText);
        }
    }
}
