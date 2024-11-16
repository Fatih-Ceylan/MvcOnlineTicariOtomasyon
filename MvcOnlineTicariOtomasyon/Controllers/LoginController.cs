using Microsoft.AspNetCore.Mvc;
using MvcOnlineTicariOtomasyon.Models.Classes;
using MvcOnlineTicariOtomasyon.Models.Classes.Context;

namespace MvcOnlineTicariOtomasyon.Controllers
{
    public class LoginController(OtomasyonContext c) : Controller
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
    }
}
