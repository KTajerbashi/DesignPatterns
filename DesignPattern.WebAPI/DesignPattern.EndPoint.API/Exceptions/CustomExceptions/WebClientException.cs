namespace DesignPattern.EndPoint.API.Exceptions.CustomExceptions
{
    public class WebClientException : Exception
    {
        public WebClientException() : base() { }
        public WebClientException(string message) : base(message) { }
        public WebClientException(string message, Exception exception) : base(message, exception) { }
    }
}
