using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehavioralPatterns.State.Pattern
{
    public class Context
    {
        public State State { get; set; }

        public Context()
        {
            State = new ConcreteStateA();
        }
        public Context(State state)
        {
            State = state;
        }
        public void Request()
        {
            State.Handle(this);
        }
    }
}
