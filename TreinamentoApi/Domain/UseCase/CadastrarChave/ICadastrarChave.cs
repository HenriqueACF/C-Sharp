using TreinamentoApi.Domain.SharedKernel.Entities;
using TreinamentoApi.Domain.SharedKernel.Responses;

namespace TreinamentoApi.Domain.UseCase.CadastrarChave
{
    public interface ICadastrarChave
    {
        Task<ChaveResponse> AdicionarChave(Chave chave);
    }
}
