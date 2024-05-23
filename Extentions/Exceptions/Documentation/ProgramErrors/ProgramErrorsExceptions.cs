using DesignPatterns.Extentions.Exceptions.Documentation.Models;
using DesignPatterns.Extentions.Exceptions.Documentation.UsageErrors;
using DesignPatterns.Extentions.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Extentions.Exceptions.Documentation.ProgramErrors;
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
public class ProgramErrorsService
{
    private readonly List<UserModel> DataList;
    public ProgramErrorsService()
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
