﻿using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using MvcOnlineTicariOtomasyon.Models.Classes;
using MvcOnlineTicariOtomasyon.Models.Classes.Context;
using System.Security.Claims;
using MvcOnlineTicariOtomasyon.Services;

namespace MvcOnlineTicariOtomasyon.Controllers
{
    public class LoginController(OtomasyonContext c, ClaimService cs, IHttpContextAccessor httpContextAccessor) : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult CariKayitPartial()
        {

            return PartialView();
        }

        [HttpPost]
        public IActionResult CariKayitPartial(Cari p)
        {
            if (!ModelState.IsValid)
            {
                return PartialView("CariKayitPartial", p); // Hatalar ile geri dön
            }

            c.Cari.Add(p);
            c.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult CariLoginPartial()
        {
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult CariLoginPartial(Cari p)
        {
            var bilgiler = c.Cari?.FirstOrDefault(x => x.CariMail == p.CariMail && x.CariSifre == p.CariSifre);
            if (bilgiler is not null)
            {
                var claimsIdentity = cs.CreateClaimsIdentity(bilgiler);

                // Kimlik doğrulama çerezi oluştur
                httpContextAccessor?.HttpContext?.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
                new ClaimsPrincipal(claimsIdentity));

                httpContextAccessor?.HttpContext?.Session?.SetString("cariMail", bilgiler?.CariMail ?? "");

                return Json(new { success = true, redirectUrl = Url.Action("Index", "CariPanel") });
            }

            ViewBag.Error = "Kullanıcı adı veya şifre yanlış";

            return PartialView("CariLoginPartial", p); // Hatalarla birlikte partial view döndür
        }
    }
}
