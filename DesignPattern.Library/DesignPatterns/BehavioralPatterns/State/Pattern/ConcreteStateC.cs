namespace DesignPatterns.BehavioralPatterns.State.Pattern
{
    public class ConcreteStateC : State
    {
        public override void Handle(Context context)
        {
            Console.WriteLine($"State.ConcreteStateC.Handle() ...");
            context.State = new ConcreteStateA();
        }
    }
}
