using DesignPatterns.Creational.PatternAbstractFactory.Interfaces;

namespace DesignPatterns.Creational.PatternAbstractFactory.Dark;

public class DarkButton : IButton
{
    public string Render() => "<button class='btn btn-dark'>🌚 Dark Button</button>";
}
