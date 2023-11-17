using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.DependencyInjection;
using Ocelot.DependencyInjection;
using System.IdentityModel.Tokens.Jwt;

public class Startup
{
    private readonly IConfiguration _cfg;

    public Startup(IConfiguration configuration) => _cfg = configuration;

    public void ConfigureServices(IServiceCollection services)
    {


        //services.AddKeycloakAuthentication(authenticationOptions);


        //var authenticationProviderKey = "Bearer";
        //Action<JwtBearerOptions> options = (opt) =>
        //{
        //    opt.Authority = "http://tmp.doker.ru:8080";
        //    // ...
        //};

        //services
        //    .AddAuthentication()
        //    .AddJwtBearer(authenticationProviderKey, options);
        //services.AddOcelot();



        //JwtSecurityTokenHandler.DefaultMapInboundClaims = false;
        //services.AddAuthentication(options =>
        //{
        //    options.DefaultScheme = "Cookies";
        //    options.DefaultChallengeScheme = "oidc";
        //})
        //.AddCookie("Cookies")
        //.AddOpenIdConnect("oidc", options =>
        //{
        //    options.Authority = "https://localhost:5001";

        //    options.ClientId = "mvc";
        //    options.ClientSecret = "secret";
        //    options.ResponseType = "code";

        //    options.SaveTokens = true;
        //});

        //var identityUrl = _cfg.GetValue<string>("IdentityUrl");
        //var authenticationProviderKey = "IdentityApiKey";
        ////…
        //services.AddAuthentication()
        //    .AddJwtBearer(authenticationProviderKey, x =>
        //    {
        //        x.Authority = identityUrl;
        //        x.RequireHttpsMetadata = false;
        //        x.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters()
        //        {
        //            ValidAudiences = new[] { "orders", "basket", "locations", "marketing", "mobileshoppingagg", "webshoppingagg" }
        //        };
        //    });
        //...
    }
}
