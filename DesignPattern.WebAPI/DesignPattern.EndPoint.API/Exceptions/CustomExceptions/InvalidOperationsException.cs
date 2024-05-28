namespace DesignPattern.EndPoint.API.Exceptions.CustomExceptions;

public class InvalidOperationsException : CalculatorException
{
    private static readonly string Message = "عملگر اشتباه را وارد کردید";

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
    public InvalidOperationsException(char operation) : base($"{Message} ({operation})")
    {
        Operation = $"{operation}";
    }


}
