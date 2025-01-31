using Microsoft.AspNetCore.Mvc;
using MvcOnlineTicariOtomasyon.Data.Contexts;

namespace MvcOnlineTicariOtomasyon.Controllers
{
    public class YapilacakController(OtomasyonContext c) : Controller
    {
        public IActionResult Index()
        {
            var deger1 = c.Cari.Count().ToString();
            ViewBag.d1 = deger1;

            var deger2 = c.Urun.Count().ToString();
            ViewBag.d2 = deger2;

            var deger3 = c.Kategori.Count().ToString();
            ViewBag.d3 = deger3;

            var deger4 = (from x in c.Cari select x.CariSehir).Distinct().Count().ToString();
            ViewBag.d4 = deger4;

            var yapilacaklar = c.Yapilacaklar.ToList();

            return View(yapilacaklar);
        }
    }
}
