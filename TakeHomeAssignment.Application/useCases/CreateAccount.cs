using TakeHomeAssignment.Communication.Responses;

namespace TakeHomeAssignment.Application.useCases;

public class CreateAccount
{
    public ResponseCreateAccount Execute()
    {
        var response = new ResponseCreateAccount
        {
            Type = Communication.Enums.TransactionType.Withdraw,
            Destination = new Destination
            {
                Id = 100,
                Balance = 20
            },
            Amount = 10,
            Origin = 200
        };  
        return response;
    }
}
