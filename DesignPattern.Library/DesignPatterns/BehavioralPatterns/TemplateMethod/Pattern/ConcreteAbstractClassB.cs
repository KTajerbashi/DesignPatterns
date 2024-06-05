namespace DesignPatterns.BehavioralPatterns.TemplateMethod.Pattern
{
    public class ConcreteAbstractClassB : AbstractClass
    {
        protected override void PrimitiveOperationA()
        {
            Console.WriteLine("ConcreteAbstractClassB.PrimitiveOperationA() Runing...");
        }

        protected override void PrimitiveOperationB()
        {
            Console.WriteLine("ConcreteAbstractClassB.PrimitiveOperationB() Runing...");
        }
    }

}
