// See https://aka.ms/new-console-template for more information
using DesignPatterns;
using DesignPatterns.Extensions.Tools;
using Microsoft.Extensions.Logging;
DesignConsole console = DesignConsole.DesignInstance();
console.Start("Application");
console.ForeColor();
Dictionary<string,List<string>> DataList =new Dictionary<string, List<string>>();
DataList.Add("Creational Patterns", new List<string>
{
    "Singleton",
    "Factory",
    "Abstract Factory",
    "Builder",
    "Prototype"
});
DataList.Add("Structural Patterns", new List<string>
{
    "Adapter",
    "Bridge",
    "Composite",
    "Decorator",
    "Facade",
    "Flyweight",
    "Proxy"
});
DataList.Add("Behavioral Patterns", new List<string>
{
    "Chain of Responsibility",
    "Command",
    "Interpreter",
    "Iterator",
    "Mediator",
    "Memento",
    "Observer",
    "State",
    "Strategy",
    "Template Method",
    "Visitor",
});
DataList.Add("Exception", new List<string>
{
    "Program Errors",
    "System Failures",
    "Usage Errors",
});

console.Title("Welcome To Application");
int count = 1;
foreach (var item in DataList)
{
    console.ForeColor();
    console.Section($"{item.Key}");
    foreach (var name in item.Value)
    {
        Console.WriteLine($"Press {count} For => {name} Services");
        count++;
    }
}
console.ForeColor();
console.Title("Select Choices");
Console.WriteLine("Which Number You Want to Run ?");
var key = Console.ReadLine();
using var loggerFactory = LoggerFactory.Create(builder =>
{
    builder
    .AddFilter("Microsoft", LogLevel.Trace)
    .AddFilter("System", LogLevel.Trace)
    .AddFilter("LoggingConsoleApp.Program", LogLevel.Trace)
    .AddConsole()
    ;
});
ILogger logger = loggerFactory.CreateLogger<Program>();
MainApplication application = new(logger);
while (key != "EXIT" || key == "CLOSE")
{
    application.Execute(key);
    key = Console.ReadLine();
}
console.Section("Press Any Key ...");
Console.ReadLine();
console.End("Application");

