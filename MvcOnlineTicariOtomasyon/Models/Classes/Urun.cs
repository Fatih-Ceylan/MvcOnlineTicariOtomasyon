using MvcOnlineTicariOtomasyon.Models.Classes.Hareketler;
using System.ComponentModel.DataAnnotations;

namespace MvcOnlineTicariOtomasyon.Models.Classes
{
    public class Urun
    {
        [Key]
        public int UrunId { get; set; }
        
        public string UrunAdi { get; set; }

        public string Marka { get; set; }

        public short Stok { get; set; }

        public decimal AlisFiyat { get; set; }

        public decimal SatisFiyat { get; set; }

        public bool Durum { get; set; }

        public string? UrunGorsel { get; set; }

        public Kategori Kategori { get; set; }
        public SatisHareket SatisHareket { get; set; }
    }
}
