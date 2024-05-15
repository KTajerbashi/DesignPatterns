using DesignPatterns.TemplateMethod.Pattern;
using DesignPatterns.Tools;

namespace DesignPatterns.TemplateMethod.Container
{
    public class TemplateMethodContainer
    {
        DesignConsole Console;
        public TemplateMethodContainer()
        {
            Console = DesignConsole.DesignInstance();
        }
        public void Pattern()
        {
            Console.ForeColor();
            Client.Run(new ConcreteAbstractClassA());
            Console.ForeColor();
            Client.Run(new ConcreteAbstractClassB());
        }
    }
}
