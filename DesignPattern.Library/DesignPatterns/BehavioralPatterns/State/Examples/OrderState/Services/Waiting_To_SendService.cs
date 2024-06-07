using DesignPatterns.BehavioralPatterns.State.Examples.OrderState.Entity;
using DesignPatterns.BehavioralPatterns.State.Examples.OrderState.Enums;
using DesignPatterns.BehavioralPatterns.State.Examples.OrderState.Repository;

namespace DesignPatterns.BehavioralPatterns.State.Examples.OrderState.Services
{
    public class Waiting_To_Send : IOrderState
    {
        public OrderStatus OrderStatus { get => OrderStatus.Waiting_To_Send; }

        public bool CanCancel(OrderEntity order)
        {
            return true;
        }

        public void Cancel(OrderEntity order)
        {
            /// Cancel Code 
            /// 
            Console.WriteLine("Order Canceled");
            order.ChangeState(new CancelledState());
        }

        public bool CanDelivered(OrderEntity order)
        {
            Console.WriteLine("Can After Sent");
            return true;
        }

        public bool CanSent(OrderEntity order)
        {
            Console.WriteLine("No Sent Again");
            return false;
        }

        public void Delivered(OrderEntity order)
        {
            Console.WriteLine("Delivered ...");
            order.ChangeState(new DeliveredState());
        }

        public void Sent(OrderEntity order)
        {
            Console.WriteLine("Sent The Order ...");
        }
    }

}
