using blog.Attributes;
using Microsoft.AspNetCore.Mvc;

namespace blog.Controllers
{   
    [ApiController]
    [Route("")]
    public class HomeControllers : ControllerBase
    {
        [HttpGet("")]
        // [ApiKey]
        public IActionResult Get()
        {
            return Ok();
        }
    }
    
}

