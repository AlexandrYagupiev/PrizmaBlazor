using IdentityModel.Client;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using System.Diagnostics;
using System.Net;
using TMS.Web.Models;
using static IdentityModel.OidcConstants;
using static System.Formats.Asn1.AsnWriter;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


builder.Services.AddAuthentication(options =>
{
    options.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = OpenIdConnectDefaults.AuthenticationScheme;
})
.AddCookie(options =>
{    
    options.LoginPath = "/Account/LoginCallback";
    options.ExpireTimeSpan = new TimeSpan(0, 5, 0);
    options.Events = new CookieAuthenticationEvents
    {
        OnRedirectToLogin = async context =>
        {
            var expiresAt = context.Properties.GetTokenValue("expires_at");
            Debug.WriteLine($"TOKENINFO OnRedirectToLogin expiresAt:{expiresAt}");
        },
        OnValidatePrincipal = async context =>
        {
            var now = DateTimeOffset.UtcNow;
            var expiresAt = context.Properties.GetTokenValue("expires_at");
            var accessTokenExpiration = DateTimeOffset.Parse(expiresAt);
            var timeRemaining = accessTokenExpiration.Subtract(now);           
            var refreshThreshold = TimeSpan.FromMinutes(0);

            Debug.WriteLine($"TOKENINFO expiresAt:{expiresAt}, timeRemaining: {timeRemaining}");
            if (timeRemaining < refreshThreshold)
            {
                
                var refreshToken = context.Properties.GetTokenValue("refresh_token");
                // TODO: Get this HttpClient from a factory
                var response = await new HttpClient().RequestRefreshTokenAsync(new RefreshTokenRequest
                {
                    Address = "http://tmp.doker.ru:8080/realms/Test2/protocol/openid-connect/token",
                    ClientId = "test-client",
                    RefreshToken = refreshToken
                });

                Debug.WriteLine($"TOKENINFO response IsError:{response.IsError}");
                if (!response.IsError)
                {
                    var expiresInSeconds = response.ExpiresIn;
                    var updatedExpiresAt = DateTimeOffset.UtcNow.AddSeconds(expiresInSeconds);
                    context.Properties.UpdateTokenValue("expires_at", updatedExpiresAt.ToString());
                    context.Properties.UpdateTokenValue("access_token", response.AccessToken);
                    context.Properties.UpdateTokenValue("refresh_token", response.RefreshToken);

                    // Indicate to the cookie middleware that the cookie should be remade (since we have updated it)
                    context.ShouldRenew = true;
                }
                else
                {
                    context.RejectPrincipal();
                    await context.HttpContext.SignOutAsync();
                }
            }
        }
    };
})
.AddOpenIdConnect(options =>
{
    options.Authority = "http://tmp.doker.ru:8080/realms/Test2";
    options.ClientId = "test-client";
    options.ResponseType = "code";
    options.SaveTokens = true;
    options.Scope.Add("openid");
    options.Scope.Add("profile");
    options.RequireHttpsMetadata = false;
    options.CallbackPath = "/signin-oidc"; // Set the callback path
    options.SignedOutCallbackPath = "/signout-callback-oidc"; // Set the signout callback path
    options.TokenValidationParameters = new TokenValidationParameters
    {
        NameClaimType = "preferred_username",
        RoleClaimType = "roles"
    };
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
