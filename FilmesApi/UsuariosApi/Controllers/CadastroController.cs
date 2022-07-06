using Microsoft.AspNetCore.Mvc;using MySqlX.XDevAPI.Common;
using UsuariosApi.Data.DTOs;
using UsuariosApi.Services;
using Result = FluentResults.Result;

namespace UsuariosApi.Controllers;

[Route("[controller]")]
[ApiController]
public class CadastroController: ControllerBase
{
    private CadastroService _cadastroService;
    
    
    [HttpPost]
    public IActionResult Cadastrarusuario(CreateUsuarioDto createDto)
    {
        Result resultado = _cadastroService.CadastrarUsuario(createDto);
        if (resultado.IsFailed) return StatusCode(500);
        return Ok();
    }
}