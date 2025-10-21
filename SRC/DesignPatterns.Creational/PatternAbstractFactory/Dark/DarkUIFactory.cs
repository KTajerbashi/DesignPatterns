using DesignPatterns.Creational.PatternAbstractFactory.Interfaces;

namespace DesignPatterns.Creational.PatternAbstractFactory.Dark;

public class DarkUIFactory : IUIFactory
{
    public IButton CreateButton() => new DarkButton();
    public ICheckbox CreateCheckbox() => new DarkCheckbox();
}