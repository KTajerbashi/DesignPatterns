namespace DesignPatterns.BehavioralPatterns.Mediator.Pattern
{

    public abstract class Mediator
    {
        protected ConcreteAColleague ConcreteAColleague;
        protected ConcreteBColleague ConcreteBColleague;

        protected Mediator(ConcreteAColleague concreteAColleague, ConcreteBColleague concreteBColleague)
        {
            ConcreteAColleague = concreteAColleague;
            ConcreteBColleague = concreteBColleague;
        }

        public abstract void NotifyChange(string message, Colleague colleague);
    }

}
