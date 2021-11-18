using System.ComponentModel.DataAnnotations;

namespace ShopAPI.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Este campo é obrigátorio")]
        [MaxLength(20, ErrorMessage = "Este campo deve ter entre 3 e 20 caracteres")]
        [MinLength(3, ErrorMessage = "Este campo deve ter entre 3 e 20 caracteres")]
        public string Username { get; set; }
        
        [Required(ErrorMessage = "Este campo é obrigátorio")]
        [MaxLength(20, ErrorMessage = "Este campo deve ter entre 3 e 20 caracteres")]
        [MinLength(3, ErrorMessage = "Este campo deve ter entre 3 e 20 caracteres")]
        public string Password { get; set; }
        
        public string Role { get; set; }
    }
}