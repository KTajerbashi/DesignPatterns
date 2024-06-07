using DesignPatterns.BehavioralPatterns.State.Examples.OrderState.Entity;
using DesignPatterns.BehavioralPatterns.State.Examples.OrderState.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehavioralPatterns.State.Examples.OrderState.Repository
{
    public interface IOrderState
    {
        bool CanSent(OrderEntity order);
        void Sent(OrderEntity order);

        bool CanCancel(OrderEntity order);
        void Cancel(OrderEntity order);

        bool CanDelivered(OrderEntity order);
        void Delivered(OrderEntity order);

        OrderStatus OrderStatus { get; }
    }
    
}
