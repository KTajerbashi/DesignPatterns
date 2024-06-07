namespace DesignPatterns.BehavioralPatterns.Iterator.Pattern
{
    public interface IIterator
    {
        object First();
        object Next();
        bool IsDone();
        object CurrentItem();
    }
    public class ConcreteItrator : IIterator
    {
        ConcreteAggregate aggregate;
        int current = 0;
        public ConcreteItrator(ConcreteAggregate aggregate)
        {
            this.aggregate = aggregate;
        }

        public object CurrentItem()
        {
            return aggregate[current];
        }

        public object First()
        {
            return aggregate[0];
        }

        public bool IsDone()
        {
            return current >= aggregate.Count;
        }

        public object Next()
        {
            if (current < aggregate.Count - 1)
            {
                return aggregate[++current];
            }
            else
            {
                return null;
            }
        }
    }

    public abstract class Aggregate
    {
        public abstract IIterator CreateIterator();
    }

    public class ConcreteAggregate : Aggregate
    {
        List<object> Items = new();
        public override IIterator CreateIterator()
        {
            return new ConcreteItrator(this);
        }
        public int Count
        {
            get => Items.Count;
        }
        public object this[int index]
        {
            get => Items[index];
            set => Items.Insert(index, value);
        }
    }
}
