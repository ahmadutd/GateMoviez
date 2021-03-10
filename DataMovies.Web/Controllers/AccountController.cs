using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GateMoviez.Domain;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;


namespace GateMoviez.Web.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
        [AllowAnonymous]////برای کاربران معلمولی سایت که لاگین کردن
        [HttpGet]
        public IActionResult Login()
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Dashboard", "UserManagerAccount");


            }
            else
            {
                return View();

            }


        }



        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> PostLogin()
        {
            try
            {
                
                var email = HttpContext.Request.Form["Email"];
                var password = HttpContext.Request.Form["Password"];
                
                AppUser user = await _userManager.FindByEmailAsync(email);
                var result = await _signInManager.PasswordSignInAsync(user, password, false, false);
                if (result.Succeeded)
                {
                    
                    return RedirectToAction("Dashboard", "UserManagerAccount");


                }
                else
                {
                    return RedirectToAction("Login");
                }

                


            }
            catch (Exception)
            {

                ViewBag.Message = "Oparation Field";
            }
            return View();

        }
        [AllowAnonymous]
        [HttpGet]
        public IActionResult Register()
        {
            if(!User.Identity.IsAuthenticated)
            {
                return View(); 
            }
            else
            {
                return RedirectToAction("UserManagerAccount", "Dashboard");
            }


        }



        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> PostRegister()
        {
            try
            {
                var username = HttpContext.Request.Form["UserName"];              
                var email = HttpContext.Request.Form["Email"];
                var password = HttpContext.Request.Form["Password"];
                var ConfirmPassword = HttpContext.Request.Form["ConfirmPassword"];
                AppUser user = await _userManager.FindByEmailAsync(email);
                if(user!=null)
                {
                    ViewBag.Message = "ok nist";
                    return RedirectToAction("Register");
                }
               
                user = new AppUser
                {
                    UserName = username,
                    Email = email,
                    
                };
                IdentityResult result = await _userManager.CreateAsync(user, password);
                if (result.Succeeded)
                {
                    ViewBag.Message = "user creat";
                    return RedirectToAction("Dashboard", "UserManagerAccount");


                }
                else
                {
                    ViewBag.Message = "user creat error";
                    return RedirectToAction("Register");
                }

               
            }
            catch (Exception)
            {

                ViewBag.Message = "Oparation Field";
            }
            return View();

        }
        
    }
}
