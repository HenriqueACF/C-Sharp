using Blog.Data;
using blog.Extensions;
using Blog.Models;
using blog.Services;
using blog.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace blog.Controllers;

[ApiController]
public class AccountController : ControllerBase
{
    [HttpPost("v1/accounts/")]
    public async Task<IActionResult> Post(
        [FromBody] RegisterViewModel model,
        [FromServices] BlogDataContext context)
    {
        if (!ModelState.IsValid)
            return BadRequest((new ResultViewModel<string>(ModelState.GetErros())));

        var user = new User
        {
            Name = model.Name,
            Email = model.Email,
            Slug = model.Email.Replace("@", "-").Replace(".", "-")
        };
    }
    
    [HttpPost("v1/accounts/login")]
    public IActionResult Login([FromServices] TokenService tokenService)
    {
        var token = tokenService.GenerateToke(null);

        return Ok(token);
    }
    
}