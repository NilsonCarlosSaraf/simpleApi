using TakeHomeAssignment.Communication.Responses;

namespace TakeHomeAssignment.Application.useCases;

public class GetBalanceById
{
    public ResponseRegisteredBalance Execute(int account_id)
    {
        var balance = new ResponseRegisteredBalance
        {
            Account_Id = account_id,
            Type = Communication.Enums.TransactionType.Deposit,
            Origin = 100,
            Destination = "DestinationAccount",
            Amount = 100
        };
        return balance;
    }
}
