namespace DesignPatterns.Behavioral.State;

public interface IOrderState
{
    string Name { get; }
    string HandleNext(OrderContext context);
}
public class OrderContext
{
    public IOrderState State { get; private set; }

    public OrderContext()
    {
        State = new NewOrderState();
    }

    public string Proceed()
    {
        return State.HandleNext(this);
    }

    public void SetState(IOrderState newState)
    {
        State = newState;
    }
}
public class NewOrderState : IOrderState
{
    public string Name => "New Order";

    public string HandleNext(OrderContext context)
    {
        context.SetState(new ProcessingState());
        return "Order is now being processed.";
    }
}
public class ProcessingState : IOrderState
{
    public string Name => "Processing";

    public string HandleNext(OrderContext context)
    {
        context.SetState(new ShippedState());
        return "Order has been shipped.";
    }
}
public class ShippedState : IOrderState
{
    public string Name => "Shipped";

    public string HandleNext(OrderContext context)
    {
        context.SetState(new DeliveredState());
        return "Order delivered to customer.";
    }
}
public class DeliveredState : IOrderState
{
    public string Name => "Delivered";

    public string HandleNext(OrderContext context)
    {
        return "Order already delivered. No further transitions.";
    }
}