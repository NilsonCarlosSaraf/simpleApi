using TakeHomeAssignment.Communication.Enums;

namespace TakeHomeAssignment.Communication.Responses;
public class Destination
{
    public int Id { get; set; }
    public decimal Balance { get; set; }
}

public class ResponseCreateAccount
{
    public TransactionType Type { get; set; }
    public Destination Destination { get; set; }
    public int Origin { get; set; }
    public int Amount { get; set; }



}