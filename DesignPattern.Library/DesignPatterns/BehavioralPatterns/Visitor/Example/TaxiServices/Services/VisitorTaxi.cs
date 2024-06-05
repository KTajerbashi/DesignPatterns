using DesignPatterns.BehavioralPatterns.Visitor.Example.TaxiServices.Client.Services;

namespace DesignPatterns.BehavioralPatterns.Visitor.Example.TaxiServices.Services
{
    public abstract class VisitorTaxi
    {
        public abstract void VisitSnappCall(SnappService snapp);
        public abstract void VisitOlaCall(OlaService ola);
        public abstract void VisitPersonalTaxi(PersonalTaxiService personal);
    }
}
