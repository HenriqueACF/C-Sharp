using System.Collections.Generic;
using System.Threading.Tasks;
using Entidades.Entidades;

namespace Dominio.Interfaces.InterfaceServiços
{
    public interface IServicoNoticia
    {
        Task AdicionaNoticia(Noticia noticia);
        Task AtualizaNoticia(Noticia notica);
        Task<List<Noticia>> ListarNoticiasAtivas();
    }
}