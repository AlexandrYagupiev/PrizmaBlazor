using Skoruba.IdentityServer4.Shared.Configuration.Configuration.Identity;
using TMS.IdentityServer.STS.Identity.Configuration.Interfaces;

namespace TMS.IdentityServer.STS.Identity.Configuration
{
    public class RootConfiguration : IRootConfiguration
    {      
        public AdminConfiguration AdminConfiguration { get; } = new AdminConfiguration();
        public RegisterConfiguration RegisterConfiguration { get; } = new RegisterConfiguration();
    }
}







