using DesignPatterns.BehavioralPatterns.Visitor.Example.TaxiServices.Client.Interfaces;
using DesignPatterns.BehavioralPatterns.Visitor.Example.TaxiServices.Services;

namespace DesignPatterns.BehavioralPatterns.Visitor.Example.TaxiServices.Objector
{
    public class ObjectStructureTaxi
    {
        public List<ITaxiRepository> Services = new List<ITaxiRepository>();

        public void Add(ITaxiRepository taxi)
        {
            Services.Add(taxi);
        }
        public void Remove(ITaxiRepository taxi)
        {
            Services.Remove(taxi);
        }
        public void Get(ITaxiRepository taxi)
        {
            foreach (var item in Services)
            {
                Console.WriteLine($"Name : {item.GetType().Name}");
            }
        }
        public void Accept(VisitorTaxi visitor)
        {
            foreach (var item in Services)
            {
                item.Accept(visitor);
            }
        }
    }
}
