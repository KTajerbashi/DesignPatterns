namespace DesignPatterns.Behavioral.Memento;

// The Memento stores the state of the Editor
public class Memento
{
    public string State { get; }

    public Memento(string state)
    {
        State = state;
    }
}

// The Editor is the originator that creates and restores mementos
public class Editor
{
    public string Content { get; private set; } = string.Empty;

    public void Type(string text)
    {
        Content += text;
    }

    public void SetContent(string text)
    {
        Content = text;
    }

    public Memento Save()
    {
        return new Memento(Content);
    }

    public void Restore(Memento memento)
    {
        Content = memento.State;
    }
}

// The Caretaker keeps track of mementos for undo functionality
public class Caretaker
{
    private readonly Stack<Memento> _history = new();

    public void SaveState(Memento memento)
    {
        _history.Push(memento);
    }


    public Memento? Undo()
    {
        return _history.Count > 0 ? _history.Pop() : null;
    }

    public bool HasHistory => _history.Count > 0;
}
