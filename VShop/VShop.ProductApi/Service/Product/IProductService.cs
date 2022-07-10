using VShop.ProductApi.DTOs;

namespace VShop.ProductApi.Service.Product;

public interface IProductService
{
    Task<IEnumerable<ProductDTO>> GetProducts();
    Task<ProductDTO> GetProducyById(int id);
    Task AddProduct(ProductDTO productDto);
    Task UpdateProduct(ProductDTO productDto);
    Task DeleteProduct(int id);
}