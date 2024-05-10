using DesignPatterns.Proxy.Sample.MainSource;
using DesignPatterns.Proxy.Sample.RealSubject;

namespace DesignPatterns.Proxy.Sample
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
