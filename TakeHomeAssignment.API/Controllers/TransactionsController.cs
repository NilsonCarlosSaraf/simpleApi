using Microsoft.AspNetCore.Mvc;

namespace TakeHomeAssignment.API.Controllers;
public class TransactionsController : TransactionsBaseController
{
    [HttpGet]
    [Route("/balance{account_id}")]
    public IActionResult GetTransactions()
    {
        return Ok(new { Message = "List of transactions" });
    }

    [HttpPost]
    [Route("/event}")]
    public IActionResult CreateTransaction([FromBody] object transaction)
    {
        return CreatedAtAction(nameof(GetTransactions), new { Message = "Transaction created" });
    }
}
