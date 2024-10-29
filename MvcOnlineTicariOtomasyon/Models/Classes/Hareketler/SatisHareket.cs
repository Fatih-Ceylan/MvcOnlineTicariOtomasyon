using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcOnlineTicariOtomasyon.Models.Classes.Hareketler
{
    public class SatisHareket
    {
        [Key]
        public int SatisId { get; set; }

        public DateTime Tarih { get; set; }

        public int Adet { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Fiyat { get; set; }


        [Column(TypeName = "decimal(18,2)")]
        public decimal ToplamTutar { get; set; }

        public int UrunId { get; set; }
        public virtual required Urun Urun { get; set; }

        public int CariId { get; set; }
        public virtual required Cari Cari { get; set; }

        public int PersonelId { get; set; }
        public virtual required Personel Personel { get; set; }
    }
}
