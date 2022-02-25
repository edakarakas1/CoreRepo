using CoreRepo.Controllers.Repository;
using CoreRepo.Models.Entity;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CoreRepo.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        private ILoginRepository rep;
        public LoginController(ILoginRepository _rep)
        {
            rep = _rep;
        }
        public IActionResult Index()
        {
            return View();
        }
        //public IActionResult SignIn()
        //{
        //    return View();
        //}
        //public async Task<IActionResult> SignIn(string Kullanici, string Sifre)
        //{
        //    Admin a = rep.GetAdmin(Kullanici, Sifre);
        //    if (a != null)
        //    {
        //        var claims = new List<Claim>
        //        {
        //            new Claim(ClaimTypes.Name,a.KullaniciAdi)
        //        };
        //        var userIdentity = new ClaimsIdentity(claims, "Login");
        //        ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
        //        await HttpContext.SignInAsync(principal);
        //        return RedirectToAction("Index","Home");
        //    }
        //    return View();
        //}
        //public async Task<IActionResult> SignOut()
        //{
        //    await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
        //    return RedirectToAction("SignIn");
        //}
    }
}
