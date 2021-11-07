using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Treinamento.Domain.Application.Interfaces;
using Treinamento.Domain.Core.ValueObjetcs.Transacao;

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
        public async Task<ActionResult> NovaConta(TransacaoAbrirConta vm)
        {
            vm.CodTran = 1000;
            return Ok(await _usecaseservice.NovaConta(vm));
        }


        //[HttpDelete]
        //public ActionResult FecharConta(TransacaoFecharConta vm)
        //{
        //    vm.CodTran = 1001;
        //    return Ok(_usecaseservice.NovaConta(vm));
        //}



    }
}
