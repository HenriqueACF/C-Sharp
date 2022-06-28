using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Models;

public class Filme
{
    public int Id { get; set; }
    [Required(ErrorMessage = "O Titulo precisa ser informado")]
    public string Titulo { get; set; }
    [Required (ErrorMessage = "O diretor precisa ser informado")]
    public string Diretor { get; set; }
    public string Genero { get; set; }
    [Range(1,600, ErrorMessage = "Aduração precisa ser informada")]
    public int Duracao { get; set; }
}