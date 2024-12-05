using Microsoft.AspNetCore.Mvc;
using MvcOnlineTicariOtomasyon.Models.Classes;
using MvcOnlineTicariOtomasyon.Models.Classes.Context;

namespace MvcOnlineTicariOtomasyon.Controllers
{
    public class CariController(OtomasyonContext c) : Controller
    {
        private readonly OtomasyonContext c = c;

        public IActionResult Index()
        {
            var cariler = c.Cari.Where(x => x.Durum).ToList();

            return View(cariler);
        }

        public IActionResult YeniCari()
        {
            return View();
        }

        [HttpPost]
        public IActionResult YeniCari(Cari cari)
        {
            c.Cari.Add(cari);
            c.SaveChanges();


            return RedirectToAction("Index");
        }

        public IActionResult CariSil(int id)
        {
            var deger = c.Cari.Find(id);
            if (deger is not null)
            {
                deger.Durum = false;
                c.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        public IActionResult CariGetir(int id)
        {
            var cari = c.Cari.Find(id);

            return View("CariGetir", cari);
        }

        public IActionResult CariGuncelle(Cari cari)
        {
            if (!ModelState.IsValid)
            {
                return View("CariGetir");
            }

            var car = c.Cari.Find(cari.CariId);
            if (car is not null)
            {
                car.CariAd = cari.CariAd;
                car.CariSoyad = cari.CariSoyad;
                car.CariMail = cari.CariMail;
                car.CariSehir = cari.CariSehir;
                car.Durum = cari.Durum;
            }
            c.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult MusteriSatis(int id)
        {
            var deger = c.SatisHareketleri.Where(x => x.CariId == id).ToList();
            var cr = c.Cari.Where(x => x.CariId == id).Select(y => y.CariAd + " " + y.CariSoyad).FirstOrDefault();
            ViewBag.cari = cr;

            return View(deger);
        }
    }
}
