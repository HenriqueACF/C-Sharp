using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using VShop.Web.Models;
using VShop.Web.Services;

namespace VShop.Web.Controllers;

public class CartController: Controller
{
    private readonly ICartService _cartService;

    public CartController(ICartService cartService)
    {
        _cartService = cartService;
    }

    [HttpGet]
    [Authorize]
    public async Task<IActionResult> Index()
    {
        CartVM? cartVM = await GetCartByUser();
        if (cartVM == null)
        {
            ModelState.AddModelError("CartNotFound", "does not exist a cart yet...come on shopping"); 
            return View("/Views/Cart/CartNotFound.cshtml");
        }
        return View();
    }

    private async Task<CartVM?> GetCartByUser()
    {

        var cart = await _cartService.GetCartByUserIdAsync(GetUserId(), await GetAccessToken());

        if(cart?.CartHeader is not null)
        {
            foreach(var item in cart.CartItems)
            {
                cart.CartHeader.TotalAmount += (item.Product.Price * item.Quantity);
            }
        }
        return cart;
    }

    public async Task<IActionResult> RemoveItem(int id)
    {
        var result = await _cartService.RemoveItemFromCartAsync(id, await GetAccessToken());

        if (result)
        {
            return RedirectToAction(nameof(Index));
        }
        return View(id);
    }
 
    private async Task<string> GetAccessToken()
    {
        return await HttpContext.GetTokenAsync("access_token");
    }

    private string GetUserId()
    {
        return User.Claims.Where(u => u.Type == "sub")?.FirstOrDefault()?.Value;
    }
}