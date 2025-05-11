using TakeHomeAssignment.Communication.Enums;

namespace TakeHomeAssignment.Communication.Responses;

public class ResponseRegisteredBalance
{
    public int Account_Id { get; set; }
    public TransactionType Type { get; set; }
    public int Origin { get; set; }
    public string? Destination { get; set; } = string.Empty;
    public int Amount { get; set; }
}
