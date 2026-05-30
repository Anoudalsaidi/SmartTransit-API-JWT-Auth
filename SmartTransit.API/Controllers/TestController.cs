using Microsoft.AspNetCore.Mvc;

namespace SmartTransit.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TestController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok("SmartTransit API is running successfully");
    }
}