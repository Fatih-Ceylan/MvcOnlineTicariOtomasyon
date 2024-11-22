using Microsoft.AspNetCore.Mvc;
using MvcOnlineTicariOtomasyon.Models.Classes.Context;
using MvcOnlineTicariOtomasyon.Models.Classes.Faturalar;

namespace MvcOnlineTicariOtomasyon.Controllers
{
    public class FaturaController : Controller
    {
        private readonly OtomasyonContext c;

        public FaturaController(OtomasyonContext c)
        {
            this.c = c;
        }

        public IActionResult Index()
        {
            var degerler = c.Fatura.ToList();
            return View(degerler);
        }

        [HttpGet]
        public IActionResult FaturaEkle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult FaturaEkle(Fatura f)
        {
            c.Fatura.Add(f);
            c.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult FaturaGetir(int id)
        {
            var fatura = c.Fatura.Find(id);

            return View("FaturaGetir", fatura);
        }

        public IActionResult FaturaGuncelle(Fatura f)
        {
            var fatura = c.Fatura.Find(f.FaturaId);
            if (fatura is not null)
            {
                fatura.FaturaSeriNo = f.FaturaSeriNo;
                fatura.FaturaSıraNo = f.FaturaSıraNo;
                fatura.Saat = f.Saat;
                fatura.Tarih = f.Tarih;
                fatura.VergiDairesi = f.VergiDairesi;
                fatura.TeslimAlan = f.TeslimAlan;

                c.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        public IActionResult FaturaDetay(int id)
        {
            var fatura = c.FaturaKalemleri.Where(x => x.FaturaId == id).ToList();
            return View(fatura);
        }

        [HttpGet]
        public IActionResult GetFaturaDetails(int id)
        {
            var faturaKalem = c.FaturaKalemleri
                               .Where(x => x.FaturaId == id)
                               .Select(x => new
                               {
                                   x.Aciklama,
                                   x.Miktar,
                                   x.BirimFiyat,
                                   x.Tutar
                               }).ToList();
            
            return Json(faturaKalem);
        }

        [HttpGet]
        public IActionResult YeniKalem(int? id)
        {
            int faturaId = c.Fatura.Where(x=>x.FaturaId == id).Select(y=>y.FaturaId).FirstOrDefault();
            ViewBag.FaturaId = faturaId;

            return View();
        }

        public IActionResult YeniKalem(FaturaKalem f)
        {
            var faturaKalemList = c.FaturaKalemleri.Where(x => x.FaturaKalemId == f.FaturaKalemId).ToList();
            //var fatura = c.FaturaKalemleri.Where(x => x.FaturaKalemId == f.FaturaKalemId).Select(y => y.FaturaId).FirstOrDefault();
            //ViewBag.Fatura = fatura;
            c.FaturaKalemleri.Add(f);
            c.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
