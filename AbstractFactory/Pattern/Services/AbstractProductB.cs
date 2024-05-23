
using DesignPatterns.Extensions.Tools;

namespace DesignPatterns.AbstractFactory.Pattern.Services
{
    public interface IAbstractProductB
    {
        void Execute();
    }
    public abstract class AbstractProductB
    {
        public abstract void Execute();
    }
    public class ProductB1 : AbstractProductB
    {
        public override void Execute()
        {
            DesignConsole design = DesignConsole.DesignInstance();
            design.ForeColor(ConsoleColor.Red);
            Console.WriteLine("ProductB1.Execute()");
        }
    }
    public class ProductB2 : AbstractProductB
    {
        public override void Execute()
        {
            DesignConsole design = DesignConsole.DesignInstance();
            design.ForeColor(ConsoleColor.Yellow);
            Console.WriteLine("ProductB2.Execute()");
        }
    }
}
