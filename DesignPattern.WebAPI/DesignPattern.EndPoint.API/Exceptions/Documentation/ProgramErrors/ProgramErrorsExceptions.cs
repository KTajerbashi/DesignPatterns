using DesignPattern.EndPoint.API.Exceptions.Documentation.UsageErrors;
using DesignPatterns.Extensions;

namespace DesignPattern.EndPoint.API.Exceptions.Documentation.ProgramErrors;
/// <summary>
/// در صورتیکه منطق عملیات قابل اجرا نباشد
/// </summary>
public class ProgramErrorsExceptions
{
    private UsageErrorsService usageErrorsService;
    public ProgramErrorsExceptions()
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
