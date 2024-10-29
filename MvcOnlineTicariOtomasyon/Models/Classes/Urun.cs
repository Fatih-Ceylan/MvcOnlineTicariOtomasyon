using MvcOnlineTicariOtomasyon.Models.Classes.Hareketler;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcOnlineTicariOtomasyon.Models.Classes
{
    public class Urun
    {
        [Key]
        public int UrunId { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string? UrunAdi { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string? Marka { get; set; }

        public short Stok { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal AlisFiyat { get; set; }

        [Column(TypeName = "decimal(18,2)")]

        public decimal SatisFiyat { get; set; }

        public bool Durum { get; set; } = true;

        [Column(TypeName = "Varchar")]
        [StringLength(250)]
        public string? UrunGorsel { get; set; }

        public int KategoriId { get; set; }
        public required virtual Kategori Kategori { get; set; }

        public virtual ICollection<SatisHareket>? SatisHareketleri { get; set; }
    }
}
