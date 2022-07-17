using VShop.Web.Models;

namespace VShop.Web.Services.Contracts;

public interface IProductService
{
    Task<IEnumerable<ProductVM>> GetAllProducts();
    Task<ProductVM> FindProductById(int id);
    Task<ProductVM> CreateProduct(ProductVM productVM);
    Task<ProductVM> UpdateProduct(ProductVM productVM);
    Task<bool> DeleteProductById(int id);
}