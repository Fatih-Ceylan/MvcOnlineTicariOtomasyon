using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MvcOnlineTicariOtomasyon.Models.Classes;
using MvcOnlineTicariOtomasyon.Models.Classes.Context;
using MvcOnlineTicariOtomasyon.Models.Classes.Hareketler;

namespace MvcOnlineTicariOtomasyon.Controllers
{
    public class UrunController(OtomasyonContext c) : Controller
    {
        public IActionResult Index(string p)
        {
            var urunler = c.Urun.Where(x => x.Durum).ToList();
            if (!string.IsNullOrEmpty(p))
            {
                var uruns = urunler
                            .Where(x => x.UrunAdi != null &&
                             x.UrunAdi.Contains(p, StringComparison.OrdinalIgnoreCase))
                            .ToList();

                return View(uruns);
            }
            return View(urunler);
        }

        [HttpGet]
        public IActionResult YeniUrun()
        {
            List<SelectListItem> deger = (from x in c.Kategori.ToList()
                                          select new SelectListItem
                                          {
                                              Text = x.KategoriAd,
                                              Value = x.KategoriId.ToString()
                                          }).ToList();
            ViewBag.kategoriList = deger;
            return View();
        }

        [HttpPost]
        public IActionResult YeniUrun(Urun p)
        {

            c.Urun.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult UrunSil(int id)
        {
            var deger = c.Urun.Find(id);
            if (deger is not null)
            {
                deger.Durum = false;
                c.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        public IActionResult UrunGetir(int id)
        {
            var urunDeger = c.Urun.Find(id);

            List<SelectListItem> ktgList = (from x in c.Kategori.ToList()
                                            select new SelectListItem
                                            {
                                                Text = x.KategoriAd,
                                                Value = x.KategoriId.ToString()
                                            }).ToList();
            ViewBag.kategoriList = ktgList;

            return View("UrunGetir", urunDeger);
        }

        public IActionResult UrunGuncelle(Urun p)
        {
            var urun = c.Urun.Find(p.UrunId);
            if (urun is not null)
            {
                urun.UrunAdi = p.UrunAdi;
                urun.Marka = p.Marka;
                urun.UrunGorsel = p.UrunGorsel;
                urun.AlisFiyat = p.AlisFiyat;
                urun.SatisFiyat = p.SatisFiyat;
                urun.Stok = p.Stok;
                urun.Durum = p.Durum;
                urun.KategoriId = p.KategoriId;

            }
            c.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult UrunListesi()
        {
            var degerler = c.Urun.ToList();

            return View(degerler);
        }

        [HttpGet]
        public IActionResult SatisYap(int id)
        {
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

            var urunId = c.Urun.Find(id)?.UrunId;
            ViewBag.UrunId = urunId;

            return View();
        }

        [HttpPost]
        public IActionResult SatisYap(SatisHareket p)
        {
            return View();
        }
    }
}
