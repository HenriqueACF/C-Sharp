using System.Threading.Tasks;
using Treinamento.Adapters.DAL.Interfaces;
using Treinamento.Domain.Application.Interfaces;
using Treinamento.Domain.Core.Models;
using Treinamento.Domain.Core.ValueObjetcs.Transacao;

namespace Treinamento.Domain.Application.UseCases
{
    public class UseCaseAbrirConta : IUseCaseAbrirConta
    {
        protected readonly IContaRepository _repo;

        public UseCaseAbrirConta(IContaRepository repo)
        {
            _repo = repo;
        }

        public async Task<Conta> NovaConta(TransacaoAbrirConta vm)
        {

            return await _repo.AbrirConta(new Conta(vm));
        }


        //public async Task<bool> FecharConta(TransacaoFecharConta vm)
        //{

        //    return await _repo.FecharConta(new Conta(vm));

        //}
    }
}
