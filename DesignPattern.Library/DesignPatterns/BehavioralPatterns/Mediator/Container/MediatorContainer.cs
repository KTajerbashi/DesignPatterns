using DesignPatterns.BehavioralPatterns.Mediator.Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehavioralPatterns.Mediator.Container
{
    public class MediatorContainer
    {
        public void Pattern()
        {
            ConcreteAColleague concreteA = new ConcreteAColleague();
            ConcreteBColleague concreteB = new ConcreteBColleague();
            ConcreteMediatorA mediator = new ConcreteMediatorA(concreteA,concreteB);

            concreteA.SetMediator(mediator);
            concreteB.SetMediator(mediator);

            concreteA.Send("~ Hello");
            concreteB.Send("~ How Are You?");

        }
        public void Execute()
        {

        }
    }
}
