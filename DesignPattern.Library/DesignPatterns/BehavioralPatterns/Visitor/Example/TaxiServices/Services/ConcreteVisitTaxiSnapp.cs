using DesignPatterns.BehavioralPatterns.Visitor.Example.TaxiServices.Client.Services;

namespace DesignPatterns.BehavioralPatterns.Visitor.Example.TaxiServices.Services
{
    public class ConcreteVisitTaxiSnapp : VisitorTaxi
    {
        public override void VisitOlaCall(OlaService ola)
        {
            Console.WriteLine($"{DateTime.Now} ) Type : {ola.GetType().Name}  =>  DriverName : {ola.DriverName}  =>  CustomerName : {ola.CustomerName} =>  Visitor : {this.GetType().Name}");
        }

        public override void VisitPersonalTaxi(PersonalTaxiService personal)
        {
            Console.WriteLine($"{DateTime.Now} ) Type : {personal.GetType().Name}  =>  DriverName : {personal.DriverName}  =>  CustomerName : {personal.CustomerName} =>  Visitor : {this.GetType().Name}");
        }

        public override void VisitSnappCall(SnappService snapp)
        {
            Console.WriteLine($"{DateTime.Now} ) Type : {snapp.GetType().Name}  =>  DriverName : {snapp.DriverName}  =>  CustomerName : {snapp.CustomerName} =>  Visitor : {this.GetType().Name}");
        }
    }
}
