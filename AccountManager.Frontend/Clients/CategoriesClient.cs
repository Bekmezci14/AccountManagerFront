using System;
using AccountManager.Frontend.Models;

namespace AccountManager.Frontend.Clients;

public class CategoriesClient
{
    private readonly List<Categories> categories = [
        new() { Id = 1, Name = "Default" },
        new() { Id = 2, Name = "Gaming" },
        new() { Id = 3, Name = "Work" }
    ];

    public Categories[] GetCategories() => [.. categories];

}
