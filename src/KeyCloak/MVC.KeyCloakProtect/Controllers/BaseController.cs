﻿using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace MVC.KeyCloakProtect.Controllers
{
    public class BaseController : Controller
    {
        public string AccessToken { get; private set; }

        public string IdToken { get; private set; }
        public BaseController()
        {

            GetTokens().Wait();
        }

        private async Task GetTokens()
        {
            if (User!= null && User.Identity.IsAuthenticated)
            {
                AccessToken = await HttpContext.GetTokenAsync("access_token");
                IdToken = await HttpContext.GetTokenAsync("id_token");
                var expire = await HttpContext.GetTokenAsync("expires_at");
            }
        }
    }
}
