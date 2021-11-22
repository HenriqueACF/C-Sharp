using System.Collections.Generic;
using System.Threading.Tasks;
using Aplicação.Interfaces.Genericos;
using Entidades.Entidades;

namespace Aplicação.Interfaces
{
    public interface IAplicacaoNoticia : IGenericaAplicacao<Noticia>
    {
        Task AdicionaNoticia(Noticia noticia);
        Task AtualizaNoticia(Noticia notica);
        Task<List<Noticia>> ListarNoticiasAtivas();
    }
}