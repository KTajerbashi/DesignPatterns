namespace DesignPatterns.Commands.Examples.MailService
{
    public abstract class MailServiceCommand
    {
        protected MailServiceReceiver mailServiceReceiver;
        public string CurrentText { get; set; }
        protected MailServiceCommand(MailServiceReceiver mailServiceReceiver)
        {
            this.mailServiceReceiver = mailServiceReceiver;
        }

        public abstract string Execute(string input);
        public abstract string UnExecute(string input);
    }
}
