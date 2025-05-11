using Microsoft.AspNetCore.Mvc;

namespace TakeHomeAssignment.API.Controllers
{
    public class TransactionsController : TransactionsBaseController
    {
        [HttpPost]
        [Route("/reset")]
        public IActionResult Reset()
        {
            return Ok();
        }

        [HttpGet]
        [Route("/balance")]
        public IActionResult GetBalance([FromQuery] string account_id)
        {
            return Ok();
        }

        [HttpPost]
        [Route("/event")]
        public IActionResult CreateEvent()
        {
            return Created();
        }


    }
}