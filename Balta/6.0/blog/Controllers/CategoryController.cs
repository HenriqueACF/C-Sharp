using Blog.Data;
using Microsoft.AspNetCore.Mvc;

namespace blog.Controllers
{
    [ApiController]
    public class CategoryController : ControllerBase
    {
        [HttpGet("v1/categories")]
        public IActionResult Get(
            [FromServices] BlogDataContext context)
        {
            var categories = context.Categories.ToList();
            return Ok(categories);
        }
    }
    
}

