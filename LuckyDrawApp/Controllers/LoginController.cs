using JwtAuthenticationHelper.Abstractions;
using LuckyDrawApp.Models;
using LuckyDrawApp.Models.Repository;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace LuckyDrawApp.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        private readonly IJwtTokenGenerator tokenGenerator;
        private readonly IConfiguration _configuration;
        public LoginController(IJwtTokenGenerator tokenGenerator, IConfiguration configuration)
        {
            this.tokenGenerator = tokenGenerator;
            this._configuration = configuration;
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> LoginAccount(LoginViewModel model, string returnUrl = null)
        {
            try
            {
                string Server = _configuration.GetConnectionString("SQL_LUCKY_DRAW");
                AccountModel acc = LoginRepository.Login(model.UserName, model.Password, Server);
                if (acc != null && acc.Code != null)
                {
                    var accessTokenResult = tokenGenerator.GenerateAccessTokenWithClaimsPrincipal(
                        acc.UserName,
                        GetUserClaims(acc));

                    await HttpContext.SignInAsync(accessTokenResult.ClaimsPrincipal,
                        accessTokenResult.AuthProperties);

                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    TempData["msg"] = "* Tên đăng nhập hoặc mật khẩu không đúng";
                }
            }
            catch (System.Exception ex)
            {
            }
            return View("Index");
        }
        private static IEnumerable<Claim> GetUserClaims(AccountModel acc)
        {
            IEnumerable<Claim> claims = new Claim[]
            {
                new Claim(ClaimTypes.Name, acc.UserName),
                new Claim("ID", acc.ID.ToString()),
                new Claim("Code", acc.Code),
            };
            return claims;
        }

        [HttpPost]

        public IActionResult Logout()
        {

            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);


            return RedirectToAction("Index", "Login");

        }

    }
}
