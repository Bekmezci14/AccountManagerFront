using System;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;

namespace AccountManager.Frontend.Models;

public class AccountSummary
{
    public int Id { get; set; }

    public required string UserName { get; set; }
    public required string Password { get; set; }

    public string? Email { get; set; }
    public string? Ipadress { get; set; }
    public required string Category { get; set; } 

}
