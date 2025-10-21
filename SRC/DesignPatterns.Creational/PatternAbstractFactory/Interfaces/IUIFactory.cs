namespace DesignPatterns.Creational.PatternAbstractFactory.Interfaces;

public interface IUIFactory
{
    IButton CreateButton();
    ICheckbox CreateCheckbox();
}
