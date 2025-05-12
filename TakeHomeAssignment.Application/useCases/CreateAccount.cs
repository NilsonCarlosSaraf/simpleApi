using TakeHomeAssignment.Communication.Requests;
using TakeHomeAssignment.Communication.Responses;
using Destination = TakeHomeAssignment.Communication.Responses.Destination;

namespace TakeHomeAssignment.Application.useCases;

public class CreateAccount
{
    public ResponseCreateAccount Execute(RequestCreateAccount transaction)
    {
        var response = new ResponseCreateAccount
        {
            Type = transaction.Type,
            Destination = transaction.Destination != null ? new Destination
            {
                Id = transaction.Destination.Id ?? 0,
                Balance = transaction.Destination.Balance,
            } : null,
            Amount = transaction.Amount,
            Origin = transaction.Origin,
        };  
        return response;
    }
}
