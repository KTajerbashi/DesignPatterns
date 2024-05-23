using DesignPatterns.Extentions.Tools;

namespace DesignPatterns.Factory.Pattern
{
    public interface IProduct
    {
        void Execute();
    }
    public abstract class Product : IProduct
    {
        public abstract void Execute();
    }
    public class ConcreateProduct1 : Product
    {
        public override void Execute()
        {
            DesignConsole designConsole = DesignConsole.DesignInstance();
            designConsole.ForeColor(ConsoleColor.Green);
            Console.WriteLine("ConcreateProduct1.Execute()");
        }
    }
    public class ConcreateProduct2 : Product
    {
        public override void Execute()
        {
            DesignConsole designConsole = DesignConsole.DesignInstance();
            designConsole.ForeColor(ConsoleColor.Red);
            Console.WriteLine("ConcreateProduct2.Execute()");
        }
    }
    public class DefaultProduct : Product
    {
        public override void Execute()
        {
            DesignConsole designConsole = DesignConsole.DesignInstance();
            designConsole.ForeColor(ConsoleColor.Blue);
            Console.WriteLine("DefaultProduct.Execute()");
        }
    }

    public abstract class Creator
    {
        public abstract Product FactoryMethod(ProductMode mode);
    }
    public class ConcreteCreator : Creator
    {
        public override Product FactoryMethod(ProductMode mode)
        {
            DesignConsole designConsole = DesignConsole.DesignInstance();
            designConsole.ForeColor(ConsoleColor.Yellow);
            Console.WriteLine("ConcreteCreator.FactoryMethod()");
            if (mode == ProductMode.One)
                return new ConcreateProduct1();
            else if(mode == ProductMode.Two)
                return new ConcreateProduct2();
            else
                return new DefaultProduct();
        }
    }
    public enum ProductMode : byte
    {
        None = 0,
        One = 1,
        Two = 2,
    }

}
