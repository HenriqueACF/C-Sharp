namespace VShop.CartAPI.DTOs;

public class CartHeaderDTO
{
    public int Id { get; set; }
    public string UserId { get; set; }
    public string CouponCode { get; set; } = string.Empty;
}