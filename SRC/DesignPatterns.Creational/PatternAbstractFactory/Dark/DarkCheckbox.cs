using DesignPatterns.Creational.PatternAbstractFactory.Interfaces;

namespace DesignPatterns.Creational.PatternAbstractFactory.Dark;

public class DarkCheckbox : ICheckbox
{
    public string Render() => "<input type='checkbox'> Dark Checkbox";
}
