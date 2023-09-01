using PartyInvites.Models;

public static class Repository
{
    private static List<GuestResponse> _responses = new List<GuestResponse>();
    public static IEnumerable<GuestResponse> Responses => _responses;
    public static void AddResponse(GuestResponse response)
    {
        _responses.Add(response);
        Console.WriteLine($"Added a new response!\n{response}");
    }
}