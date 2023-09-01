using System.ComponentModel.DataAnnotations;
namespace PartyInvites.Models;

public class GuestResponse
{   [Required(ErrorMessage="Please enter your name")]
    public string? Name { get; set; }
    [Required(ErrorMessage="Please enter your email")]
    [EmailAddress]
    public string? Email { get; set; }
    [Required(ErrorMessage="Please enter your phone number")]
    [Phone]
    public string? Phone { get; set; }
    [Required(ErrorMessage="Please specify if you're attending or not")]
    public bool? WillAttend { get; set; }

    public override string ToString()
    {
        return $"Name: {Name}, Email: {Email}, Phone: {Phone}, WillAttend: {WillAttend}";
    }
}

