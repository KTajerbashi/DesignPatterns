using DesignPatterns.BehavioralPatterns.State.Examples.OrderState.Entity;
using DesignPatterns.BehavioralPatterns.State.Examples.OrderState.Enums;
using DesignPatterns.BehavioralPatterns.State.Examples.OrderState.Services;
using DesignPatterns.BehavioralPatterns.State.Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehavioralPatterns.State.Container
{
    public class StateContainer
    {

        public void Pattern()
        {
            Context context = new Context();
            context.Request();
            context.Request();
            context.Request();
            context.Request();
        }
        internal void Execute()
        {
            throw new NotImplementedException();
        }
        public void OrderState()
        {
            OrderEntity order = new OrderEntity(new Waiting_To_Send());
            order.Cancelled();
            order.Send();
            order.Delivered();
        }
    }
}
