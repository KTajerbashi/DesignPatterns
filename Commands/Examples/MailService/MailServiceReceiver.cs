namespace DesignPatterns.Commands.Examples.MailService
{
    public class MailServiceReceiver
    {
        private string _value;
        public string Value
        {
            get { return _value; }
            set { _value = value; }
        }

        public string AddMail(string text)
        {
            _value += $"({text})";
            return _value;
        }
        public string RemoveMail(string text)
        {
            _value = _value.Substring(0, _value.Length - text.Length);
            return _value;
        }
    }
}
