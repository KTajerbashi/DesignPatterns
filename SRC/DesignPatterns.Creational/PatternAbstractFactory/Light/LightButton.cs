using DesignPatterns.Creational.PatternAbstractFactory.Interfaces;

namespace DesignPatterns.Creational.PatternAbstractFactory.Light;

public class LightButton : IButton
{
    public string Render() => "<button class='btn btn-light'>🌞 Light Button</button>";
}
