using System.Text.Json;

namespace VShop.Web.Models;

public class ProductViewModel
{
    private readonly IHttpClientFactory _clientFactory;
    private const string apiEndpoint = "/api/products/";
    private readonly JsonSerializerOptions _options;
    private ProductViewModel productVM;
    private IEnumerable<ProductViewModel> productsVM;

    public ProductViewModel(IHttpClientFactory clientFactory)
    {
        _clientFactory = clientFactory;
        _options = new JsonSerializerOptions 
            { PropertyNameCaseInsensitive = true };
    }

    public int Id { get; set; }
    public string? Name { get; set; }
    public decimal Price { get; set; }
    public string? Description { get; set; }
    public long Stock { get; set; }
    public string? ImageUrl { get; set; }
    public string? CategoryName { get; set; }
    public int CategoryId { get; set; }
}