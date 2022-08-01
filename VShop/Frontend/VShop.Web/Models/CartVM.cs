namespace VShop.Web.Models;

public class CartVM
{
    public CartHeaderVM CartHeader { get; set; } = new CartHeaderVM();
    public IEnumerable<CartItemVM>? CartItems { get; set; }
}