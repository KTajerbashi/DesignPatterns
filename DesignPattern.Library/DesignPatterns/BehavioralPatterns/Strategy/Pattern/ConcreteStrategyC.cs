﻿namespace DesignPatterns.BehavioralPatterns.Strategy.Pattern
{
    public class ConcreteStrategyC : Strategy
    {
        public override void AlgorithmInterface()
        {
            Console.WriteLine($"Strategy => ConcreteStrategyC.AlgorithmInterface()");
        }
    }
}
