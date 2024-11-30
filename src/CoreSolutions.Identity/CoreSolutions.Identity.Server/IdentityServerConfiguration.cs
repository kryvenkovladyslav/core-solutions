using Duende.IdentityServer.Models;
using System.Xml.Linq;

namespace CoreSolutions.Identity.Server
{
    internal static class IdentityServerConfiguration
    {
        public static ICollection<Client> Clients { get; internal set; } = new List<Client>()
        {
            new Client
            {
                ClientId = "custom-client-id",
                AllowedScopes = ["openid", "profile"]
            }
        };

        public static IEnumerable<IdentityResource> IdentityResources { get; internal set; } = new List<IdentityResource>
        {
            new IdentityResources.OpenId(),
            new IdentityResources.Profile(),
            new IdentityResources.Email(),
            new IdentityResources.Phone(),
            new IdentityResources.Address()
        };
        
        public static IEnumerable<ApiScope> ApiScopes { get; internal set; }
    }
}