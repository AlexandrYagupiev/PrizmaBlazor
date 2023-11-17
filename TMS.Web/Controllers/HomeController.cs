using IdentityModel.Client;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using Newtonsoft.Json;
using System;
using System.Data;
using System.Diagnostics;
using TMS.Web.Models;

namespace TMS.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        static HttpClient httpClient = new HttpClient();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<string> IndexAsync(int id)
        {
            var text = "empty";
            if (id == 1)
            {
                text = await httpClient.GetStringAsync("https://localhost:7280/Operations/index");
            }
            if (id == 2)
            {
                text = await httpClient.GetStringAsync("https://localhost:7280/Scheme/index");
            }
            
            return text;
        }

        [Route("index2")]
        public async Task<string> Index2Async(int id)
        {
            var text = "empty";
            var accessToken = await AuthenticationHttpContextExtensions.GetTokenAsync(
HttpContext, OpenIdConnectParameterNames.AccessToken);
            using (var client = new HttpClient())
            {
                client.SetBearerToken(accessToken);
                text = await client.GetStringAsync("https://localhost:7280/Operations/index");

                if (id == 1)
                {
                    text = await client.GetStringAsync("https://localhost:7280/Operations/index");
                }
                if (id == 2)
                {
                    text = await client.GetStringAsync("https://localhost:7280/Scheme/index");
                }

            }

            return text;
        }

        [Authorize]
        [Route("index3")]
        public async Task<string> Index3Async(int id)
        {
            
            var text = "empty";            
            
            var accessToken = await AuthenticationHttpContextExtensions.GetTokenAsync(
    HttpContext, OpenIdConnectParameterNames.AccessToken);

          
            using (var client = new HttpClient())
            {
                client.SetBearerToken(accessToken);

                if (id == 1)
                {
                    text = await client.GetStringAsync("https://localhost:7280/Operations/index");
                }
                if (id == 2)
                {
                    text = await client.GetStringAsync("https://localhost:7280/Operations/index2");
                }
                if (id == 3)
                {
                    text = await client.GetStringAsync("https://localhost:7280/Operations/index3");
                }
            }

            return text;
        }

    }
}