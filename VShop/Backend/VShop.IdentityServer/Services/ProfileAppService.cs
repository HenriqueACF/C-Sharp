using System.Security.Claims;
using Duende.IdentityServer.Extensions;
using Duende.IdentityServer.Models;
using Duende.IdentityServer.Services;
using IdentityModel;
using Microsoft.AspNetCore.Identity;
using VShop.IdentityServer.Data;

namespace VShop.IdentityServer.Services;

public class ProfileAppService: IProfileService
{
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly IUserClaimsPrincipalFactory<ApplicationUser> _userClaimsPrincipalFactory;
    private readonly RoleManager<IdentityRole> _roleManager;

    public ProfileAppService(UserManager<ApplicationUser> userManager,
        RoleManager<IdentityRole> roleManager,
        IUserClaimsPrincipalFactory<ApplicationUser> userClaimsPrincipalFactory)
    {
        _userManager = userManager;
        _roleManager = roleManager;
        _userClaimsPrincipalFactory = userClaimsPrincipalFactory;
    }

    public async Task GetProfileDataAsync(ProfileDataRequestContext context)
    {
        //obter id
        string id = context.Subject.GetSubjectId();
        //localiza user pelo id
        ApplicationUser user = await _userManager.FindByIdAsync(id);
        //cria as claims
        ClaimsPrincipal userClains = await _userClaimsPrincipalFactory.CreateAsync(user);
        //define coleção de claims para o usuario incluindo nome e sobrenome
        List<Claim> claims = userClains.Claims.ToList();
        claims.Add(new Claim(JwtClaimTypes.FamilyName, user.LastName));
        claims.Add(new Claim(JwtClaimTypes.GivenName, user.FirstName));
        //verifica se suporta roles
        if (_userManager.SupportsUserRole)
        {
            IList<string> roles = await _userManager.GetRolesAsync(user);
            foreach (string role in roles)
            {
                claims.Add(new Claim(JwtClaimTypes.Role, role));
                if (_roleManager.SupportsRoleClaims)
                {
                    IdentityRole identityRole = await _roleManager.FindByNameAsync(role);
                    if (identityRole != null)
                    {
                        claims.AddRange(await _roleManager.GetClaimsAsync(identityRole));
                    }
                }
            }
        }
        //retorna claims no contexto
        context.IssuedClaims = claims;
    }

    public async Task IsActiveAsync(IsActiveContext context)
    {
        string userId = context.Subject.GetSubjectId();
        ApplicationUser user = await _userManager.FindByIdAsync(userId);

        context.IsActive = user != null;
    }
}