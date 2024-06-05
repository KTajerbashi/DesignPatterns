using DesignPatterns.Extensions;

namespace DesignPatterns.CreationalPatterns.AbstractFactory.Pattern.Services
{
    public interface IAbstractProductA
    {
        void Execute();
    }
    public abstract class AbstractProductA : IAbstractProductA
    {
        public abstract void Execute();
    }
    public class ProductA1 : AbstractProductA
    {
        public override void Execute()
        {
            DesignConsole design = DesignConsole.DesignInstance();
            design.ForeColor(ConsoleColor.Gray);
            Console.WriteLine("ProductA1.Execute()");
        }
    }
    public class ProductA2 : AbstractProductA
    {
        public override void Execute()
        {
            DesignConsole design = DesignConsole.DesignInstance();
            design.ForeColor(ConsoleColor.Blue);
            Console.WriteLine("ProductA2.Execute()");
        }
    }
}
