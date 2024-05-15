namespace DesignPatterns.TemplateMethod.Example
{
    public abstract class AbstractClass
    {
        public void TemplateMethod()
        {
            this.BaseOperation1();
            this.RequiredOperation1();
            this.Hook1();
            this.RequiredOperation2();
            this.BaseOperation2();
            this.Hook2();
        }
        protected void BaseOperation1()
        {
            Console.WriteLine("AbstractClass.BaseOperation1() Run ...");
        }
        protected void BaseOperation2()
        {
            Console.WriteLine("AbstractClass.BaseOperation2() Run ...");
        }
        /// <summary>
        /// این متد باید توسط زیر کلاس توسعه داده شود
        /// </summary>
        protected abstract void RequiredOperation1();
        protected abstract void RequiredOperation2();

        void DefaultHook()
        {
            Console.WriteLine("DefaultHook");
        }

        protected virtual void Hook1()
        {
            this.DefaultHook();
        }
        protected virtual void Hook2()
        {
            this.DefaultHook();
        }

    }


    public class ConcreteClassA : AbstractClass
    {
        protected override void RequiredOperation1()
        {
            Console.WriteLine($"ConcreteClassA.RequiredOperation1() Run ...");
        }

        protected override void RequiredOperation2()
        {
            Console.WriteLine($"ConcreteClassA.RequiredOperation2() Run ...");
        }
        protected override void Hook1()
        {
            Console.WriteLine($"ConcreteClassA.Hook1() Run ...");
        }
        protected override void Hook2()
        {
            base.Hook2();
            Console.WriteLine($"ConcreteClassA.Hook2() Run ...");
        }
    }

    public class Client
    {
        public static void RunTemplateMethod(AbstractClass abstractClass) 
        {
            abstractClass.TemplateMethod();
        }
    }

}
