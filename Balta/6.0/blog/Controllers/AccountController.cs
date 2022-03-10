using blog.Services;
using Microsoft.AspNetCore.Mvc;

namespace blog.Controllers;

[ApiController]
public class AccountController : ControllerBase
{
    [HttpPost("v1/login")]
    public IActionResult Login([FromServices] TokenService tokenService)
    {
        var token = tokenService.GenerateToke(null);

        return Ok(token);
    }
}