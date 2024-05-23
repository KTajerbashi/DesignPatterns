using DesignPatterns.Extensions.Exceptions.Documentation.UsageErrors;
using DesignPatterns.Extensions.Tools;

namespace DesignPatterns.Extensions.Exceptions.Documentation.SystemFailures;


/// <summary>
/// منابع سیستم پر شود این خطا دریافت میشود
/// </summary>
public class SystemFailuresExceptions
{
    private UsageErrorsService usageErrorsService;
    public SystemFailuresExceptions()
    {
        usageErrorsService = new UsageErrorsService();
    }
    public void Execute(string id)
    {
        DesignConsole console = DesignConsole.DesignInstance();
        console.ForeColor();
        var result = usageErrorsService.Find(int.Parse(id));
        Console.WriteLine($@"
Id : {result.Id}
Name : {result.Name}
Family : {result.Family}");
    }
}
