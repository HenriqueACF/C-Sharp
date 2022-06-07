using VShop.Web.Models;
using VShop.Web.Services.Contracts;

namespace VShop.Web.Services;

public class ProductService : IProductService
{
    public Task<IEnumerable<ProductViewModel>> GetAllProducts()
    {
        throw new NotImplementedException();
    }

    public Task<ProductViewModel> FindProductById(int id)
    {
        throw new NotImplementedException();
    }

    public Task<ProductViewModel> CreateProduct(ProductViewModel productViewModel)
    {
        throw new NotImplementedException();
    }

    public Task<ProductViewModel> UpdateProduct(ProductViewModel productViewModel)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteProductById(int id)
    {
        throw new NotImplementedException();
    }
}