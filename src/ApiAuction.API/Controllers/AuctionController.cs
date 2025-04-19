using Microsoft.AspNetCore.Mvc;

namespace ApiAuction.API.Controllers;
[Route("[controller]")]
[ApiController]
public class AuctionController : ControllerBase
{
    [HttpGet]
    public IActionResult GetCurrentAuction()
    {
        return Ok("Hello World");
    }
}