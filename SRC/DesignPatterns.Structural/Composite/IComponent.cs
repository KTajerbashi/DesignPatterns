namespace DesignPatterns.Structural.Composite;

// Component interface
public interface IComponent
{
    string Name { get; }
    void Display(int depth = 0);
    string GetDisplayText(int depth = 0);
}

// Leaf node
public class FileItem : IComponent
{
    public string Name { get; }

    public FileItem(string name)
    {
        Name = name;
    }

    public void Display(int depth = 0)
    {
        Console.WriteLine(new string('-', depth) + Name);
    }

    public string GetDisplayText(int depth = 0)
    {
        return $"{new string('-', depth)}📄 {Name}\n";
    }
}

// Composite node
public class FolderItem : IComponent
{
    public string Name { get; }
    private readonly List<IComponent> _children = new();

    public FolderItem(string name)
    {
        Name = name;
    }

    public void Add(IComponent component)
    {
        _children.Add(component);
    }

    public void Remove(IComponent component)
    {
        _children.Remove(component);
    }

    public void Display(int depth = 0)
    {
        Console.WriteLine(new string('-', depth) + Name);
        foreach (var child in _children)
        {
            child.Display(depth + 2);
        }
    }

    public string GetDisplayText(int depth = 0)
    {
        string result = $"{new string('-', depth)}📁 {Name}\n";
        foreach (var child in _children)
        {
            result += child.GetDisplayText(depth + 2);
        }
        return result;
    }
}

