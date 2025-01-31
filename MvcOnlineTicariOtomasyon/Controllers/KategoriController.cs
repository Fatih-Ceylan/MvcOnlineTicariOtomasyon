using Microsoft.AspNetCore.Mvc;
using MvcOnlineTicariOtomasyon.Data.Contexts;
using MvcOnlineTicariOtomasyon.Models.Classes;
using X.PagedList.Extensions;

namespace MvcOnlineTicariOtomasyon.Controllers
{
    public class KategoriController(OtomasyonContext context) : Controller
    {
        private readonly OtomasyonContext _context = context;

        public IActionResult Index(int sayfa = 1)
        {
            var values = _context.Kategori.ToList().ToPagedList(sayfa, 4);
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
            if (ModelState.IsValid)
            {
                _context.Add(k);
                _context.SaveChanges();
                return Json(new { success = true, message = "Kategori başarılı bir şekilde eklendi." });
            }
            else
            {
                return Json(new { success = false, message = "Eksik veya hatalı bilgi girdiniz." });
            }
        }

        public IActionResult KategoriSil(int id)
        {
            var kategori = _context.Kategori.Find(id);
            if (kategori is not null)
            {
                _context.Kategori.Remove(kategori);
                _context.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        public IActionResult KategoriGetir(int id)
        {
            var kategori = _context.Kategori.Find(id);

            return View("KategoriGetir", kategori);
        }

        public IActionResult KategoriGuncelle(Kategori k)
        {
            var kategori = _context.Kategori.Find(k.KategoriId);
            if (kategori is not null)
            {
                kategori.KategoriAd = k.KategoriAd;
                _context.SaveChanges();
            }

            return RedirectToAction("Index");
        }
    }
}
