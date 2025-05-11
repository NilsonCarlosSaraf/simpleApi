using Microsoft.AspNetCore.Mvc;
using TakeHomeAssignment.Application.useCases;
using TakeHomeAssignment.Communication.Requests;

namespace TakeHomeAssignment.API.Controllers
{
    public class TransactionsController : TransactionsBaseController
    {

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Route("/reset")]
        public IActionResult Reset()
        {
            return Ok("System reseted");
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
                return NotFound("Account not found");
            }

            return Ok(response);
        }

        [HttpPost]
        [Route("/event")]
        public IActionResult CreateEvent([FromBody] RequestTransaction transaction)
        {
            return Ok();
        }
    }
}
