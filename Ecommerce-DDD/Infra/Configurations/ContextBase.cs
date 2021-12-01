using Entities.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Infra.Configurations
{
    public class ContextBase : IdentityDbContext<ApplicatinUser>
    {
        public ContextBase(DbContextOptions<ContextBase> options): base(options)
        {
            
        }
        
        public DbSet<Product> Product { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(GetStringConnectionConfig());
                base.OnConfiguring(optionsBuilder);
            }
        }

        private string GetStringConnectionConfig()
        {
            string strCon = "//Endereço banco de dados";
            return strCon;
        }
    }
}