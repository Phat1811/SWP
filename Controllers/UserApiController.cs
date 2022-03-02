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
    [Route("/api/user")]
    [ServiceFilter(typeof(AuthGuard))]
    public class UserApiController : Controller
    {
        private readonly IUserRepository UserRepository;
        private readonly IAuthService AuthService;
        private readonly IUserService UserService;
        public UserApiController(IUserRepository userRepository, IAuthService AuthService, IUserService userService)
        {
            this.UserRepository = userRepository;
            this.AuthService = AuthService;
            this.UserService = userService;
        }
        [HttpPost("updateinfo")]
        public IActionResult HandleUpdateUserInfo([FromBody] UpdateUserDTO body)
        {
            var res = new ServerApiResponse<string>();

            ValidationResult result = new UpdateUserDTOValidator().Validate(body);
            if (!result.IsValid)
            {
                res.mapDetails(result);
                return new BadRequestObjectResult(res.getResponse());
            }

            User user = (User)this.ViewData["user"];



            user.Name = body.Name;
            user.Phone = body.Phone;
            user.Address = body.Address;
            user.Email = body.Email;



            this.UserRepository.UpdateUserInfoHandler(user);

            res.setMessage(CustomLanguageValidator.MessageKey.MESSAGE_UPDATE_SUCCESS);
            return new ObjectResult(res.getResponse());
        }
        [HttpPost("password")]
        public IActionResult HandleUpdatePassword([FromBody] ChangePasswordDTO body)
        {
            var res = new ServerApiResponse<string>();
            ValidationResult result = new ChangePasswordDTOValidator().Validate(body);
            if (!result.IsValid)
            {
                res.mapDetails(result);
                return new BadRequestObjectResult(res.getResponse());
            }

            User user = (User)this.ViewData["user"];
            bool checkPassword = AuthService.ComparePassword(body.Password, user.Password);
            if (!checkPassword)
            {
                res.setErrorMessage(CustomLanguageValidator.ErrorMessageKey.ERROR_OLD_PASSWORD_NOT_CORRECT);
                return new BadRequestObjectResult(res.getResponse());
            }
            if (!(body.NewPassword == body.ConfirmNewPassword))
            {
                res.setErrorMessage(CustomLanguageValidator.ErrorMessageKey.ERROR_OLD_PASSWORD_NOT_CORRECT);
                return new BadRequestObjectResult(res.getResponse());
            }
            user.Password = body.NewPassword;



            this.UserRepository.UpdatePasswordHandler(user);
            this.HttpContext.Response.Cookies.Append("auth-token", "", new CookieOptions()
            {
                Expires = DateTime.Now.AddDays(-1),
                SameSite = SameSiteMode.None,
                Secure = true

            });
            res.setMessage(CustomLanguageValidator.MessageKey.MESSAGE_UPDATE_SUCCESS);
            return new ObjectResult(res.getResponse());
        }

        [HttpPost("banUnban")]
        public IActionResult HandleManageAccount([FromBody] UpdateUserDTO body)
        {
            var res = new ServerApiResponse<string>();

            var user = UserRepository.GetUserById(body.UserId);
            if (user.Status == UserStatus.ACTIVE)
            {
                user.Status = UserStatus.INACTIVE;
            }
            else
            {
                user.Status = UserStatus.ACTIVE;
            }
            this.UserService.UpdateUserInfoHandler(user);

            res.setMessage(CustomLanguageValidator.MessageKey.MESSAGE_ADD_SUCCESS);
            return new ObjectResult(res.getResponse());
        }
    }
}
