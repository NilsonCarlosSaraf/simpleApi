namespace TakeHomeAssignment.Communication.Requests;

public class RequestEvent
{
    public string Type { get; set; } = null!;
    public string? Origin { get; set; }
    public string? Destination { get; set; }
    public int Amount { get; set; }
}
