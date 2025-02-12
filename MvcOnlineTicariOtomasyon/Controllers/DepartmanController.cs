﻿using Microsoft.AspNetCore.Mvc;
using MvcOnlineTicariOtomasyon.Data.Contexts;
using MvcOnlineTicariOtomasyon.Models.Classes;

namespace MvcOnlineTicariOtomasyon.Controllers
{
    public class DepartmanController(OtomasyonContext c) : Controller
    {
        public IActionResult Index()
        {
            var values = c.Departman.Where(x => x.Durum).ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult DepartmanEkle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult DepartmanEkle(Departman d)
        {
            c.Departman.Add(d);
            c.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult DepartmanSil(int id)
        {
            var deger = c.Departman.Find(id);
            if (deger is not null)
            {
                deger.Durum = false;
                c.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        public IActionResult DepartmanGetir(int id)
        {
            var deptDeger = c.Departman.Find(id);

            return View("DepartmanGetir", deptDeger);
        }

        public IActionResult DepartmanGuncelle(Departman p)
        {
            var dept = c.Departman.Find(p.DepartmanId);
            if (dept is not null)
            {
                dept.DepartmanAdi = p.DepartmanAdi;
                dept.Durum = p.Durum;
            }
            c.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult DepartmanDetay(int id)
        {
            var detay = c.Personel.Where(x => x.DepartmanId == id).ToList();
            var dept = c.Departman.Where(x => x.DepartmanId == id).Select(y => y.DepartmanAdi).FirstOrDefault();
            ViewBag.Dpt = dept;

            return View(detay);
        }

        public IActionResult DepartmanPersonelSatis(int id)
        {
            var degerler = c.SatisHareketleri.Where(x => x.PersonelId == id).ToList();
            var per = c.Personel
                     .Where(x => x.PersonelId == id)
                     .Select(y => y.PersonelAd + " " + y.PersonelSoyad)
                     .FirstOrDefault();
            ViewBag.dptPers = per;

            return View(degerler);
        }
    }
}
