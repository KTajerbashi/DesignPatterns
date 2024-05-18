namespace DesignPatterns.Commands.Examples.MailService
{
    public class MailServiceConcrete : MailServiceCommand
    {
        public MailServiceConcrete(MailServiceReceiver mailServiceReceiver) : base(mailServiceReceiver)
        {
        }

        public override string Execute(string input)
        {
            CurrentText = input;
            return mailServiceReceiver.AddMail(input);
        }

        public override string UnExecute(string input)
        {
            CurrentText = input;
            return mailServiceReceiver.RemoveMail(input);
        }
    }
}
