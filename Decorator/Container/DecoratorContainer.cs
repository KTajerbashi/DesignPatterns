using DesignPatterns.Decorator.Pattern;
using DesignPatterns.Extensions.Tools;

namespace DesignPatterns.Decorator.Container
{
    public class DecoratorContainer
    {
        DesignConsole design;
        public DecoratorContainer()
        {
            design = DesignConsole.DesignInstance();
            design.NewLine();
            ConcreteComponent component = new();
            component.Operation();
            design.NewLine();
            ConcreteDecorator concreteLogging = new(component);
            concreteLogging.Operation();
            design.NewLine();
            ConcreteDecoratorGetData decoratorGetData = new(component);
            decoratorGetData.Operation();
            design.NewLine();
        }

        internal void Execute()
        {
            throw new NotImplementedException();
        }
    }
}
