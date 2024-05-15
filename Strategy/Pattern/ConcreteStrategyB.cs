﻿namespace DesignPatterns.Strategy.Pattern
{
    public class ConcreteStrategyB : Strategy
    {
        public override void AlgorithmInterface()
        {
            Console.WriteLine($"Strategy => ConcreteStrategyB.AlgorithmInterface()");
        }
    }
}
