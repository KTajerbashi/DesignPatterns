using Design.Pattern.Library.Tools;
using DesignPatterns.Decorator.Pattern;

namespace DesignPatterns.Decorator
{
    public class Container
    {
        public Container(DesignConsole design)
        {
            design.NewLine();
            ConcreteComponent component = new();
            component.Operation();
            design.NewLine();
            ConcreteDecorator concreteLogging = new (component);
            concreteLogging.Operation();
            design.NewLine();
            ConcreteDecoratorGetData decoratorGetData = new (component);
            decoratorGetData.Operation();
            design.NewLine();
        }
    }
}
