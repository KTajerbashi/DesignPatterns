using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.BehavioralPatterns.State.Examples.OrderState.Enums;
using DesignPatterns.BehavioralPatterns.State.Examples.OrderState.Repository;

namespace DesignPatterns.BehavioralPatterns.State.Examples.OrderState.Entity
{
    /// <summary>
    /// Context Class
    /// </summary>
    public class OrderEntity
    {
        private IOrderState OrderState;

        public OrderEntity(IOrderState orderState)
        {
            OrderState = orderState;
        }
        public void ChangeState(IOrderState order)
        {
            OrderState = order;
        }

        public int ID { get; set; }
        public string CustomerName { get; set; }
        public DateTime CreateDate { get; set; }

       

        public void Send()
        {
            OrderState.Sent(this);
        }
        public void Delivered()
        {
            OrderState.Delivered(this);
        }
        public void Cancelled()
        {
            OrderState.Cancel(this);
        }
    }
}
