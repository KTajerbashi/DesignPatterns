namespace DesignPatterns.BehavioralPatterns.Mediator.Pattern
{
    public class ConcreteBColleague : Colleague
    {
        public override void Send(string message)
        {
            Console.WriteLine($"Send From ConcreteBColleague : {message}");
            base.Send(message);
        }

        public void Recevie(string message)
        {
            Console.WriteLine($"Recevie ConcreteBColleague : {message}");
        }
    }

}
