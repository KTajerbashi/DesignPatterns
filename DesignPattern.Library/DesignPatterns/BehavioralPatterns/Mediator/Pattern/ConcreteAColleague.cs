namespace DesignPatterns.BehavioralPatterns.Mediator.Pattern
{
    public class ConcreteAColleague : Colleague
    {
        public override void Send(string message)
        {
            Console.WriteLine($"Send From ConcreteAColleague : {message}");
            base.Send(message);
        }

        public void Recevie(string message)
        {
            Console.WriteLine($"Recevie ConcreteAColleague : {message}");
        }
    }

}
