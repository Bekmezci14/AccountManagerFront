using System;
using AccountManager.Frontend.Models;

namespace AccountManager.Frontend.Clients;

public class AccountsClient
{
    private readonly List<AccountSummary> accounts = [
            new()
        {
            Id = 1,
            UserName = "user1",
            Password = "password1",
            Email = "user1@example.com",
            Ipadress = "111.111.111",
            Category = "Default"
        },
        new()
        {
            Id = 2,
            UserName = "user2",
            Password = "password2",
            Email = "user2@example.com",
            Ipadress = "222.111.111",
            Category = "Default"
        }
        ];

    public AccountSummary[] GetAccounts() => [.. accounts];

    private readonly Category[] categories = new CategoriesClient().GetCategories();

    public void AddAccount(AccountDetails accountDetails)
    {
        Category category = GetCategoryById(accountDetails.CategoryId);

        var newAccount = new AccountSummary
        {
            Id = accounts.Count + 1,
            UserName = accountDetails.UserName,
            Password = accountDetails.Password,
            Email = accountDetails.Email,
            Ipadress = accountDetails.Ipadress,
            Category = category.Name
        };
        accounts.Add(newAccount);
    }

    private Category GetCategoryById(string? id)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(id);
        return categories.Single(category => category.Id == int.Parse(id));
    }

    public AccountDetails GetAccount(int id)
    {
        AccountSummary account = GetAccountSummaryById(id);

        var category = categories.Single(c => string.Equals(c.Name, account.Category, StringComparison.OrdinalIgnoreCase));

        return new AccountDetails
        {
            Id = account.Id,
            UserName = account.UserName,
            Password = account.Password,
            Email = account.Email,
            Ipadress = account.Ipadress,
            CategoryId = category.Id.ToString()
        };
    }

    private AccountSummary GetAccountSummaryById(int id)
    {
        var account = accounts.Find(a => a.Id == id);
        ArgumentNullException.ThrowIfNull(account);
        return account;
    }

}
