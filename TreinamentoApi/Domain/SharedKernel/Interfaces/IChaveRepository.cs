using TreinamentoApi.Domain.SharedKernel.Entities;

namespace TreinamentoApi.Domain.SharedKernel.Interfaces
{
    public interface IChaveRepository
    {
        Task<Chave> CadastrarChave(Chave chave);
        Task<Chave> ConsultarChave(int indice);
    }
}
