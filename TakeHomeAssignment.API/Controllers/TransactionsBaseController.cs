using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TakeHomeAssignment.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class TransactionsBaseController : ControllerBase
{
    public string Author { get; set; } = "Nilson Saraf";
}
