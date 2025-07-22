namespace AccountManager.Frontend.Models;

public class AccountDetails
{
    public int Id { get; set; }

    public required string UserName { get; set; }
    public required string Password { get; set; }

    public string? Email { get; set; }
    public string? Ipadress { get; set; }
    public string? CategoryId { get; set; } 

}