using DesignPatterns.BehavioralPatterns.State.Examples.OrderState.Entity;
using DesignPatterns.BehavioralPatterns.State.Examples.OrderState.Enums;
using DesignPatterns.BehavioralPatterns.State.Examples.OrderState.Repository;

namespace DesignPatterns.BehavioralPatterns.State.Examples.OrderState.Services
{
    public class SentState : IOrderState
    {
        public OrderStatus OrderStatus 
            => OrderStatus.Sent;
        public bool CanCancel(OrderEntity order)
        {
            return true;
        }

        public void Cancel(OrderEntity order)
        {
            Console.WriteLine("Order Cancelled");
            order.ChangeState(new CancelledState());
        }

        public bool CanDelivered(OrderEntity order)
        {
            return true;
        }

        public bool CanSent(OrderEntity order)
        {
            return false;
        }

        public void Delivered(OrderEntity order)
        {
            Console.WriteLine("Yes");
        }

        public void Sent(OrderEntity order)
        {
            Console.WriteLine("No");
        }
    }

}
