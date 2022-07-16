using System.Text.Json;
using VShop.Web.Models;
using VShop.Web.Services.Contracts;

namespace VShop.Web.Services;

public class ProductService: IProductService
{
    private readonly IHttpClientFactory _clientFactory;
    private const string apiEndpoint = "/api/products/";
    private readonly JsonSerializerOptions _options;
    private readonly ProductVM productVM;
    private IEnumerable<ProductVM> productsVM;
    public ProductService(IHttpClientFactory clientFactory)
    {
        _clientFactory = clientFactory;
        _options = new JsonSerializerOptions{PropertyNameCaseInsensitive = true};
    }

    public async Task<IEnumerable<ProductVM>> GetAllProducts()
    {
        
    }

    public async Task<ProductVM> FindProductById(int id)
    {
        
    }

    public async Task<ProductVM> CreateProduct(ProductVM productVM)
    {
        
    }

    public async Task<ProductVM> UpdateProduct(ProductVM productVM)
    {
        
    }

    public async Task<bool> DeleteProductById(int id)
    {
        
    }
}