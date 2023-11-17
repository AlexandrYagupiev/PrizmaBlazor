using IdentityModel.Client;

namespace TMS.Web.Services
{
    public interface ITokenService
    {
        Task<TokenResponse> GetToken(string scope);
    }
}
