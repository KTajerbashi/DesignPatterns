namespace DesignPatterns.Creational.PatternPrototype;

public interface IPrototype<T>
{
    T Clone();
}

public class PizzaPrototype : IPrototype<PizzaPrototype>
{
    public string Size { get; set; } = "Medium";
    public string Crust { get; set; } = "Regular";
    public List<string> Toppings { get; set; } = new();

    public PizzaPrototype() { }

    // Copy constructor for deep clone
    private PizzaPrototype(PizzaPrototype pizza)
    {
        Size = pizza.Size;
        Crust = pizza.Crust;
        Toppings = new List<string>(pizza.Toppings);
    }

    public PizzaPrototype Clone() => new PizzaPrototype(this);

    public override string ToString()
    {
        var toppings = Toppings.Count > 0 ? string.Join(", ", Toppings) : "No Toppings";
        return $"Size: {Size}, Crust: {Crust}, Toppings: {toppings}";
    }
}

