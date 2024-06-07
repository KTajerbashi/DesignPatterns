namespace DesignPatterns.BehavioralPatterns.State.Pattern
{
    public class ConcreteStateA : State
    {
        public override void Handle(Context context)
        {
            Console.WriteLine($"State.ConcreteStateA.Handle() ...");

            context.State = new ConcreteStateB();
        }
    }
}
