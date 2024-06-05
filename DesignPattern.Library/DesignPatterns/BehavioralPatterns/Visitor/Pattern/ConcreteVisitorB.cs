namespace DesignPatterns.BehavioralPatterns.Visitor.Pattern;

public class ConcreteVisitorB //: Visitor
{
    public void Visit(ConcreteElementA concrete)
    {
        Console.WriteLine($"{DateTime.Now} ) Type : {concrete.GetType().Name}  =>  Name : {concrete.Name}  =>  Visitor : {this.GetType().Name}");
    }

    public void Visit(ConcreteElementB concrete)
    {
        Console.WriteLine($"{DateTime.Now} ) Type : {concrete.GetType().Name}  =>  Name : {concrete.OrderId}  =>  Visitor : {this.GetType().Name}");
    }
}
