using DesignPatterns.Creational.PatternAbstractFactory.Interfaces;

namespace DesignPatterns.Creational.PatternAbstractFactory.Light;

public class LightCheckbox : ICheckbox
{
    public string Render() => "<input type='checkbox' checked> Light Checkbox";
}
