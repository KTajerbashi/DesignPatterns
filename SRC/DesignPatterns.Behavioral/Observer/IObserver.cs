namespace DesignPatterns.Behavioral.Observer;

public interface IObserver
{
    void Update(float temperature);
}
public interface ISubject
{
    void Attach(IObserver observer);
    void Detach(IObserver observer);
    void Notify();
}
public class WeatherStation : ISubject
{
    private readonly List<IObserver> _observers = new();
    private float _temperature;

    public float Temperature
    {
        get => _temperature;
        set
        {
            _temperature = value;
            Notify();
        }
    }

    public void Attach(IObserver observer)
    {
        _observers.Add(observer);
    }

    public void Detach(IObserver observer)
    {
        _observers.Remove(observer);
    }

    public void Notify()
    {
        foreach (var observer in _observers)
        {
            observer.Update(_temperature);
        }
    }
}

public class DisplayDevice : IObserver
{
    public string Name { get; }
    public float CurrentTemperature { get; private set; }

    public DisplayDevice(string name)
    {
        Name = name;
    }

    public void Update(float temperature)
    {
        CurrentTemperature = temperature;
    }
}