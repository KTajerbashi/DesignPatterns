namespace DesignPatterns.Extentions.Exceptions.CustomExceptions;

public class InvalidOperationsException : Exception
{
    private static readonly string Message = "Invalid Operation parameter";

    public InvalidOperationsException() : base(Message)
    {
    }

    public InvalidOperationsException(string message) : base(message)
    {
    }

    public InvalidOperationsException(Exception innerException) : base(Message, innerException)
    {
    }
    public InvalidOperationsException(string message, Exception innerException) : base(message, innerException)
    {
    }

}
