using VShop.Web.Models;

namespace VShop.Web.Services;

public interface ICartService
{
    Task<CartVM> GetCartByUserIdAsync(string userId, string token);
    Task<CartVM> AddItemToCartAsync(CartVM cartVM, string token);
    Task<CartVM> UpdateCartAsync(CartVM cartVM, string token);
    Task<bool> RemoveFromCartAsync(int cartId, string token);
    
    //implementações que serão feitas no futuro
    // Task<bool> ApplyCouponAsync(CartVM cartVM, string couponCode, string token);
    // Task<bool> RemoveCouponAsync(string userId, string token);
    // Task<bool> ClearCartAsync(string userId, string token);
    // Task<CartVM> CheckoutAsync(CartHeaderVM cartHeader, string token);
}