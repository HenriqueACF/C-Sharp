using Microsoft.AspNetCore.Mvc;
using ToDo.Data;
using Todo.Models;

namespace ToDo.Controllers
{
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet("/")]
        public IActionResult Get([FromServices] AppDbContext context)
            => Ok(context.Todos.ToList());
        
        [HttpGet("/{id:int}")]
        public IActionResult GetById(
            [FromRoute] int id,
            [FromServices]AppDbContext context)
        {
            var todos = context.Todos.FirstOrDefault(x => x.Id == id);
            if (todos == null)
                return NotFound();

            return Ok(todos);
        }
        
        [HttpPost("/")]
        public IActionResult Post(
            [FromBody]TodoModels todo,
            [FromServices] AppDbContext context)
        {
            context.Todos.Add(todo);
            context.SaveChanges();

            return Created($"/{todo.Id}", todo);
        }
        
        [HttpPut("/")]
        public IActionResult Put(
            [FromRoute]int id,
            [FromBody]TodoModels todo,
            [FromServices] AppDbContext context)
        {
            var model = context.Todos.FirstOrDefault(x => x.Id == id);
            if (model == null)
                return NotFound();

            model.Title = todo.Title;
            model.Done = todo.Done;

            context.Todos.Update(model);
            context.SaveChanges();
            return Ok(model);
        }
        
        [HttpDelete("/")]
        public IActionResult Delete(
            [FromRoute]int id,
            [FromBody]TodoModels todo,
            [FromServices] AppDbContext context)
        {
            var model = context.Todos.FirstOrDefault(x => x.Id == id);
            if (model == null)
                return NotFound();

            context.Todos.Remove(model);
            context.SaveChanges();
            return Ok(model);
        }
    }
    
}

