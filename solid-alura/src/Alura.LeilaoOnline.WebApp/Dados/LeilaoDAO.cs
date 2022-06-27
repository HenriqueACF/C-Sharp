using System.Collections.Generic;
using System.Linq;
using Alura.LeilaoOnline.WebApp.Models;
using Microsoft.EntityFrameworkCore;

namespace Alura.LeilaoOnline.WebApp.Dados
{
    public class LeilaoDAO
    {
        AppDbContext _context;

        public LeilaoDAO()
        {
            _context = new AppDbContext();
        }
        public Leilao BuscarPorId(int id)
        {
            return _context.Leiloes.First(l => l.Id == id);
        }

        public void Incluir(Leilao leilao)
        {
            _context.Leiloes.Add(leilao);
            _context.SaveChanges();
        }

        public void Alterar(Leilao leilao)
        {
            _context.Leiloes.Update(leilao);
            _context.SaveChanges();
        }

        public void Remover(Leilao leilao)
        {
            _context.Leiloes.Remove(leilao);
            _context.SaveChanges();
        }
        
        public IEnumerable<Categoria> BuscarCategorias()
        {
            return _context.Categorias.ToList();
        }
        
        public IEnumerable<Leilao> BuscarLeiloes()
        {
            return _context.Leiloes
                .Include(l => l.Categoria)
                .ToList();
        }
    }
}