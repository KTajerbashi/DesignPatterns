namespace DesignPatterns.Behavioral.Mediator;

public interface IUser
{
    string Name { get; }
    void Send(string message);
    void Receive(string message, string sender);
}
public class User : IUser
{
    private readonly IChatMediator _mediator;
    public string Name { get; }

    public List<string> Messages { get; } = new();

    public User(string name, IChatMediator mediator)
    {
        Name = name;
        _mediator = mediator;
    }

    public void Send(string message)
    {
        _mediator.SendMessage(message, this);
    }

    public void Receive(string message, string sender)
    {
        Messages.Add($"{sender}: {message}");
    }
}

public interface IChatMediator
{
    void SendMessage(string message, IUser sender);
    void AddUser(IUser user);
}
public class ChatMediator : IChatMediator
{
    private readonly List<IUser> _users = new();

    public void AddUser(IUser user)
    {
        _users.Add(user);
    }

    public void SendMessage(string message, IUser sender)
    {
        foreach (var user in _users)
        {
            if (user != sender)
                user.Receive(message, sender.Name);
        }
    }
}