using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehavioralPatterns.Memento.Pattern
{
    public class Orginator
    {
        string state;
        public string State
        {
            get { return state; }
            set
            {
                state = value;
                Console.WriteLine($"State : {state}");
            }
        }

        public Memento CreateMemento()
        {
            Console.WriteLine($"CreateMemento : {state}");
            return new Memento(state);
        }
        public void SetMemento(Memento memento)
        {
            Console.WriteLine($"SetMemento ...");
            State = memento.State;
        }
    }
    public class Memento
    {
        string state;
        public Memento(string state)
        {
            this.state = state;
        }
        public string State
        {
            get { return state; }
        }
    }
    public class Caretaker
    {
        Memento memento;
        public Memento Memento
        {
            get { return memento; }
            set
            {
                memento = value;
                Console.WriteLine("Care Taker Set Memento ...");
            }
        }
    }
}
