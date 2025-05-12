using TakeHomeAssignment.Communication.Enums;

namespace TakeHomeAssignment.Communication.Requests;

public class Destination
{
    public int? Id { get; set; }
    public decimal Balance { get; set; }
}

public class RequestCreateAccount
{
    public TransactionType Type { get; set; }

    public Destination Destination { get; set; }
    public int Amount { get; set; }
    public int Origin { get; set; }
}
