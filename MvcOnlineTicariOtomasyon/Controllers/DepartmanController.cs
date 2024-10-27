using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MvcOnlineTicariOtomasyon.Models.Classes;
using MvcOnlineTicariOtomasyon.Models.Classes.Context;

namespace MvcOnlineTicariOtomasyon.Controllers
{
    public class DepartmanController : Controller
    {
        private readonly OtomasyonContext c;

        public DepartmanController(OtomasyonContext c)
        {
            this.c = c;
        }

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
            deger.Durum = false;
            c.SaveChanges();

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


            return View();
        }
    }
}
