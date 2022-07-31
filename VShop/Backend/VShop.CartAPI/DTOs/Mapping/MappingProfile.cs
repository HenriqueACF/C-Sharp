using AutoMapper;
using VShop.CartAPI.Models;

namespace VShop.CartAPI.DTOs.Mapping;

public class MappingProfile: Profile
{
    public MappingProfile()
    {
        CreateMap<CartDTO, Cart>().ReverseMap();
        CreateMap<CartHeaderDTO, CartHeader>().ReverseMap();
        CreateMap<CartItemDTO, CartItem>().ReverseMap();
        CreateMap<ProductDTO, Product>().ReverseMap();
    }
}