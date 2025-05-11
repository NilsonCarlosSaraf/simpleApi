 namespace TakeHomeAssignment.Communication.Requests;

public class RequestTransaction
{   public string Type { get; set; }
    public string? Origin { get; set; }
    public string? Destination { get; set; }
    public int Amount { get; set; }
}
