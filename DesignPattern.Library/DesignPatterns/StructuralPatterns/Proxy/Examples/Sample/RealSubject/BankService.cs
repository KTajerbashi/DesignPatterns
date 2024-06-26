﻿using DesignPatterns.StructuralPatterns.Proxy.Examples.Sample.MainSource;

namespace DesignPatterns.StructuralPatterns.Proxy.Examples.Sample.RealSubject
{
    internal class BankService : IBankRepository
    {
        public void Deposit()
        {
            Console.WriteLine("Deposit Money From Cart");
        }

        public void Harvest()
        {
            Console.WriteLine("Harvest Money From Cart");
        }
    }
}
