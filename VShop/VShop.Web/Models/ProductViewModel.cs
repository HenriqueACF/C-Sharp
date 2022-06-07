using System.ComponentModel.DataAnnotations;
using System.Text.Json;

namespace VShop.Web.Models;

public class ProductViewModel
{
    public int Id { get; set; }
    
    [Microsoft.Build.Framework.Required]
    public string? Name { get; set; }
    
    [Microsoft.Build.Framework.Required]
    public decimal Price { get; set; }
    
    [Microsoft.Build.Framework.Required]
    public string? Description { get; set; }
    
    [Microsoft.Build.Framework.Required]
    public long Stock { get; set; }
    
    [Microsoft.Build.Framework.Required]
    public string? ImageUrl { get; set; }
    public string? CategoryName { get; set; }
    [Display(Name = "Categories")]
    public int CategoryId { get; set; }
}