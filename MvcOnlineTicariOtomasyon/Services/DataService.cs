using MvcOnlineTicariOtomasyon.Models.Classes;
using MvcOnlineTicariOtomasyon.Models.Classes.Context;
using MvcOnlineTicariOtomasyon.Models.PartialClasses;

namespace MvcOnlineTicariOtomasyon.Services
{
    public class DataService(OtomasyonContext c)
    {
        public List<SinifGrup> GetSehirGruplari()
        {
            return (from x in c.Cari
                    group x by x.CariSehir into g
                    select new SinifGrup
                    {
                        Sehir = g.Key,
                        Sayi = g.Count()
                    }).ToList();
        }

        public List<SinifGrup2> GetDepartmanGruplari()
        {
            return (from x in c.Personel
                    group x by x.Departman.DepartmanAdi into g
                    select new SinifGrup2
                    {
                        DepartmanAdi = g.Key,
                        Sayi = g.Count()
                    }).ToList();
        }

        public List<Cari> GetCariListesi()
        {
            return c.Cari.ToList();
        }

        public List<Urun> GetUrunListesi()
        {
            return c.Urun.ToList();
        }

        public List<SinifGrup3> GetMarkaListesi()
        {
            return (from x in c.Urun
                    group x by x.Marka into g
                    select new SinifGrup3
                    {
                        Marka = g.Key,
                        Sayi = g.Count()
                    }).ToList();
        }
 
    }
}
