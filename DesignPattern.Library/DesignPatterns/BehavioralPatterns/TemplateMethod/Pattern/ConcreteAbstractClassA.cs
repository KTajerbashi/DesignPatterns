namespace DesignPatterns.BehavioralPatterns.TemplateMethod.Pattern
{
    public class ConcreteAbstractClassA : AbstractClass
    {
        protected override void PrimitiveOperationA()
        {
            Console.WriteLine("ConcreteAbstractClassA.PrimitiveOperationA() Runing...");
        }

        protected override void PrimitiveOperationB()
        {
            Console.WriteLine("ConcreteAbstractClassA.PrimitiveOperationB() Runing...");
        }
    }

}
