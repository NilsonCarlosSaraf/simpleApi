using TakeHomeAssignment.Communication.Enums;

namespace TakeHomeAssignment.Communication.Requests;

public class Destination
{
    public string Id { get; set; } = string.Empty;
    public decimal Balance { get; set; }
}

public class RequestCreateAccount
{
    public TransactionType Type { get; set; }

    public Destination Destination { get; set; }
    public int Amount { get; set; }



}
