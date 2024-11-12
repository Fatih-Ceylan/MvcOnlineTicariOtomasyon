using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MvcOnlineTicariOtomasyon.Models.Classes;
using MvcOnlineTicariOtomasyon.Models.Classes.Context;

namespace MvcOnlineTicariOtomasyon.Controllers
{
    public class PersonelController : Controller
    {
        private readonly OtomasyonContext c;

        public PersonelController(OtomasyonContext c)
        {
            this.c = c;
        }

        public IActionResult Index()
        {
            var degerler = c.Personel.ToList();
            return View(degerler);
        }

        [HttpGet]
        public IActionResult PersonelEkle()
        {
            List<SelectListItem> deger = (from x in c.Departman.ToList()
                                          select new SelectListItem
                                          {
                                              Text = x.DepartmanAdi,
                                              Value = x.DepartmanId.ToString()
                                          }).ToList();
            ViewBag.departmanList = deger;

            return View();
        }

        [HttpPost]
        public IActionResult PersonelEkle(Personel p)
        {
            c.Personel.Add(p);
            c.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult PersonelGetir(int id)
        {
            var pers = c.Personel.Find(id);

            List<SelectListItem> deger = (from x in c.Departman.ToList()
                                          select new SelectListItem
                                          {
                                              Text = x.DepartmanAdi,
                                              Value = x.DepartmanId.ToString()
                                          }).ToList();
            ViewBag.departmanList = deger;

            return View("PersonelGetir", pers);
        }

        public IActionResult PersonelGuncelle(Personel p)
        {
            var pers = c.Personel.Find(p.PersonelId);
            if (pers is not null)
            {
                pers.PersonelAd = p.PersonelAd;
                pers.PersonelSoyad = p.PersonelSoyad;
                pers.PersonelGorsel = p.PersonelGorsel;
                pers.DepartmanId = p.DepartmanId;
                c.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        public IActionResult PersonelListe()
        {
            var sorgu = c.Personel.ToList();

            return View(sorgu);
        }

    }
}
