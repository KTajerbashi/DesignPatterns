namespace DesignPatterns.Extentions.Exceptions.CustomExceptions;

public class CalculatorException : Exception
{
    public string Operation { get; }
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
        this.Operation = operation;
    }

    public CalculatorException(string operation, string message) : base(message)
    {
        this.Operation = operation;
    }

    public CalculatorException(string operation, string message, Exception exception) : base(message, exception)
    {
        this.Operation = operation;
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
            return _message ;
        }
    }


}
