namespace DesignPatterns.Structural.Facade;

public class Engine
{
    public string Start() => "Engine started.";
    public string Stop() => "Engine stopped.";
}

public class FuelPump
{
    public string PumpFuel() => "Fuel pumped to engine.";
    public string StopPump() => "Fuel pump stopped.";
}
public class CoolingSystem
{
    public string TurnOn() => "Cooling system activated.";
    public string TurnOff() => "Cooling system turned off.";
}

// The Facade that simplifies interaction with subsystems
public class CarFacade
{
    private readonly Engine _engine;
    private readonly FuelPump _fuelPump;
    private readonly CoolingSystem _coolingSystem;

    public CarFacade()
    {
        _engine = new Engine();
        _fuelPump = new FuelPump();
        _coolingSystem = new CoolingSystem();
    }

    public List<string> StartCar()
    {
        return new List<string>
            {
                _fuelPump.PumpFuel(),
                _coolingSystem.TurnOn(),
                _engine.Start(),
                "🚗 Car is ready to go!"
            };
    }

    public List<string> StopCar()
    {
        return new List<string>
            {
                _engine.Stop(),
                _coolingSystem.TurnOff(),
                _fuelPump.StopPump(),
                "🛑 Car stopped."
            };
    }
}

