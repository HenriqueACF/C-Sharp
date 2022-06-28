using System.Collections.Generic;
using Alura.LeilaoOnline.WebApp.Models;

namespace Alura.LeilaoOnline.WebApp.Dados
{
    public interface ILeilaoDAO
    {
        IEnumerable<Categoria> BuscarCategorias();
        IEnumerable<Leilao> BuscarLeiloes();
        Leilao BuscarPorId(int id);
        void Incluir(Leilao leilao);
        void Alterar(Leilao leilao);
        void Remover(Leilao leilao);
    }
}