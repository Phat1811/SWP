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

        [HttpGet("info")]
        public IActionResult UpdateInfo()
        {
            User user = (User)this.ViewData["user"];
            return View(Routers.UpdateUserInfo.Page);
        }


        [HttpGet("password")]
        public IActionResult UpdatePassword()
        {

            return View(Routers.UpdatePassword.Page);
        }
    }
}
