using DesignPatterns.BehavioralPatterns.Visitor.Example.TaxiServices.Client.Interfaces;
using DesignPatterns.BehavioralPatterns.Visitor.Example.TaxiServices.Services;

namespace DesignPatterns.BehavioralPatterns.Visitor.Example.TaxiServices.Client.Services
{

    public class PersonalTaxiService : ITaxiRepository
    {
        public string DriverName { get; private set; }
        public string CustomerName { get; private set; }
        public PersonalTaxiService(string driverName, string customerName)
        {
            DriverName = driverName;
            CustomerName = customerName;
        }
        public void Accept(VisitorTaxi visitor)
        {
            visitor.VisitPersonalTaxi(this);
        }
    }
}
