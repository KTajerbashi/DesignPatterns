using DesignPatterns.BehavioralPatterns.Iterator.Pattern;

namespace DesignPatterns.BehavioralPatterns.Iterator.Container
{
    public class IteratorContainer
    {

        public void Pattern()
        {
            List<string> List = new List<string>();
            List.Add("A");
            foreach (var item in List)
            {
                Console.WriteLine(item);
            }
            ConcreteAggregate concreteAggregate = new ConcreteAggregate();
            concreteAggregate[0] = "Item A";
            concreteAggregate[1] = "Item B";
            concreteAggregate[2] = "Item C";
            concreteAggregate[3] = "Item D";
            concreteAggregate[4] = "Item E";
            IIterator iterator = concreteAggregate.CreateIterator();
            object itemIt = iterator.First();
            while (itemIt != null)
            {
                Console.WriteLine($"Iterator : {itemIt}");
                itemIt = iterator.Next();
            }
        }
        internal void Execute()
        {
            throw new NotImplementedException();
        }
    }
}
