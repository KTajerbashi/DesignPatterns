namespace DesignPatterns.BehavioralPatterns.Strategy.Pattern
{
    public class Context
    {
        private Strategy Strategy;
        public Context(Strategy Strategy)
        {
            this.Strategy = Strategy;
        }
        public void ContextInterface()
        {
            Strategy.AlgorithmInterface();
        }
    }
}
