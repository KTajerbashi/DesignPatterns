﻿using DesignPatterns.Extensions.Exceptions.Models;

namespace DesignPatterns.Extensions.Exceptions.Documentation.UsageErrors;

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

