namespace DesignPatterns.Creational.PatternFactoryMethod;

public interface IMessage
{
    string Send(string to, string content);
}

public class EmailMessage : IMessage
{
    public string Send(string to, string content)
    {
        return $"📧 Email sent to {to}: {content}";
    }
}

public class SmsMessage : IMessage
{
    public string Send(string to, string content)
    {
        return $"📱 SMS sent to {to}: {content}";
    }
}

public abstract class MessageCreator
{
    public abstract IMessage CreateMessage();

    public string SendMessage(string to, string content)
    {
        var message = CreateMessage();
        return message.Send(to, content);
    }
}

public class EmailMessageCreator : MessageCreator
{
    public override IMessage CreateMessage() => new EmailMessage();
}

public class SmsMessageCreator : MessageCreator
{
    public override IMessage CreateMessage() => new SmsMessage();
}

// IMessageFactory
public interface IMessageFactory
{
    IMessage CreateMessage();
}

public class EmailMessageFactory : IMessageFactory
{
    public IMessage CreateMessage() => new EmailMessage();
}

public class SmsMessageFactory : IMessageFactory
{
    public IMessage CreateMessage() => new SmsMessage();
}
