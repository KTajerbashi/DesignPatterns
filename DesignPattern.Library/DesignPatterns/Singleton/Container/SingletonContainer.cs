
using DesignPatterns.Extensions;

namespace DesignPatterns.Singleton.Container
{
    public class SingletonContainer
    {
        DesignConsole Console = DesignConsole.DesignInstance();
        public void Execute()
        {
            Console.WriteLine("SingletonContainer.Execute()");
        }

        public void Pattern()
        {

        }

       
    }
}
