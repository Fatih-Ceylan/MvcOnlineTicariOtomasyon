﻿using Microsoft.AspNetCore.Mvc;
using MvcOnlineTicariOtomasyon.Data.Contexts;

namespace MvcOnlineTicariOtomasyon.Controllers
{
    public class UrunDetayController : Controller
    {
        public OtomasyonContext c { get; set; }

        public UrunDetayController(OtomasyonContext c)
        {
            this.c = c;
        }

        public IActionResult Index()
        {
            var deger = c.Urun.ToList();
            return View(deger);
        }
    }
}
