using DesignPatterns.CreationalPatterns.AbstractFactory.Pattern.Services;

namespace DesignPatterns.CreationalPatterns.AbstractFactory.Pattern.Concrete
{
    public class ConcreteFactory1 : AbstractFactory
    {
        public override AbstractProductA CreateProductA()
        {
            return new ProductA1();
        }

        public override AbstractProductB CreateProductB()
        {
            return new ProductB1();
        }
    }
}
