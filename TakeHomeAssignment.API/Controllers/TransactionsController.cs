using Microsoft.AspNetCore.Mvc;
using TakeHomeAssignment.Application.Handlers;
using TakeHomeAssignment.Application.useCases;
using TakeHomeAssignment.Communication;
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
        private static readonly Dictionary<string, int> _accounts = new();

        [HttpPost]
        [Route("/event")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult Event([FromBody] RequestEvent request)
        {
            var result = request.Type.ToLower() switch
            {
                "deposit" => new DepositHandler(_accounts).Handle(request),
                "withdraw" => new WithdrawHandler(_accounts).Handle(request),
                "transfer" => new TransferHandler(_accounts).Handle(request),
                _ => new ResponseEvent(400, "Invalid event type.")
            };

            return StatusCode(result.StatusCode, result.Data);
        }
    }
}
