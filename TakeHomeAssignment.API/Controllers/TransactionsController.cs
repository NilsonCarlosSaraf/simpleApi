using Microsoft.AspNetCore.Mvc;
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
            return Ok();
        }

        [HttpGet]
        [Route("/balance")]
        public IActionResult GetBalance([FromQuery] string account_id)
        {

            return NotFound(0);
        }

        [HttpPost]
        [Route("/event")]
        public IActionResult CreateEvent([FromBody] RequestTransaction transaction)
        {
            return Ok();
        }
    }
}
