using AutoMapper;
using Microsoft.EntityFrameworkCore;
using VShop.CartAPI.Context;
using VShop.CartAPI.DTOs;
using VShop.CartAPI.Models;

namespace VShop.CartAPI.Repository;

public class CartRepository: ICartRepository
{
    private readonly AppDbContext _context;
    private IMapper _mapper;
    public CartRepository(AppDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }
    
    public async Task<CartDTO> GetCartByUserIdAsync(string userId)
    {
        Cart cart = new Cart
        {
            //obtem header 
            CartHeader = await _context.CartHeaders.FirstOrDefaultAsync(c => c.UserId == userId)
        };
        //obtem itens
        cart.CartItems = _context.CartItems
            .Where(c => c.CartHeaderId == cart.CartHeader.Id).Include(c => c.Product);
        return _mapper.Map<CartDTO>(cart);
    }
    
    public async Task<bool> DeleteItemCartAsync(int cartItemId)
    {
        try
        {
            CartItem cartItem = await _context.CartItems.FirstOrDefaultAsync(c => c.Id == cartItemId);
            int total = _context.CartItems
                .Where(c => c.CartHeaderId == cartItem.CartHeaderId).Count();
            _context.CartItems.Remove(cartItem);
            if (total == 1)
            {
                var cartHeaderRemove =
                    await _context.CartHeaders.FirstOrDefaultAsync(c => c.Id == cartItem.CartHeaderId);
                _context.CartHeaders.Remove(cartHeaderRemove);
            }

            await _context.SaveChangesAsync();
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }
    
    public async Task<bool> CleanCartAsync(string userId)
    {
        var cartHeader = await _context.CartHeaders.FirstOrDefaultAsync(c => c.UserId == userId);
        if (cartHeader != null)
        {
            _context.CartItems.RemoveRange(_context.CartItems.Where(c => c.CartHeaderId == cartHeader.Id));
            _context.CartHeaders.Remove(cartHeader);

            await _context.SaveChangesAsync();
            return true;
        }
        return false;
    }

    public async Task<CartDTO> UpdateCartAsync(CartDTO cartDto)
    {
        Cart cart = _mapper.Map<Cart>(cartDto);
        //salva produto se nao existir
        await SaveProductInDataBase(cartDto, cart);
        
        //verifica se o header é null
        var cartHeader = 
            await _context.CartHeaders
                .AsNoTracking()
                .FirstOrDefaultAsync(c => c.UserId == cart.CartHeader.UserId);

        if (cartHeader is null)
        {
            //cria header e os itens
            await CreateCartHeaderAndItems(cart);
        }
        else
        {
            //atualiza quantidade de items
            await UpdateQuantityAndItems(cartDto, cart, cartHeader);
        }
        return _mapper.Map<CartDTO>(cart);
    }
    
    private async Task UpdateQuantityAndItems(CartDTO cartDto, Cart cart, CartHeader? cartHeader)
    {
        //se cartheader não e null
        //verifica se cartitems possui o mesmo produto
        var cartItem = await _context.CartItems.AsNoTracking().FirstOrDefaultAsync(
            p => p.ProductId == cartDto.CartItems.FirstOrDefault()
                .ProductId && p.CartHeaderId == cartHeader.Id);

        if (cartItem is null)
        {
            //cria o cartitems
            cart.CartItems.FirstOrDefault().CartHeaderId = cartHeader.Id;
            cart.CartItems.FirstOrDefault().Product = null;
            _context.CartItems.Add(cart.CartItems.FirstOrDefault());
            await _context.SaveChangesAsync();
        }
        else
        {
            //atualiza a quantidade e o cartitems
            cart.CartItems.FirstOrDefault().Product = null;
            cart.CartItems.FirstOrDefault().Quantity += cartItem.Quantity;
            cart.CartItems.FirstOrDefault().Id = cartItem.Id;
            cart.CartItems.FirstOrDefault().CartHeaderId = cartItem.CartHeaderId;
            _context.CartItems.Update(cart.CartItems.FirstOrDefault());
            await _context.SaveChangesAsync();
        }
    }

    private async Task CreateCartHeaderAndItems(Cart cart)
    {
        //cria o cartheader e o cartitems
        _context.CartHeaders.Add(cart.CartHeader);
        await _context.SaveChangesAsync();

        cart.CartItems.FirstOrDefault().CartHeaderId = cart.CartHeader.Id;
        cart.CartItems.FirstOrDefault().Product = null;

        _context.CartItems.Add(cart.CartItems.FirstOrDefault());

        await _context.SaveChangesAsync();
    }

    private async Task SaveProductInDataBase(CartDTO cartDto, Cart cart)
    {
        //verifica se o produto ja foi salvo
        var product =
            await _context.Products.FirstOrDefaultAsync(p => p.Id == cartDto.CartItems.FirstOrDefault().ProductId);

        if (product == null)
        {
            _context.Products.Add(cart.CartItems.FirstOrDefault().Product);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<bool> ApplyCouponAsync(string userId, string couponCode)
    {
        throw new NotImplementedException();
    }

    public async Task<bool> DeleteCouponAsync(string userId)
    {
        throw new NotImplementedException();
    }
}