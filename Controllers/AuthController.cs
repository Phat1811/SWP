
using MedicalStore.Auth;
using MedicalStore.DAO.Interface;
using MedicalStore.Models;
using MedicalStore.Utils.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace MedicalStore.Controllers
{

        [Route("auth")]
        [ServiceFilter(typeof(UserFilter))]
        public class AuthController : Controller
        {
            private readonly IAuthService AuthService;

            public AuthController(IAuthService authService)
            {
                this.AuthService = authService;
            }

            [HttpGet("login")]
            public IActionResult Login()
            {
                var user = (User)this.ViewData["user"];
                if (user != null)
                {
                    return Redirect(Routers.CommonGetHome.Link);
                }
                return View(Routers.AuthPostLogin.Page);
            }


            [HttpGet("register")]
            public IActionResult Register()
            {
                var user = (User)this.ViewData["user"];
                if (user != null)
                {
                    return Redirect(Routers.CommonGetHome.Link);
                }
                return View(Routers.AuthPostRegister.Page);
            }

            [HttpGet("logout")]
            public IActionResult Logout()
            {

                this.HttpContext.Response.Cookies.Append("auth-token", "", new CookieOptions()
                {
                    Expires = DateTime.Now.AddDays(-1),
                    SameSite = SameSiteMode.None,
                    Secure = true

                });
                this.HttpContext.Session.Clear();
                return Redirect(Routers.AuthPostLogin.Link + "?message=logout success");
            }



    }
}
