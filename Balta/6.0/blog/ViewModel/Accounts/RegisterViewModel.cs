using System.ComponentModel.DataAnnotations;

namespace blog.ViewModel.Accounts;

public class RegisterViewModel
{
    [Required(ErrorMessage = "O nome é obrigatorio")]
    public string Name { get; set; }
    
    [Required(ErrorMessage = "O E-mail é obrigatorio")]
    [EmailAddress(ErrorMessage = "O E-mail é invalido")]
    public string Email { get; set; }
}