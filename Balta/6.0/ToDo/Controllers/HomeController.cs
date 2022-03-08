using Microsoft.AspNetCore.Mvc;
using ToDo.Data;
using Todo.Models;

namespace ToDo.Controllers
{
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet("/")]
        public List<TodoModels> Get([FromServices]AppDbContext context)
        {
            return context.Todos.ToList();
        }
        
        [HttpGet("/{id:int}")]
        public TodoModels GetById(
            [FromRoute] int id,
            [FromServices]AppDbContext context)
        {
            return context.Todos.FirstOrDefault(x => x.Id == id);
        }
        
        [HttpPost("/")]
        public TodoModels Post(
            [FromBody]TodoModels todo,
            [FromServices] AppDbContext context)
        {
            context.Todos.Add(todo);
            context.SaveChanges();

            return todo;
        }
        
        [HttpPut("/")]
        public TodoModels Put(
            [FromRoute]int id,
            [FromBody]TodoModels todo,
            [FromServices] AppDbContext context)
        {
            var model = context.Todos.FirstOrDefault(x => x.Id == id);
            if (model == null)
                return todo;

            model.Title = todo.Title;
            model.Done = todo.Done;

            context.Todos.Update(model);
            context.SaveChanges();
            return model;
        }
        
        [HttpDelete("/")]
        public TodoModels Delete(
            [FromRoute]int id,
            [FromBody]TodoModels todo,
            [FromServices] AppDbContext context)
        {
            var model = context.Todos.FirstOrDefault(x => x.Id == id);

            context.Todos.Remove(model);
            context.SaveChanges();
            return model;
        }
    }
    
}

