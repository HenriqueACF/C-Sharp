using System.ComponentModel.DataAnnotations.Schema;
using Entidades.Enums;
using Microsoft.AspNetCore.Identity;

namespace Entidades.Entidades
{
    public class ApplicationUser : IdentityUser
    {
        [Column("USER_IDADE")]
        public int Idade { get; set; }
        
        [Column("USR_CELULAR")]
        public string Celular { get; set; }
        
        [Column("USR_TIPO")]
        public TipoUsuario? Tipo { get; set; }
    }
}