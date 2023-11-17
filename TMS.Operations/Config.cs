using IdentityModel;
using IdentityServer4.Models;
using Microsoft.AspNetCore.DataProtection;
using static IdentityModel.OidcConstants;
using Secret = IdentityServer4.Models.Secret;

namespace TMS.Operations
{
    public class Config
    {
        //public static IEnumerable<ApiScope> ApiScopes =>
        // new ApiScope[]
        // {
        //    new ApiScope("movieAPI", "Movie API")
        // };

        //public static IEnumerable<Client> Clients =>
        //     new Client[]
        //     {
        //         new Client
        //         {
        //             ClientId = "movieClient",
        //             AllowedGrantTypes = GrantTypes.ClientCredentials,
        //             ClientSecrets =
        //             {
        //             new Secret("secret".ToSha256())
        //             },
        //             AllowedScopes = { "movieAPI" }
        //         }
        //     };
    }
}
