namespace DesignPatterns.BehavioralPatterns.Mediator.Pattern
{
    public class ConcreteMediatorA : Mediator
    {
        public ConcreteMediatorA(ConcreteAColleague concreteAColleague, ConcreteBColleague concreteBColleague) : base(concreteAColleague, concreteBColleague)
        {
        }

        public override void NotifyChange(string message, Colleague colleague)
        {
            if (colleague == ConcreteAColleague)
            {
                ConcreteBColleague.Recevie(message);
            }
            else
            {
                ConcreteAColleague.Recevie(message);
            }
        }
    }

}
