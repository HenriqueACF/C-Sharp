using Microsoft.AspNetCore.Mvc;

namespace Treinamento.Ports.WebAPI.Routes
{
    [Route("api/[controller]")]
    [ApiController]
    public class Cliente : ControllerBase
    {
        [HttpGet]
        public ActionResult Get()
        {
            return Ok();
        }
    }
}