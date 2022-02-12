using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Data;
using System.Security.Claims;
using C200_Official.Models;
using Microsoft.AspNetCore.Authorization;
using System.Collections.Generic;



namespace Healthy_You_And_Me_V2.Controllers
{
    [Authorize(AuthenticationSchemes = "HealthyScheme")]
    public class AccountController : Controller
    {
        private const string AUTHSCHEME = "HealthyScheme";
        private const string LOGIN_SQL =
        @"SELECT * FROM Member
WHERE Username = '{0}'
AND Password = HASHBYTES('SHA1', '{1}')";



        private const string LASTLOGIN_SQL =
        @"UPDATE Member SET LastLogin=GETDATE()
WHERE Username='{0}'";



        private const string ROLE_COL = "Role";
        private const string NAME_COL = "FirstName";



        private const string REDIRECT_CNTR = "Home";
        private const string REDIRECT_ACTN = "Index";



        private const string LOGIN_VIEW = "Login";



        [AllowAnonymous]
        public IActionResult Login(string returnUrl = null)
        {
            TempData["ReturnUrl"] = returnUrl;
            return View(LOGIN_VIEW);
        }



        [AllowAnonymous]
        [HttpPost]
        public IActionResult Login(LoginUser user)
        {
            if (!AuthenticateUser(user.Username, user.Password, out ClaimsPrincipal principal))
            {
                ViewData["Message"] = "Incorrect Username or Password.";
                ViewData["MsgType"] = "warning";
                return View(LOGIN_VIEW);
            }
            else
            {
                HttpContext.SignInAsync(
                AUTHSCHEME,
                principal,
                new AuthenticationProperties
                {
                    IsPersistent = user.RememberMe
                });



                // Update the Last Login Timestamp of the User
                DBUtl.ExecSQL(LASTLOGIN_SQL, user.Username);


                if (TempData["returnUrl"] != null)
                {
                    string returnUrl = TempData["returnUrl"].ToString();
                    if (Url.IsLocalUrl(returnUrl))
                        return Redirect(returnUrl);
                }


                return RedirectToAction(REDIRECT_ACTN, REDIRECT_CNTR);
            }
        }


        [Authorize]
        public IActionResult Logoff(string returnUrl = null)
        {
            HttpContext.SignOutAsync(AUTHSCHEME);
            if (Url.IsLocalUrl(returnUrl))
                return Redirect(returnUrl);
            return RedirectToAction(REDIRECT_ACTN, REDIRECT_CNTR);
        }

        [AllowAnonymous]
        public IActionResult Forbidden()
        {
            return View();
        }

        private bool AuthenticateUser(string uid, string pw, out ClaimsPrincipal principal)
        {
            principal = null;



            DataTable ds = DBUtl.GetTable(LOGIN_SQL, uid, pw);
            if (ds.Rows.Count == 1)
            {
                principal =
                new ClaimsPrincipal(
                new ClaimsIdentity(
                new Claim[] {
new Claim(ClaimTypes.NameIdentifier, ds.Rows[0]["Id"].ToString()),
new Claim(ClaimTypes.Name, ds.Rows[0][NAME_COL].ToString()),
new Claim(ClaimTypes.Role, ds.Rows[0][ROLE_COL].ToString())
                }, "Basic"
                )
                );
                return true;
            }
            return false;
        }
    }
}