using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehavioralPatterns.Observer.Pattern
{
    public abstract class Observer
    {
        public abstract void Update();
    }
    public class ConcreteObserver : Observer
    {
        public string Name { get; set; }
        private string ObserverState { get; set; }
        public ConcreteSubject ConcreteSubject { get; set; }
        public ConcreteObserver(string name, ConcreteSubject concreteSubject)
        {
            Name = name;
            ConcreteSubject = concreteSubject;
        }

        public override void Update()
        {
            ObserverState = ConcreteSubject.SubjecState;
            Console.WriteLine($"{Name} : ObserverState Update : ({ConcreteSubject.SubjecState} Change to {Name})");
        }
    }
}
