namespace DesignPatterns.Composite.Examples.AssembleSystem
{
    public interface IComponent
    {
        string Name { get; set; }
        int Price { get; set; }
        int DisplayPrice();
    }
}
