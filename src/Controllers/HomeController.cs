using Microsoft.AspNetCore.Mvc;

namespace petfriend_api.Controllers;
[ApiController]
[Route("[controller]")]
public class HomeController : ControllerBase
{
    [HttpGet("/")]
    public IActionResult Get()
    {
        return Ok("Hello World!");
    }
}
