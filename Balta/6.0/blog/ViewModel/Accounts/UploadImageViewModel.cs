using System.ComponentModel.DataAnnotations;

namespace blog.ViewModel.Accounts;

public class UploadImageViewModel
{
    [Required(ErrorMessage = "Imagem inválida")]
    public  string Base64Image { get; set; }
}