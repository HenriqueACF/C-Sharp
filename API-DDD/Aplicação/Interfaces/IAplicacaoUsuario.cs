using System.Threading.Tasks;

namespace Aplicação.Interfaces
{
    public interface IAplicacaoUsuario
    {
        Task<bool> AdicionarUsuario(string email, string senha, int idade, string celular);
        Task<bool> ExisteUsuario(string email, string senha);
    }
}