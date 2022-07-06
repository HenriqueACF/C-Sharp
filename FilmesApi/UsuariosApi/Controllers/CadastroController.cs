using Microsoft.AspNetCore.Mvc;
using UsuariosApi.Data.DTOs;

namespace UsuariosApi.Controllers;

[Route("[controller]")]
[ApiController]
public class CadastroController: ControllerBase
{
    [HttpPost]
    public IActionResult Cadastrarusuario(CreateUsuarioDto createDto)
    {
        return Ok();
    }
}