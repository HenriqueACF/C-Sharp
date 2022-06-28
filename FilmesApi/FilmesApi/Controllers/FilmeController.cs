using FilmesApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace FilmesApi.Controllers;

[ApiController]
[Route("Controller")]
public class FilmeController: ControllerBase
{
    private static List<Filme> filmes = new List<Filme>();
    private static int id = 1;
    
    [HttpPost]
    public IActionResult
        AdicionarFilme([FromBody]Filme filme)
    {
        filme.Id = id++;
        filmes.Add(filme);
        return
            CreatedAtAction(nameof(RecuperarFilmePorId), 
                new { Id = filme.Id }, 
                filme);
    }

    [HttpGet]
    public IActionResult RecuperarFilmes()
    {
        return Ok(filmes);
    }

    [HttpGet("{id}")]
    public IActionResult RecuperarFilmePorId(int id)
    {
        Filme filme = filmes.FirstOrDefault(filme => filme.Id == id);
        if (filme is not null)
        {
            return Ok(filme);
        }

        return NotFound();
    }
}