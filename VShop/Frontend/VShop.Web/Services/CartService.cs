using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using VShop.Web.Models;

namespace VShop.Web.Services;

public class CartService: ICartService
{
    private readonly IHttpClientFactory _clientFactory;
    private readonly JsonSerializerOptions? _options;
    private const string apiEndPoint = "/api/cart";
    private CartVM cartVM = new CartVM();

    public CartService(IHttpClientFactory clientFactory, JsonSerializerOptions? options)
    {
        _clientFactory = clientFactory;
        _options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
    }

    public async Task<CartVM> GetCartByUserIdAsync(string userId, string token)
    {
        var client = _clientFactory.CreateClient("CartApi");
        PutTokenInHeaderAuthorization(token, client);

        using (var response = await client.GetAsync($"{apiEndPoint}/getcart/{userId}"))
        {
            if (response.IsSuccessStatusCode)
            {
                var apiResponse = await response.Content.ReadAsStreamAsync();
                cartVM = await JsonSerializer
                    .DeserializeAsync<CartVM>
                        (apiResponse, _options);
            }
            else
            {
                return null;
            }
        }
        return cartVM;
    }

    public async Task<CartVM> AddItemToCartAsync(CartVM cartVM, string token)
    {
        var client = _clientFactory.CreateClient("CartApi");
        PutTokenInHeaderAuthorization(token, client);
        
        StringContent content = 
            new StringContent(JsonSerializer.Serialize(cartVM), Encoding.UTF8, "application/json");

        using (var response = await client.PostAsync($"{apiEndPoint}/addcart/", content))
        {
            if (response.IsSuccessStatusCode)
            {
                var apiResponse = await response.Content.ReadAsStreamAsync();
                cartVM = await JsonSerializer
                    .DeserializeAsync<CartVM>
                        (apiResponse, _options);
            }
            else
            {
                return null;
            }
        }
        return cartVM;
    }

    public async Task<CartVM> UpdateCartAsync(CartVM cartVM, string token)
    {
        var client = _clientFactory.CreateClient("CartApi");
        PutTokenInHeaderAuthorization(token, client);

       CartVM cartUpdated = new CartVM();

        using (var response = await client.PutAsJsonAsync($"{apiEndPoint}/updatecart/", cartVM))
        {
            if (response.IsSuccessStatusCode)
            {
                var apiResponse = await response.Content.ReadAsStreamAsync();
                cartUpdated = await JsonSerializer
                    .DeserializeAsync<CartVM>
                        (apiResponse, _options);
            }
            else
            {
                return null;
            }
        }
        return cartUpdated;
    }

    public async Task<bool> RemoveFromCartAsync(int cartId, string token)
    {
        var client = _clientFactory.CreateClient("CartApi");
        PutTokenInHeaderAuthorization(token, client);

        using (var response = await client.DeleteAsync($"{apiEndPoint}/deletecart/" + cartId))
        {
            if (response.IsSuccessStatusCode)
            {
                return true;
            }
        }
        return false;
    }

    private static void PutTokenInHeaderAuthorization(string token, HttpClient client)
    {
        client.DefaultRequestHeaders.Authorization = 
            new AuthenticationHeaderValue("Bearer", token);
    }
}