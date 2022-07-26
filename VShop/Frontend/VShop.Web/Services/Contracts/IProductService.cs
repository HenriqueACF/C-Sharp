using VShop.Web.Models;

namespace VShop.Web.Services.Contracts;

public interface IProductService
{
    Task<IEnumerable<ProductVM>> GetAllProducts(string token);
    Task<ProductVM> FindProductById(int id, string token);
    Task<ProductVM> CreateProduct(ProductVM productVM, string token);
    Task<ProductVM> UpdateProduct(ProductVM productVM, string token);
    Task<bool> DeleteProductById(int id, string token);
}