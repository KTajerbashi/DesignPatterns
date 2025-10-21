namespace DesignPatterns.Structural.Adapter;

public interface ITemperature
{
    double GetTemperatureFahrenheit();
}
public class CelsiusService
{
    public double GetTemperatureCelsius() => 25.0; // example temperature
}

public class TemperatureAdapter : ITemperature
{
    private readonly CelsiusService _celsiusService;

    public TemperatureAdapter(CelsiusService service)
    {
        _celsiusService = service;
    }

    public double GetTemperatureFahrenheit()
    {
        return _celsiusService.GetTemperatureCelsius() * 9 / 5 + 32;
    }
}


