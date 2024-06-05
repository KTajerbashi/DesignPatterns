namespace DesignPatterns.BehavioralPatterns.Visitor.Pattern;

public class ConcreteElementA : Element
{
    public string Name { get; private set; }
    public ConcreteElementA(string name)
    {
        Name = name;
    }
    public override void Accept(Visitor visitor)
    {
        visitor.VisitConcreteElementA(this);
    }
}
