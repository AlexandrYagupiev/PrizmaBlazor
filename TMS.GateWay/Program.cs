using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Ocelot.DependencyInjection;
using Ocelot.Middleware;
using Ocelot.Values;
using System.Diagnostics;
using System.Security.Claims;
using TMS.GateWay;

public class Program
{
    public static void Main(string[] args)
    {
        new WebHostBuilder()
        .UseKestrel()
        .UseContentRoot(Directory.GetCurrentDirectory())
        .ConfigureAppConfiguration((hostingContext, config) =>
        {
            config
                .SetBasePath(hostingContext.HostingEnvironment.ContentRootPath)
                .AddJsonFile("appsettings.json", true, true)
                .AddJsonFile($"appsettings.{hostingContext.HostingEnvironment.EnvironmentName}.json", true, true)
                .AddJsonFile("ocelot.json")
                .AddEnvironmentVariables();
        })
        .ConfigureServices(s => {

            s.AddTransient<IClaimsTransformation, ClaimsTransformer>();

            s.AddAuthentication()
            .AddJwtBearer("Keycloak", options =>
            {
                options.Authority = "http://tmp.doker.ru:8080/realms/Test2";
                options.Audience = "account";
                options.RequireHttpsMetadata = false;

                // Обработчик успешной валидации токена
                options.Events = new JwtBearerEvents
                {
                    OnTokenValidated = context =>
                    {
                        Debug.WriteLine($"JwtBearerEvents Token validated: {context.SecurityToken}");
                        return Task.CompletedTask;
                    },

                    // Обработчик при получении токена
                    OnMessageReceived = context =>
                    {
                        Debug.WriteLine($"JwtBearerEvents Token received: {context.Token}");
                        return Task.CompletedTask;
                    },

                    // Обработчик при ошибке аутентификации
                    OnAuthenticationFailed = context =>
                    {
                        Debug.WriteLine($"JwtBearerEvents Authentication failed: {context.Exception}");
                        return Task.CompletedTask;
                    },

                    OnForbidden = context =>
                    {
                        Debug.WriteLine($"JwtBearerEvents Authentication failed: ");
                        return Task.CompletedTask;
                    }
                };
               
            });


            //var keyCloakConfig = new KeycloakAuthenticationOptions
            //{
            //    Realm = "Test",
            //    AuthServerUrl = "http://tmp.doker.ru:8080/",
            //    SslRequired = "none",
            //};

            //s.AddKeycloakAuthentication(keyCloakConfig);

            //var authenticationProviderKey = "Bearer";
            //Action<JwtBearerOptions> options = (opt) =>
            //{
            //    opt.Authority = "https://sts.skoruba.local";
            //    opt.TokenValidationParameters = new TokenValidationParameters
            //    {
            //        ValidateAudience = false
            //    };
            //};
            //s.AddAuthentication()
            //    .AddJwtBearer(authenticationProviderKey, options);


            //var authenticationProviderKey = "Bearer";
            //Action<JwtBearerOptions> options = (opt) =>
            //{
            //    opt.Authority = "https://sts.skoruba.local";
            //    opt.TokenValidationParameters = new TokenValidationParameters
            //    {
            //        ValidateAudience = false
            //    };
            //};
            //s.AddAuthentication()
            //    .AddJwtBearer(authenticationProviderKey, options);



            // s.AddAuthentication("Bearer")
            //.AddJwtBearer("Bearer", options =>
            //{
            //    options.Authority = "https://sts.skoruba.local";

            //    options.TokenValidationParameters = new TokenValidationParameters
            //    {
            //        ValidateAudience = false
            //    };
            //});

            //var authenticationProviderKey = "TestKey";
            //Action<JwtBearerOptions> options = (opt) =>
            //{
            //    opt.Authority = "https://whereyouridentityserverlives.com";
            //    // ...
            //};
            //s.AddAuthentication()
            //    .AddJwtBearer(authenticationProviderKey, options);

            //s.AddAuthentication(options =>
            //{
            //    options.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
            //    options.DefaultChallengeScheme = OpenIdConnectDefaults.AuthenticationScheme;
            //})
            // .AddCookie(CookieAuthenticationDefaults.AuthenticationScheme)
            // .AddOpenIdConnect(OpenIdConnectDefaults.AuthenticationScheme, options =>
            // {
            //     options.Authority = "https://sts.skoruba.local/";

            //     options.ClientId = "shopping_web";
            //     options.ClientSecret = "secret";
            //     options.ResponseType = "code";

            //     options.Scope.Add("openid");
            //     options.Scope.Add("profile");
            //     options.SaveTokens = true;
            //     options.GetClaimsFromUserInfoEndpoint = true;
            // });

            s.AddOcelot();
        })
        .ConfigureLogging((hostingContext, logging) =>
        {
            //add your logging
        })
        .UseIISIntegration()
        .Configure(app =>
        {
            app.UseOcelot().Wait();
            app.UseDeveloperExceptionPage();
        })
        .Build()
        .Run();
    }
}