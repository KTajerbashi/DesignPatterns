namespace DesignPatterns.Creational.PatternSingleton;

public sealed class Singleton
{
    private static readonly Lazy<Singleton> instance = new(() => new Singleton());
    public static Singleton Instance => instance.Value;
    public Guid InstanceId { get; } = Guid.NewGuid();
    private Singleton() { }

    public string GetMessage()
    {
        return $"Singleton Instance ID: {InstanceId}";
    }
}
