using System;
using AccountManager.Frontend.Models;

namespace AccountManager.Frontend.Clients;

public class CategoriesClient(HttpClient httpClient)
{
    private readonly List<Category> categories = [
        new() { Id = 1, Name = "Default" },
        new() { Id = 2, Name = "Work" },
        new() { Id = 3, Name = "Personal" }
    ];

    public async Task<Category[]> GetCategoriesAsync() => await httpClient.GetFromJsonAsync<Category[]>("categories") ?? [];

}
