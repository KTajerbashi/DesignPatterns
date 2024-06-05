namespace DesignPatterns.BehavioralPatterns.Visitor.Pattern;

public class ObjectStructure
{
    private List<Element> Elements = new List<Element>();
    public void Add(Element element)
    {
        Elements.Add(element);
    }
    public void Remove(Element element)
    {
        Elements.Remove(element);
    }
    public void Get()
    {
        foreach (var item in Elements)
        {
            Console.WriteLine($"Name : {item.GetType().Name}");
        }
    }
    public void Accept(Visitor visitor)
    {
        foreach (var item in Elements)
        {
            item.Accept(visitor);
        }
    }
}