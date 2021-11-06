using Microsoft.AspNetCore.Mvc;
using Treinamento.Domain.Application.Interfaces;
using Treinamento.Domain.Core.Models;
using Treinamento.Domain.Core.Models.VM;

namespace Treinamento.Ports.WebAPI.Routes
{
    [Route("api/[controller]")]
    [ApiController]
    public class AbrirConta : ControllerBase
    {
        private readonly IUseCaseAbrirConta _usecaseservice;
        public AbrirConta(IUseCaseAbrirConta usecaseservice)
        {
            _usecaseservice = usecaseservice;
        }


        [HttpPost]
        public ActionResult NovaConta(ContaVM vm)
        {
            return Ok(_usecaseservice.NovaConta(vm));
        }
    }
}
