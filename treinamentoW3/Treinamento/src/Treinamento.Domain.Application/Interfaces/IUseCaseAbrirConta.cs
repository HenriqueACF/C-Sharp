
using Treinamento.Domain.Core.Models;
using Treinamento.Domain.Core.Models.VM;

namespace Treinamento.Domain.Application.Interfaces
{
    public interface IUseCaseAbrirConta
    {
        Conta NovaConta(ContaVM vm);

    }
}
