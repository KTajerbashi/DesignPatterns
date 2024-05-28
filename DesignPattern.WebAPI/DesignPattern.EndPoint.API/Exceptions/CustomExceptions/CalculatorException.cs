namespace DesignPattern.EndPoint.API.Exceptions.CustomExceptions;

public class CalculatorException : Exception
{
    public string Operation { get; set; }
    private static readonly string DefaultMessage = $"عملگر نامعتبر است";
    public CalculatorException() : base(DefaultMessage)
    {

    }
    public CalculatorException(Exception exception) : base(DefaultMessage, exception)
    {

    }
    public CalculatorException(string message, Exception exception) : base(message, exception)
    {

    }
    public CalculatorException(string operation) : base(DefaultMessage)
    {
        Operation = operation;
    }

    public CalculatorException(string operation, string message) : base(message)
    {
        Operation = operation;
    }

    public CalculatorException(string operation, string message, Exception exception) : base(message, exception)
    {
        Operation = operation;
    }

    public override string Message
    {
        get
        {
            string _message = base.Message;
            if (Operation is not null)
            {
                return $"{_message} \n {Operation}";
            }
            return _message;
        }
    }


}
