using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MvcOnlineTicariOtomasyon.Models.Classes;
using MvcOnlineTicariOtomasyon.Models.Classes.Context;

namespace MvcOnlineTicariOtomasyon.Controllers
{
    public class UrunController : Controller
    {
        private readonly OtomasyonContext c;

        public UrunController(OtomasyonContext c)
        {
            this.c = c;
        }

        public IActionResult Index()
        {
            var urunler = c.Urun.Include(k => k.Kategori).Where(x => x.Durum).ToList();
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
            deger.Durum = false;
            c.SaveChanges();

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

    }
}
