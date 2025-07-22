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

        public AccountSummary[] GetGames() => [.. accounts];
    
}
