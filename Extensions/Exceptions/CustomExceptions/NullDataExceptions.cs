namespace DesignPatterns.Extensions.Exceptions.CustomExceptions
{
    public class NullDataExceptions : Exception
    {
        public NullDataExceptions() : base() { }
        public NullDataExceptions(string message) : base(message) { }
        public NullDataExceptions(string message, Exception exception) : base(message, exception) { }
        public NullDataExceptions(Exception exception) : base(exception.Message) { }
    }
    public class NotFoundExceptions : Exception
    {
        public NotFoundExceptions() : base() { }
        public NotFoundExceptions(string message) : base(message) { }
        public NotFoundExceptions(string message, object key) : base($"اطلاعاتی با شناسه فوق {key} یافت نشده است") { }
        public NotFoundExceptions(string message, Exception exception) : base(message, exception) { }
        public NotFoundExceptions(Exception exception) : base(exception.Message) { }
    }
}
