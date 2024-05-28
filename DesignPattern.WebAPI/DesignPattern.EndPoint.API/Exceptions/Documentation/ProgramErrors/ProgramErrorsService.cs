using DesignPattern.EndPoint.API.Exceptions.Models;

namespace DesignPattern.EndPoint.API.Exceptions.Documentation.ProgramErrors;

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
