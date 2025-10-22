namespace DesignPatterns.Structural.Proxy;

// Subject interface
public interface IImage
{
    string Display();
}

// The Real Subject
public class RealImage : IImage
{
    private readonly string _fileName;

    public RealImage(string fileName)
    {
        _fileName = fileName;
        LoadFromDisk(); // Simulate expensive operation
    }

    private void LoadFromDisk()
    {
        Thread.Sleep(1000); // Simulate delay
        Console.WriteLine($"Loading image {_fileName} from disk...");
    }

    public string Display()
    {
        return $"🖼️ Displaying image: {_fileName}";
    }
}

// The Proxy class
public class ProxyImage : IImage
{
    private readonly string _fileName;
    private RealImage? _realImage;

    public ProxyImage(string fileName)
    {
        _fileName = fileName;
    }

    public string Display()
    {
        // Lazy loading: only load when needed
        if (_realImage == null)
        {
            _realImage = new RealImage(_fileName);
        }

        return _realImage.Display();
    }
}

