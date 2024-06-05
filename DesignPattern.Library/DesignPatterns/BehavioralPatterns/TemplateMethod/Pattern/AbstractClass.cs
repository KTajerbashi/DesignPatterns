namespace DesignPatterns.BehavioralPatterns.TemplateMethod.Pattern
{
    public abstract class AbstractClass
    {
        public void TemplateMethod()
        {
            Console.WriteLine($"AbstractClass.TemplateMethod() Started ...");
            PrimitiveOperationA();
            PrimitiveOperationB();
            Console.WriteLine($"AbstractClass.TemplateMethod() Finished ...");
        }

        protected abstract void PrimitiveOperationA();
        protected abstract void PrimitiveOperationB();
    }

}
