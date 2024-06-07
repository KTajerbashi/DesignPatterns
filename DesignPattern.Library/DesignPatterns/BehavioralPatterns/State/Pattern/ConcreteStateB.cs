namespace DesignPatterns.BehavioralPatterns.State.Pattern
{
    public class ConcreteStateB : State
    {
        public override void Handle(Context context)
        {
            Console.WriteLine($"State.ConcreteStateB.Handle() ...");
            context.State = new ConcreteStateC();
        }
    }
}
