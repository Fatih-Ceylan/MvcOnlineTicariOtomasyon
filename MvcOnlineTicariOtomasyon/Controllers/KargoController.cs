using Microsoft.AspNetCore.Mvc;
using MvcOnlineTicariOtomasyon.Models.Classes;
using MvcOnlineTicariOtomasyon.Models.Classes.Context;
using MvcOnlineTicariOtomasyon.Models.Classes.Kargo;

namespace MvcOnlineTicariOtomasyon.Controllers
{
    public class KargoController(OtomasyonContext c) : Controller
    {
       
        public IActionResult Index()
        {
            var kargolar = c.KargoDetay.ToList();

            return View(kargolar);
        }

        [HttpGet]
        public IActionResult YeniKargo()
        {
            Random rnd = new Random();  


            return View();
        }

        [HttpPost]
        public IActionResult YeniKargo(KargoDetay d)
        {
            c.KargoDetay.Add(d);
            c.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
