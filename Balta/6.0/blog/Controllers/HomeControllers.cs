using Microsoft.AspNetCore.Mvc;

namespace blog.Controllers
{   
    [ApiController]
    [Route("")]
    public class HomeControllers : ControllerBase
    {
        [HttpGet("")]
        public IActionResult Get()
        {
            return Ok();
        }
    }
    
}

