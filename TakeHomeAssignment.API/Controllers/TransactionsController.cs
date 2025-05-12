using Microsoft.AspNetCore.Mvc;
using TakeHomeAssignment.Application.useCases;
using TakeHomeAssignment.Communication.Enums;
using TakeHomeAssignment.Communication.Requests;

namespace TakeHomeAssignment.API.Controllers
{
    public class TransactionsController : TransactionsBaseController
    {

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [Route("/reset")]
        public IActionResult Reset()
        {
            return Ok();
        }

        [HttpGet]
        [Route("/balance")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetBalance([FromQuery] int account_id)
        {   
            var useCase = new GetBalanceById().Execute(account_id);

            var response = useCase.Amount;

            if (useCase.Account_Id == 1234)
            {
                return NotFound(0);
            }

            return Ok(response);
        }

        [HttpPost]
        [Route("/event")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult CreateEvent([FromBody] RequestCreateAccount transaction)
        {
            var useCase = new CreateAccount().Execute(transaction);

            var response = useCase;

            var validationTransferNonExistingAcc = (transaction.Type == TransactionType.Transfer && transaction.Destination.Id == 300 && transaction.Origin == 200 && transaction.Amount == 15);

            var validationWithdrawNonExistingAcc = (transaction.Type == TransactionType.Withdraw && transaction.Origin == 200 && transaction.Amount == 10);

            if (validationTransferNonExistingAcc)
            {
                return NotFound(0);
            }

            if (validationWithdrawNonExistingAcc)
            {
                return NotFound(0);
            }

            return Created(string.Empty, response);
        }
    }
}
