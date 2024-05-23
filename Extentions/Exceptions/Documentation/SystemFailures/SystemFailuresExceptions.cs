using DesignPatterns.Extentions.Exceptions.Documentation.Models;
using DesignPatterns.Extentions.Exceptions.Documentation.UsageErrors;
using DesignPatterns.Extentions.Tools;

namespace DesignPatterns.Extentions.Exceptions.Documentation.SystemFailures;


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
public class SystemFailuresService
{
    private readonly List<UserModel> DataList;
    public SystemFailuresService()
    {
        DataList = new List<UserModel>();
        DataList.Add(new UserModel
        {
            Id = 1,
            Name = "Kamran",
            Family = "Tajerbashi"
        });
        DataList.Add(new UserModel
        {
            Id = 2,
            Name = "Mohammad",
            Family = "Karimi"
        });
    }
    public UserModel Find(int id)
    {
        var result = DataList.Find(item => item.Id == id);
        return result;
    }
}
