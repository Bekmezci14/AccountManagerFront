using System;
using AccountManager.Frontend.Models;

namespace AccountManager.Frontend.Clients;

public class AccountsClient(HttpClient httpClient)
{

    public async Task<AccountSummary[]> GetAccountsAsync() => await httpClient.GetFromJsonAsync<AccountSummary[]>("accounts") ?? [];


    public async Task AddAccountAsync(AccountDetails accountDetails)
            => await httpClient.PostAsJsonAsync("accounts", accountDetails);


    public async Task<AccountDetails> GetAccountAsync(int id)
    => await httpClient.GetFromJsonAsync<AccountDetails>($"accounts/{id}") ?? throw new Exception("Account not found");


    public async Task UpdateAccountAsync(AccountDetails accountDetails)
            => await httpClient.PutAsJsonAsync($"accounts/{accountDetails.Id}", accountDetails);

    public async Task DeleteAccountAsync(int id)
    => await httpClient.DeleteAsync($"accounts/{id}");
}
