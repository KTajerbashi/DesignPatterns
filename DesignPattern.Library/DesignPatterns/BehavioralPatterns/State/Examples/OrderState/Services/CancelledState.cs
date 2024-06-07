using DesignPatterns.BehavioralPatterns.State.Examples.OrderState.Entity;
using DesignPatterns.BehavioralPatterns.State.Examples.OrderState.Enums;
using DesignPatterns.BehavioralPatterns.State.Examples.OrderState.Repository;

namespace DesignPatterns.BehavioralPatterns.State.Examples.OrderState.Services
{
    public class CancelledState : IOrderState
    {
        public OrderStatus OrderStatus
            => OrderStatus.Canceled;
        public bool CanCancel(OrderEntity order)
        {
            return false;
        }

        public void Cancel(OrderEntity order)
        {
            throw new NotImplementedException("");
        }

        public bool CanDelivered(OrderEntity order)
        {
            return false;
        }

        public bool CanSent(OrderEntity order)
        {
            return false;
        }

        public void Delivered(OrderEntity order)
        {
            throw new NotImplementedException("Order Cancelled and can not Delivered....");
        }

        public void Sent(OrderEntity order)
        {
            throw new NotImplementedException("Order Cancelled and can not sent....");
        }
    }

}
