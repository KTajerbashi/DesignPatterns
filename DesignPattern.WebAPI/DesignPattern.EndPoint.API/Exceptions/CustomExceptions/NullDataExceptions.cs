namespace DesignPattern.EndPoint.API.Exceptions.CustomExceptions
{
    public class NullDataExceptions : Exception
    {
        public NullDataExceptions() : base() { }
        public NullDataExceptions(string message) : base(message) { }
        public NullDataExceptions(string message, Exception exception) : base(message, exception) { }
        public NullDataExceptions(Exception exception) : base(exception.Message) { }
    }
}
