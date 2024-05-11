using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton.Pattern
{
    public class Singleton
    {
        //private static Singleton Instance;

        private static readonly Lazy<Singleton> Instance = new Lazy<Singleton>(() => new Singleton());
        private static int Counter = 0;
        private Singleton()
        { 
            Console.WriteLine("Singleton Created");
        }
        public static Singleton GetInstance()
        {
            //if (Instance is null)
            //{
            //    Instance = new Singleton();
            //}
            Counter++;
            Console.WriteLine($"Singleton GetInstance Count {Counter}");
            return Instance.Value;
        }
    }
}
