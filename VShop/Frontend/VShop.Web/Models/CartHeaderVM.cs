namespace VShop.Web.Models;

public class CartHeaderVM
{
    public int Id { get; set; }
    public string UserId { get; set; } = string.Empty;
    public string CouponCode { get; set; } = string.Empty;
    public double TotalAmount { get; set; } = 0.00d;
}