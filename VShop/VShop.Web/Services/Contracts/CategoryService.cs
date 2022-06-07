using System.Text.Json;
using VShop.Web.Models;
using JsonSerializer = Newtonsoft.Json.JsonSerializer;

namespace VShop.Web.Services;

public class CategoryService: ICategoryService, ProductAPI.Services.ICategoryService
{
    private readonly IHttpClientFactory _clientFactory;
    private readonly JsonSerializerOptions _options;
    private const string apiEndpoint = "/api/categories";
    
    public CategoryService(IHttpClientFactory clientFactory)
    {
        _clientFactory = clientFactory;
        _options = 
            new JsonSerializerOptions
                { PropertyNameCaseInsensitive = true };
    }

    public async Task<IEnumerable<CategoryViewModel>> GetAllCategories()
    {
        IEnumerable<CategoryViewModel> categories;
        var response = await client.GetAsync(apiEndpoint);

        if (response.isSuccessStatusCode)
        {
            var apiResponse = await response.Content.ReadAsStreamAsync();
            categories = await JsonSerializer
                .DeserializeAsync<IEnumerable<CategoryViewModel>>(apiResponse, _options);
        }
        else
        {
            return null;
        }

        return categories;
    }
}