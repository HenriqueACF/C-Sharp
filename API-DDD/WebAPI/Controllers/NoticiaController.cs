using System.Collections.Generic;
using System.Threading.Tasks;
using Aplicação.Interfaces;
using Entidades.Entidades;
using Entidades.Notificacoes;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NoticiaController : Controller
    {
        private readonly IAplicacaoNoticia _IAplicacaoNoticia;

        public NoticiaController(IAplicacaoNoticia IAplicacaoNoticia)
        {
            _IAplicacaoNoticia = IAplicacaoNoticia;
        }
        
        [Authorize]
        [Produces("application/json")]
        [HttpPost("/api/ListarNoticias")]
        public async Task<List<Noticia>> ListarNoticias()
        {
            return await _IAplicacaoNoticia.ListarNoticiasAtivas();
        }

        [Authorize]
        [Produces("application/json")]
        [HttpPost("/api/AdicionaNoticia")]
        public async Task<List<Notifica>> AdicionaNoticia(NoticiaModel noticia)
        {
            var noticiaNova = new Noticia();
            noticiaNova.Titulo = noticia.Titulo;
            noticiaNova.Informacao = noticia.Informacao;
            noticiaNova.UserId = await RetornarIdUsuarioLogado();
            await _IAplicacaoNoticia.AdicionaNoticia(noticiaNova);

            return noticiaNova.Notificacoes;
        }
        
        [Authorize]
        [Produces("application/json")]
        [HttpPost("/api/AtualizaNoticia")]
        public async Task<List<Notifica>> AtualizaNoticia(NoticiaModel noticia)
        {
            var noticiaNova = await  _IAplicacaoNoticia.BuscarPorId(noticia.idNoticia);
            noticiaNova.Titulo = noticia.Titulo;
            noticiaNova.Informacao = noticia.Informacao;
            noticiaNova.UserId = await RetornarIdUsuarioLogado();
            await _IAplicacaoNoticia.AtualizaNoticia(noticiaNova);

            return noticiaNova.Notificacoes;
        }
        
        
        [Authorize]
        [Produces("application/json")]
        [HttpPost("/api/ExcluirNoticia")]
        public async Task<List<Notifica>> ExcluirNoticia(NoticiaModel noticia)
        {
            var noticiaNova = await  _IAplicacaoNoticia.BuscarPorId(noticia.idNoticia);
            noticiaNova.Titulo = noticia.Titulo;
            await _IAplicacaoNoticia.Excluir(noticiaNova);

            return noticiaNova.Notificacoes;
        }
        
        [Authorize]
        [Produces("application/json")]
        [HttpPost("/api/BuscarPorId")]
        public async Task<Noticia> BuscarPorId(NoticiaModel noticia)
        {
            var noticiaNova = await  _IAplicacaoNoticia.BuscarPorId(noticia.idNoticia);
            return noticiaNova;
        }

        private async Task<string> RetornarIdUsuarioLogado()
        {
            if (User != null)
            {
                var idusuario = User.FindFirst("idUsuario");
                return idusuario.Value;
            }
            else
            {
                return string.Empty;
            }
        }
        
        

    }
}