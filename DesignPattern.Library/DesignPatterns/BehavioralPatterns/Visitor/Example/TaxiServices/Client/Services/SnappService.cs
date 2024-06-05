using DesignPatterns.BehavioralPatterns.Visitor.Example.TaxiServices.Client.Interfaces;
using DesignPatterns.BehavioralPatterns.Visitor.Example.TaxiServices.Services;

namespace DesignPatterns.BehavioralPatterns.Visitor.Example.TaxiServices.Client.Services
{
    public class SnappService : ITaxiRepository
    {
        public string DriverName { get; private set; }
        public string CustomerName { get; private set; }
        public SnappService(string driverName, string customerName)
        {
            DriverName = driverName;
            CustomerName = customerName;
        }
        public void Accept(VisitorTaxi visitor)
        {
            visitor.VisitSnappCall(this);
        }
    }
}
