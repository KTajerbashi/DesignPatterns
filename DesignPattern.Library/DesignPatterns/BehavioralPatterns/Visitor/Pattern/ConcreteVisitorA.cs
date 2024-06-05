namespace DesignPatterns.BehavioralPatterns.Visitor.Pattern;

public class ConcreteVisitorA : Visitor
{
    public override void VisitConcreteElementA(ConcreteElementA concrete)
    {
        Console.WriteLine($"{DateTime.Now} ) Type : {concrete.GetType().Name}  =>  Name : {concrete.Name}  =>  Visitor : {this.GetType().Name}");
    }

    public override void VisitConcreteElementB(ConcreteElementB concrete)
    {
        Console.WriteLine($"{DateTime.Now} ) Type : {concrete.GetType().Name}  =>  Name : {concrete.OrderId}  =>  Visitor : {this.GetType().Name}");
    }
}
