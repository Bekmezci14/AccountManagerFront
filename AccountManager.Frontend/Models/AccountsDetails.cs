using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AccountManager.Frontend.Converters;

namespace AccountManager.Frontend.Models;

public class AccountDetails
{
    public int Id { get; set; }

    [Required]
    public required string UserName { get; set; }

    [Required]
    public required string Password { get; set; }

    public string? Email { get; set; }
    public string? Ipadress { get; set; }
    [Required(ErrorMessage = "Category is required.")]
    [JsonConverter(typeof(StringConverter))]
    public string? CategoryId { get; set; } 

}