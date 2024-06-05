namespace DesignPatterns.BehavioralPatterns.Observer.Pattern
{
    public abstract class Subject
    {
        private List<Observer> Observers = new List<Observer>();
        public void Attach(Observer observer)
        {
            Observers.Add(observer);
        }
        public void Detach(Observer observer)
        {
            Observers.Remove(observer);
        }
        public void Notify()
        {
            foreach (var item in Observers)
            {
                item.Update();
            }
        }
    }
    public class ConcreteSubject : Subject
    {
        public ConcreteSubject()
        {
            Console.WriteLine($"Subject ConcreteSubject");
        }
        public string SubjecState { get; set; }

    }
}
