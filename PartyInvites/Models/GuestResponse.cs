
namespace PartyInvites.Models;

public class GuestResponse
{
    public string? Name { get; set; }
    public string? Email { get; set; }
    public string? Phone { get; set; }
    public bool? WillAttend { get; set; }

    public override string ToString()
    {
        return $"Name: {Name}, Email: {Email}, Phone: {Phone}, WillAttend: {WillAttend}";
    }
}

