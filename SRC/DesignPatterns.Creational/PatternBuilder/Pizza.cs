namespace DesignPatterns.Creational.PatternBuilder;

public class Pizza
{
    public string Size { get; set; } = "Medium";
    public string Crust { get; set; } = "Regular";
    public List<string> Toppings { get; set; } = new();

    public override string ToString()
    {
        var toppings = Toppings.Count > 0 ? string.Join(", ", Toppings) : "No Toppings";
        return $"Size: {Size}, Crust: {Crust}, Toppings: {toppings}";
    }
}

public interface IPizzaBuilder
{
    void SetSize(string size);
    void SetCrust(string crust);
    void AddTopping(string topping);
    Pizza Build();
}

public class VeggiePizzaBuilder : IPizzaBuilder
{
    private Pizza pizza = new();

    public void SetSize(string size) => pizza.Size = size;
    public void SetCrust(string crust) => pizza.Crust = crust;
    public void AddTopping(string topping) => pizza.Toppings.Add(topping);
    public Pizza Build()
    {
        var result = pizza;
        pizza = new(); // Reset for next build
        return result;
    }
}

public class MeatPizzaBuilder : IPizzaBuilder
{
    private Pizza pizza = new();

    public void SetSize(string size) => pizza.Size = size;
    public void SetCrust(string crust) => pizza.Crust = crust;
    public void AddTopping(string topping) => pizza.Toppings.Add(topping);
    public Pizza Build()
    {
        var result = pizza;
        pizza = new();
        return result;
    }
}

public class PizzaDirector
{
    private readonly IPizzaBuilder builder;

    public PizzaDirector(IPizzaBuilder builder) => this.builder = builder;

    public void BuildMargherita()
    {
        builder.SetSize("Medium");
        builder.SetCrust("Thin");
        builder.AddTopping("Tomato");
        builder.AddTopping("Cheese");
        builder.AddTopping("Basil");
    }

    public void BuildPepperoni()
    {
        builder.SetSize("Large");
        builder.SetCrust("Regular");
        builder.AddTopping("Pepperoni");
        builder.AddTopping("Cheese");
        builder.AddTopping("Olives");
    }
}