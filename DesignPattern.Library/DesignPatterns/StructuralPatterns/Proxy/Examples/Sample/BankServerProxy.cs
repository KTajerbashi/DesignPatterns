﻿using DesignPatterns.StructuralPatterns.Proxy.Examples.Sample.MainSource;
using DesignPatterns.StructuralPatterns.Proxy.Examples.Sample.RealSubject;

namespace DesignPatterns.StructuralPatterns.Proxy.Examples.Sample
{
    public class BankServerProxy : IBankRepository
    {
        private BankService bankService;

        public void Deposit()
        {

            bankService.Deposit();
        }

        public void Harvest()
        {
            GetRealSubject().Harvest();
        }

        internal BankService GetRealSubject()
        {
            if (bankService == null)
            {
                bankService = new BankService();
            }
            return bankService;
        }
    }
}
