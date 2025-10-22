using System.Collections.Concurrent;

namespace DesignPatterns.Structural.Flyweight;

public interface IShape
{
    void Draw(int x, int y);
    string GetDescription(int x, int y);
}
// Concrete Flyweight
public class Circle : IShape
{
    private readonly string _color; // Intrinsic state (shared)

    public Circle(string color)
    {
        _color = color;
    }

    // Extrinsic state (unique to each usage)
    public void Draw(int x, int y)
    {
        Console.WriteLine($"Drawing {_color} circle at ({x},{y})");
    }

    public string GetDescription(int x, int y)
    {
        return $"🎨 {_color} circle at ({x},{y})";
    }
}

// Flyweight Factory: manages shared flyweights
public class ShapeFactory
{
    private static readonly ConcurrentDictionary<string, IShape> _shapes = new();

    public static IShape GetCircle(string color)
    {
        // Reuse existing shape if color already exists
        if (!_shapes.ContainsKey(color))
        {
            _shapes[color] = new Circle(color);
            Console.WriteLine($"Creating new {_shapes[color].GetType().Name} of color {color}");
        }

        return _shapes[color];
    }

    public static int GetShapeCount() => _shapes.Count;
}