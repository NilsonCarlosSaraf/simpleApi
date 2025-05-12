using TakeHomeAssignment.Communication.Requests;
using TakeHomeAssignment.Communication.Responses;
using Destination = TakeHomeAssignment.Communication.Responses.Destination;

namespace TakeHomeAssignment.Application.useCases;

public class DepositToAccount
{
    public ResponseCreateAccount Execute(RequestCreateAccount transaction)
    {
        var response = new ResponseCreateAccount
        {
            Destination = transaction.Destination != null ? new Destination
            {
                Id = transaction.Destination.Id ?? 0,
                Balance = transaction.Amount,
            } : null,
        };  
        return response;
    }
}
