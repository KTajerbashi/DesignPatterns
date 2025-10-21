using DesignPatterns.Creational.PatternAbstractFactory.Interfaces;

namespace DesignPatterns.Creational.PatternAbstractFactory.Light;

public class LightUIFactory : IUIFactory
{
    public IButton CreateButton() => new LightButton();
    public ICheckbox CreateCheckbox() => new LightCheckbox();
}