namespace DesignPatterns.Behavioral.Command;

public interface ICommand
{
    void Execute();
    void Undo();
}
public class Light
{
    public bool IsOn { get; private set; } = false;

    public void On()
    {
        IsOn = true;
    }

    public void Off()
    {
        IsOn = false;
    }
}

public class LightOnCommand : ICommand
{
    private readonly Light _light;

    public LightOnCommand(Light light)
    {
        _light = light;
    }

    public void Execute() => _light.On();
    public void Undo() => _light.Off();
}

public class LightOffCommand : ICommand
{
    private readonly Light _light;

    public LightOffCommand(Light light)
    {
        _light = light;
    }

    public void Execute() => _light.Off();
    public void Undo() => _light.On();
}

public class RemoteControl
{
    private ICommand? _slot;
    private readonly Stack<ICommand> _history = new();

    public void SetCommand(ICommand command)
    {
        _slot = command;
    }

    public void PressButton()
    {
        _slot?.Execute();
        if (_slot != null) _history.Push(_slot);
    }

    public void PressUndo()
    {
        if (_history.Any())
        {
            var command = _history.Pop();
            command.Undo();
        }
    }
}