namespace DesignPatterns.BehavioralPatterns.Strategy.Pattern
{
    public class ConcreteStrategyA : Strategy
    {
        public override void AlgorithmInterface()
        {
            Console.WriteLine($"Strategy => ConcreteStrategyA.AlgorithmInterface()");
        }
    }
}
