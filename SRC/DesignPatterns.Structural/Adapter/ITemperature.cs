namespace DesignPatterns.Structural.Adapter;

public interface ITemperature
{
    double GetTemperatureFahrenheit();
}
// Legacy class providing temperature in Celsius
public class CelsiusService
{
    private readonly double _tempCelsius;
    public CelsiusService(double tempCelsius)
    {
        _tempCelsius = tempCelsius;
    }

    public double GetTemperatureCelsius() => _tempCelsius;
}

// The Adapter converts Celsius to Fahrenheit
public class TemperatureAdapter : ITemperature
{
    private readonly CelsiusService _celsiusService;

    public TemperatureAdapter(CelsiusService celsiusService)
    {
        _celsiusService = celsiusService;
    }

    public double GetTemperatureFahrenheit()
    {
        var celsius = _celsiusService.GetTemperatureCelsius();
        return (celsius * 9 / 5) + 32;
    }
}
