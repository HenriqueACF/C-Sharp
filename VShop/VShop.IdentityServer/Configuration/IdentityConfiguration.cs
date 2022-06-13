using Duende.IdentityServer;
using Duende.IdentityServer.Models;

namespace VShop.IdentityServer.Configuration;

public class IdentityConfiguration
{
    public const string Admin = "Admin";
    public const string Client = "Client";

    public static IEnumerable<IdentityResource> IdentityResources => new List<IdentityResource>
    {
        new IdentityResources.OpenId(),
        new IdentityResources.Email(),
        new IdentityResources.Profile()
    };

    public static IEnumerable<ApiScope> ApiScopes => new List<ApiScope>
    {
        //VSHOP É A APLICAÇÃO QUE VAI ACESSAR O IDENTITYSERVER PARA OBTER O TOKEN
        new ApiScope("vshop", "VShop Server"),
        new ApiScope(name: "read", "Read data"),
        new ApiScope(name:"write", "Write data"),
        new ApiScope(name:"delete", "Delete data"),
    };

    public static IEnumerable<Client> Clients => new List<Client>
    {
        new Client
        {
            ClientId = "client",
            ClientSecrets = {new Secret("abracadabra#simsalabim".Sha256())},
            AllowedGrantTypes = GrantTypes.Code,
            RedirectUris = {"https:localhost:7165/signin-oidc"},//LOGIN
            PostLogoutRedirectUris = {"https://localhost:7165/signout-callback-oidc"},
            AllowedScopes = new List<string>
            {
                IdentityServerConstants.StandardScopes.OpenId,
                IdentityServerConstants.StandardScopes.Profile,
                IdentityServerConstants.StandardScopes.Email,
                "vshop"
            }
        }
    };
}