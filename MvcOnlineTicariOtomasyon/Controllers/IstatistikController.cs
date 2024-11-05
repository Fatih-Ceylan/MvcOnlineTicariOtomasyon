using Microsoft.AspNetCore.Mvc;
using MvcOnlineTicariOtomasyon.Models.Classes.Context;

namespace MvcOnlineTicariOtomasyon.Controllers
{
    public class IstatistikController : Controller
    {
        private OtomasyonContext c;

        public IstatistikController(OtomasyonContext c)
        {
            this.c = c;
        }

        public IActionResult Index()
        {
            var deger1 = c.Cari.Count();
            ViewBag.d1 = deger1;

            var deger2 = c.Urun.Count();
            ViewBag.d2 = deger2;

            var deger3 = c.Personel.Count();
            ViewBag.d3 = deger3;

            var deger4 = c.Kategori.Count();
            ViewBag.d4 = deger4;

            var deger5 = c.Urun.Sum(c => c.Stok);
            ViewBag.d5 = deger5;

            var deger6 = (from x in c.Urun select x.Marka).Distinct().Count().ToString();
            ViewBag.d6 = deger6;

            var deger7 = c.Urun.Count(x => x.Stok <= 20).ToString();
            ViewBag.d7 = deger7;


            var deger8 = (from x in c.Urun where x.Durum orderby x.SatisFiyat descending select x.UrunAdi).FirstOrDefault();
            /*(from x in c.Urun select x.SatisFiyat).Max();*/
            ViewBag.d8 = deger8;

            var deger9 = (from x in c.Urun where x.Durum orderby x.SatisFiyat ascending select x.UrunAdi).FirstOrDefault();
            ViewBag.d9 = deger9;

            var deger10 = c.Urun.Count(c => c.UrunAdi == "Buzdolabı").ToString();
            ViewBag.d10 = deger10;

            var deger11 = c.Urun.Count(c => c.UrunAdi == "Laptop").ToString();
            ViewBag.d11 = deger11;

            //En fazla ürün çeşidine sahip marka 
            var deger12 = c.Urun.GroupBy(x => x.Marka)
                .OrderByDescending(z => z.Count())
                .Select(y => y.Key)
                .FirstOrDefault();
            ViewBag.d12 = deger12;

            //En çok satılan ürün
            var deger13 = c.Urun.Where(u => u.UrunId == (c.SatisHareketleri
                .GroupBy(x => x.UrunId)
                .OrderByDescending(z => z.Count())
                .Select(y => y.Key)
                .FirstOrDefault()))
                .Select(k=>k.UrunAdi).FirstOrDefault();
            ViewBag.d13 = deger13;

            var deger14 = c.SatisHareketleri.Sum(c => c.ToplamTutar).ToString();
            ViewBag.d14 = deger14;

            DateTime bugun = DateTime.Today;
            var deger15 = c.SatisHareketleri.Count(c => c.Tarih == bugun).ToString();
            ViewBag.d15 = deger15;

            var deger16 = c.SatisHareketleri.Where(x => x.Tarih == bugun).Sum(c => c.ToplamTutar).ToString();
            ViewBag.d16 = deger16;

            return View();
        }
    }
}
