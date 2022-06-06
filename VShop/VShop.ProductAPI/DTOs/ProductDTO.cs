using System.ComponentModel.DataAnnotations;
using VShop.ProductAPI.Models;

namespace VShop.ProductAPI.DTOs;

public class ProductDTO
{
    public int Id { get; set; }
    
    [Required(ErrorMessage = "the Name is required")]
    [MinLength(3)]
    [MaxLength(100)]
    public string? Name { get; set; }
    
    [Required(ErrorMessage = "The Price is required")]
    public decimal Price { get; set; }
    
    [Required(ErrorMessage = "The Description is Required")]
    [MinLength(5)]
    [MaxLength(200)]
    public string? Description { get; set; }
    
    [Required(ErrorMessage = "The Stock is Required")]
    [Range(1, 999)]
    public long Stock { get; set; }
    public string? ImageUrl { get; set; }
    
    public Category? Category { get; set; }
    public int CategoryId { get; set; }
}