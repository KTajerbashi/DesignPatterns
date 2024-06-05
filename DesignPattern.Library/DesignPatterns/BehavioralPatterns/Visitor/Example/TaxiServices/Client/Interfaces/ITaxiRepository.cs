using DesignPatterns.BehavioralPatterns.Visitor.Example.TaxiServices.Services;

namespace DesignPatterns.BehavioralPatterns.Visitor.Example.TaxiServices.Client.Interfaces
{
    public interface ITaxiRepository
    {
        void Accept(VisitorTaxi visitor);
    }
}
