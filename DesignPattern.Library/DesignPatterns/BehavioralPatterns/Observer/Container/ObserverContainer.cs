using DesignPatterns.BehavioralPatterns.Observer.Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehavioralPatterns.Observer.Container
{
    public class ObserverContainer
    {
        public void Pattern()
        {
            ConcreteSubject concreteSubject = new ConcreteSubject();
            concreteSubject.Attach(new ConcreteObserver("Observer 1",concreteSubject));
            concreteSubject.Attach(new ConcreteObserver("Observer 2",concreteSubject));
            concreteSubject.Attach(new ConcreteObserver("Observer 3",concreteSubject));
            concreteSubject.Attach(new ConcreteObserver("Observer 4", concreteSubject));
            var observer5 = new ConcreteObserver("Observer 5", concreteSubject);
            concreteSubject.Attach(observer5);
            ////
            /// اعمال تغییرات
            /// 
            concreteSubject.SubjecState = "Observer Changes";
            concreteSubject.Notify();
            concreteSubject.Detach(observer5);
            Console.WriteLine("=========================");
            concreteSubject.SubjecState = "Call Againg";
            concreteSubject.Notify();
        }
        internal void Execute()
        {
            throw new NotImplementedException();
        }
    }
}
