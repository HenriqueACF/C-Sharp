using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Dominio.Interfaces.Genericos;
using Entidades.Entidades;

namespace Dominio.Interfaces
{
    public interface INoticia : IGenericos<Noticia>
    {
        Task<List<Noticia>> ListarNoticias(Expression<Func<Noticia,bool>> exNoticia);
    }
}