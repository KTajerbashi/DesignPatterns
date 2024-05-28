namespace DesignPattern.EndPoint.API.Exceptions.CustomExceptions
{
    public class NotFoundExceptions : Exception
    {
        public NotFoundExceptions() : base() { }
        public NotFoundExceptions(string message) : base(message) { }
        public NotFoundExceptions(string message, object key) : base($"اطلاعاتی با شناسه فوق {key} یافت نشده است") { }
        public NotFoundExceptions(string message, Exception exception) : base(message, exception) { }
        public NotFoundExceptions(Exception exception) : base(exception.Message) { }
    }
}
