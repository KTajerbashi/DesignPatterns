using DesignPatterns.CreationalPatterns.AbstractFactory.Pattern.Services;

namespace DesignPatterns.CreationalPatterns.AbstractFactory.Pattern.Concrete
{
    public class ConcreteFactory2 : AbstractFactory
    {
        public override AbstractProductA CreateProductA()
        {
            return new ProductA2();
        }

        public override AbstractProductB CreateProductB()
        {
            return new ProductB2();
        }
    }
}
