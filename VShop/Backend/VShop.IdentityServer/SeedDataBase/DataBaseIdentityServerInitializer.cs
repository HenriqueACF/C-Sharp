using System.Security.Claims;
using IdentityModel;
using Microsoft.AspNetCore.Identity;
using VShop.IdentityServer.Configuration;
using VShop.IdentityServer.Data;

namespace VShop.IdentityServer.SeedDataBase;

public class DataBaseIdentityServerInitializer: IDataBaseSeedInitializer
{
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly RoleManager<IdentityRole> _roleManager;

    public DataBaseIdentityServerInitializer(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
    {
        _userManager = userManager;
        _roleManager = roleManager;
    }

    public void InitalizeSeedRoles()
    {
        //Verifica se o perfil existe, e cria um caso nao exista perfil.
        if (!_roleManager.RoleExistsAsync(IdentityConfiguration.Admin).Result)
        {
            //cria um perfil de admin
            IdentityRole roleAdmin = new IdentityRole();
            roleAdmin.Name = IdentityConfiguration.Admin;
            roleAdmin.NormalizedName = IdentityConfiguration.Admin.ToUpper();
            _roleManager.CreateAsync(roleAdmin).Wait();
        }
        if (!_roleManager.RoleExistsAsync(IdentityConfiguration.Client).Result)
        {
            //cria um perfil de cliente
            IdentityRole roleClient = new IdentityRole();
            roleClient.Name = IdentityConfiguration.Client;
            roleClient.NormalizedName = IdentityConfiguration.Client.ToUpper();
            _roleManager.CreateAsync(roleClient).Wait();
        }
    }

    public void InitializeSeedUsers()
    {
        //se o usuario nao existe, cria um um usuario define a senha e atribui ao perfil
        if (_userManager.FindByEmailAsync("admin1@admin.com").Result == null)
        {
            ApplicationUser admin = new ApplicationUser()
            {
                UserName = "admin1",
                NormalizedUserName = "ADMIN1",
                Email = "admin1@admin.com",
                NormalizedEmail = "ADMIN1@admin.com",
                EmailConfirmed = true,
                LockoutEnabled = false,
                PhoneNumber = "91981955168",
                FirstName = "User",
                LastName = "Admin1",
                SecurityStamp = Guid.NewGuid().ToString()
            };
            // cria admin e atribui senha
            IdentityResult resultAdmin = _userManager.CreateAsync(admin, "Numsey#2022").Result;
            if (resultAdmin.Succeeded)
            {
                // inclui usuario admin ao perfil admin
                _userManager.AddToRoleAsync(admin, IdentityConfiguration.Admin).Wait();
                //inclui as claims ao usuario admin
                var adminClaims = _userManager.AddClaimsAsync(admin, new Claim[]
                {
                    new Claim(JwtClaimTypes.Name, $"{admin.FirstName} {admin.LastName}"),
                    new Claim(JwtClaimTypes.GivenName, admin.FirstName),
                    new Claim(JwtClaimTypes.FamilyName, admin.LastName),
                    new Claim(JwtClaimTypes.Role, IdentityConfiguration.Admin),
                }).Result;
            }
        }
        //se o usuario client nao existe, cria um um usuario define a senha e atribui ao perfil
        if (_userManager.FindByEmailAsync("client1@client.com").Result == null)
        {
            //define os dados ao usuario client
            ApplicationUser client = new ApplicationUser()
            {
                UserName = "client1",
                NormalizedUserName = "client1",
                Email = "client1@client.com",
                NormalizedEmail = "Clinet1@client.com",
                EmailConfirmed = true,
                LockoutEnabled = false,
                PhoneNumber = "91981955168",
                FirstName = "User",
                LastName = "Client1",
                SecurityStamp = Guid.NewGuid().ToString()
            };
            // cria client e atribui senha
            IdentityResult resultClient = _userManager.CreateAsync(client, "Numsey#2022").Result;
            if (resultClient.Succeeded)
            {
                // inclui usuario client ao perfil client
                _userManager.AddToRoleAsync(client, IdentityConfiguration.Client).Wait();
                //inclui as claims ao usuario client
                var adminClaims = _userManager.AddClaimsAsync(client, new Claim[]
                {
                    new Claim(JwtClaimTypes.Name, $"{client.FirstName} {client.LastName}"),
                    new Claim(JwtClaimTypes.GivenName, client.FirstName),
                    new Claim(JwtClaimTypes.FamilyName, client.LastName),
                    new Claim(JwtClaimTypes.Role, IdentityConfiguration.Client),
                }).Result;
            }
        }
    }
}