
using System.Threading.Tasks;
using Treinamento.Domain.Core.Models;
using Treinamento.Domain.Core.ValueObjetcs.Transacao;

namespace Treinamento.Domain.Application.Interfaces
{
    public interface IUseCaseAbrirConta
    {
        Task<Conta> NovaConta(TransacaoAbrirConta vm);

    }
}
