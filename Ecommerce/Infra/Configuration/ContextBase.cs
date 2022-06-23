using Entities.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Infra.Configuration;

public class ContextBase: IdentityDbContext<ApplicationUser>
{
    public ContextBase(DbContextOptions<ContextBase> options): base(options)
    {
        
    }
    
    public DbSet<Product> Product{ get; set;}
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (optionsBuilder.IsConfigured)
            optionsBuilder.UseSqlServer(GetStringConnectionConfig);
        base.OnConfiguring(optionsBuilder);
    }

        //TODO -> criar imagem sqlserver no docker e configurar para usar
    private string GetStringConnectionConfig()
    {
        string strCon = "";
        return strCon;
    }
}

//12:00
//05

