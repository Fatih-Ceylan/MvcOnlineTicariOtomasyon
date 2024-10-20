using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcOnlineTicariOtomasyon.Models.Classes.Hareketler
{
    public class SatisHareket
    {
        [Key]
        public int SatisId { get; set; }
        //ürün
        //cari
        //personel
        public DateTime Tarih { get; set; }
        public int Adet { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Fiyat { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal ToplamTutar { get; set; }

        public Urun? Urun { get; set; }
        public Cari? Cari { get; set; }
        public Personel? Personel { get; set; }
    }
}
