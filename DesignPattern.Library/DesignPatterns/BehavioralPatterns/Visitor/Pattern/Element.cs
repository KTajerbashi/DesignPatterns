namespace DesignPatterns.BehavioralPatterns.Visitor.Pattern;

public abstract class Element
{
    public abstract void Accept(ConcreteVisitorA visitor);
}
