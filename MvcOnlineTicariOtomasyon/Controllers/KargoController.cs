using Microsoft.AspNetCore.Mvc;
using MvcOnlineTicariOtomasyon.Models.Classes;
using MvcOnlineTicariOtomasyon.Models.Classes.Context;
using MvcOnlineTicariOtomasyon.Models.Classes.Kargo;

namespace MvcOnlineTicariOtomasyon.Controllers
{
    public class KargoController(OtomasyonContext c) : Controller
    {
       
        public IActionResult Index(string p)
        {
            var k = c.KargoDetay.ToList();
            if (!string.IsNullOrEmpty(p))
            {
                var kargolar = k
                            .Where(x => x.TakipKodu != null &&
                             x.TakipKodu.Contains(p, StringComparison.OrdinalIgnoreCase))
                            .ToList();

                return View(kargolar);
            }
            return View(k);
        }

        [HttpGet]
        public IActionResult YeniKargo()
        {
            var chars = "ABCDEFG0123456789";
            var stringChars = new char[10];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            var finalString = new String(stringChars);

            ViewBag.TakipNo = finalString;
            return View();
        }

        [HttpPost]
        public IActionResult YeniKargo(KargoDetay d)
        {
            c.KargoDetay.Add(d);
            c.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult KargoDetay(int id)
        {
            var detay = c.KargoTakip.Where(x => x.KargoTakipId == id).ToList();
             
            return View(detay);
        }
    }
}
