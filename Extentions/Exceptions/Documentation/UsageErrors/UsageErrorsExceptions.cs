using DesignPatterns.Extentions.Exceptions.Documentation.Models;
using DesignPatterns.Extentions.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Extentions.Exceptions.Documentation.UsageErrors;

/// <summary>
/// هرگاه بخواهیم با شی خالی کاری انجام بدیم این خطا دریافت میکنیم
/// </summary>
public class UsageErrorsExceptions
{
    private UsageErrorsService usageErrorsService;
    public UsageErrorsExceptions()
    {
        usageErrorsService = new UsageErrorsService();
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
public class UsageErrorsService
{
    private readonly List<UserModel> DataList;
    public UsageErrorsService()
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

