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

#if DEBUG
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
#endif          
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