namespace DesignPatterns.BehavioralPatterns.Visitor.Pattern;

public abstract class Visitor
{
    public abstract void VisitConcreteElementA(ConcreteElementA concrete);
    public abstract void VisitConcreteElementB(ConcreteElementB concrete);
}
