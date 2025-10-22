namespace DesignPatterns.Structural.Bridge;

// Implementor
public interface IRenderer
{
    string Render(string shapeName);
}
public class VectorRenderer : IRenderer
{
    public string Render(string shapeName) => $"Drawing {shapeName} as VECTORS.";
}
public class RasterRenderer : IRenderer
{
    public string Render(string shapeName) => $"Drawing {shapeName} as PIXELS.";
}
// Abstraction
public abstract class Shape
{
    protected readonly IRenderer Renderer;

    protected Shape(IRenderer renderer)
    {
        Renderer = renderer;
    }

    public abstract string Draw();
}

public class Circle : Shape
{
    public Circle(IRenderer renderer) : base(renderer) { }

    public override string Draw() => Renderer.Render("Circle");
}
public class Square : Shape
{
    public Square(IRenderer renderer) : base(renderer) { }

    public override string Draw() => Renderer.Render("Square");
}


