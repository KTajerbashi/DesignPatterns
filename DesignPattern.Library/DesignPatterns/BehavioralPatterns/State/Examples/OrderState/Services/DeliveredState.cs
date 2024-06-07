using DesignPatterns.BehavioralPatterns.State.Examples.OrderState.Entity;
using DesignPatterns.BehavioralPatterns.State.Examples.OrderState.Enums;
using DesignPatterns.BehavioralPatterns.State.Examples.OrderState.Repository;

namespace DesignPatterns.BehavioralPatterns.State.Examples.OrderState.Services
{
    public class DeliveredState : IOrderState
    {
        public OrderStatus OrderStatus 
            => OrderStatus.Delivered;
        public bool CanCancel(OrderEntity order)
        {
            return false;
        }

        public void Cancel(OrderEntity order)
        {
            throw new NotImplementedException("Order Can Cancel after deliverd....");
        }

        public bool CanDelivered(OrderEntity order)
        {
            return false;
        }

        public bool CanSent(OrderEntity order)
        {
            throw new NotImplementedException();
        }

        public void Delivered(OrderEntity order)
        {
            throw new NotImplementedException("");
        }

        public void Sent(OrderEntity order)
        {
            throw new NotImplementedException("");
        }
    }

}
