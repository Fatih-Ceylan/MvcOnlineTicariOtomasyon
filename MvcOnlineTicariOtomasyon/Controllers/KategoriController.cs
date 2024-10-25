﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcOnlineTicariOtomasyon.Models.Classes;
using MvcOnlineTicariOtomasyon.Models.Classes.Context;

namespace MvcOnlineTicariOtomasyon.Controllers
{
    public class KategoriController : Controller
    {
        private readonly OtomasyonContext _context;

        public KategoriController(OtomasyonContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var values = _context.Kategori.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult KategoriEkle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult KategoriEkle(Kategori k)
        {
            _context.Add(k);
            _context.SaveChanges();


            return RedirectToAction("Index");
        }

        public IActionResult KategoriSil(int id)
        {
            var kategori = _context.Kategori.Find(id);
            _context.Kategori.Remove(kategori);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult KategoriGetir(int id)
        {
            var kategori = _context.Kategori.Find(id);
            return View("KategoriGetir",kategori);
        }

        public IActionResult KategoriGuncelle(Kategori k)
        {
            var kategori = _context.Kategori.Find(k.KategoriId);
            kategori.KategoriAd = k.KategoriAd;
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
