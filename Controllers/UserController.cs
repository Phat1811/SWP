using FluentValidation.Results;
using MedicalStore.Controllers.DTO;
using MedicalStore.DAO;
using MedicalStore.DAO.Interface;
using MedicalStore.Models;
using MedicalStore.Auth;
using MedicalStore.Utils.Common;
using MedicalStore.Utils.Locale;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Threading.Tasks;
using MedicalStore.Service.Interface;

namespace MedicalStore.Controllers
{
    [Route("user")]
    [ServiceFilter(typeof(AuthGuard))]
    public class UserController : Controller
    {
        private readonly IUserService UserService;

        public UserController(IUserService userService)
        {
            this.UserService = userService;
        }

        [HttpGet("updateinfo")]
        public IActionResult UpdateInfo() {
            User user = (User)this.ViewData["user"];
            return View(Routers.UpdateUserInfo.Page);
        }


        [HttpGet("password")]
        public IActionResult UpdatePassword()
        {
            Console.WriteLine("asdasd");
            return View(Routers.UpdatePassword.Page);
        }

        [HttpGet("profile")]
        public IActionResult UserProfile()
        {
            User user = (User)this.ViewData["user"];
            if (user == null)
            {
                return Redirect(Routers.Home.Link);
            }
            return View(Routers.UserProfile.Page);
        }
    }
}
