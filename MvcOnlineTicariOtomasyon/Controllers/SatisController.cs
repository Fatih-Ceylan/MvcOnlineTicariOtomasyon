using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MvcOnlineTicariOtomasyon.Models.Classes.Context;
using MvcOnlineTicariOtomasyon.Models.Classes.Hareketler;

namespace MvcOnlineTicariOtomasyon.Controllers
{
    public class SatisController(OtomasyonContext c) : Controller
    {
        public IActionResult Index()
        {
            var degerler = c.SatisHareketleri.ToList();
            return View(degerler);
        }

        [HttpGet]
        public IActionResult YeniSatis()
        {
            List<SelectListItem> deger = (from x in c.Urun.ToList()
                                          select new SelectListItem
                                          {
                                              Text = x.UrunAdi,
                                              Value = x.UrunId.ToString()
                                          }).ToList();
            ViewBag.UrunList = deger;

            List<SelectListItem> deger2 = (from x in c.Cari.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.CariAd,
                                               Value = x.CariId.ToString()
                                           }).ToList();
            ViewBag.CariList = deger2;

            List<SelectListItem> deger3 = (from x in c.Personel.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.PersonelAd,
                                               Value = x.PersonelId.ToString()
                                           }).ToList();
            ViewBag.PersonelList = deger3;

            return View();
        }

        [HttpPost]
        public IActionResult YeniSatis(SatisHareket s)
        {
            s.Tarih = DateTime.Now;
            c.SatisHareketleri.Add(s);
            c.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult SatisGetir(int id)
        {
            var deger1 = c.SatisHareketleri.Find(id);

            List<SelectListItem> deger = (from x in c.Urun.ToList()
                                          select new SelectListItem
                                          {
                                              Text = x.UrunAdi,
                                              Value = x.UrunId.ToString()
                                          }).ToList();
            ViewBag.UrunList = deger;

            List<SelectListItem> deger2 = (from x in c.Cari.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.CariAd,
                                               Value = x.CariId.ToString()
                                           }).ToList();
            ViewBag.CariList = deger2;

            List<SelectListItem> deger3 = (from x in c.Personel.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.PersonelAd,
                                               Value = x.PersonelId.ToString()
                                           }).ToList();
            ViewBag.PersonelList = deger3;

            return View("SatisGetir", deger1);
        }

        public IActionResult SatisGuncelle(SatisHareket s)
        {
            var deger = c.SatisHareketleri.Find(s.SatisId);
            if (deger is not null)
            {
                deger.CariId = s.CariId;
                deger.UrunId = s.UrunId;
                deger.PersonelId = s.PersonelId;
                deger.Adet = s.Adet;
                deger.Fiyat = s.Fiyat;
                deger.ToplamTutar = s.ToplamTutar;
                deger.Tarih = s.Tarih;

                c.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        public IActionResult SatisDetay(int id)
        {
            var degerler = c.SatisHareketleri.Where(x => x.SatisId == id).ToList();

            return View(degerler);
        }

    }
}
