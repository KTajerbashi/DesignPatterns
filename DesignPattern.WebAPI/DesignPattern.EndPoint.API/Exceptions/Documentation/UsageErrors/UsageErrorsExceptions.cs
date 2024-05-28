using DesignPatterns.Extensions;

namespace DesignPattern.EndPoint.API.Exceptions.Documentation.UsageErrors;

/// <summary>
/// هرگاه بخواهیم با شی خالی کاری انجام بدیم این خطا دریافت میکنیم
/// </summary>
public class UsageErrorsExceptions
{
    private UsageErrorsService usageErrorsService;
    public UsageErrorsExceptions()
    {
        usageErrorsService = new();
    }
    public void Execute(int id)
    {
        DesignConsole console = DesignConsole.DesignInstance();
        console.ForeColor();
        var result = usageErrorsService.Find(id);
        Console.WriteLine($@"
Id : {result.Id}
Name : {result.Name}
Family : {result.Family}");
    }
}
