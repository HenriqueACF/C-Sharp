using Microsoft.EntityFrameworkCore;
using VShop.ProductAPI.Properties.Models;

namespace VShop.ProductAPI.Properties.Context;

public class AppDBContext: DbContext
{
    public AppDBContext(DbContextOptions<AppDBContext> options): base(options)
    {
        
    }
    
    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }
}