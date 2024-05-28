using DesignPatterns.AbstractFactory.Pattern.Services;

namespace DesignPatterns.AbstractFactory.Pattern
{
    public interface IAbstractFactory
    {
        AbstractProductA CreateProductA();
        AbstractProductB CreateProductB();
    }
    public abstract class AbstractFactory : IAbstractFactory
    {
        public abstract AbstractProductA CreateProductA();

        public abstract AbstractProductB CreateProductB();
    }
}
