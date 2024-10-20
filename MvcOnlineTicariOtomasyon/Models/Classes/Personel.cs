using MvcOnlineTicariOtomasyon.Models.Classes.Hareketler;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcOnlineTicariOtomasyon.Models.Classes
{
    public class Personel
    {
        [Key]
        public int PersonelId { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string? PersonelAd { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string? PersonelSoyad { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(250)]

        public string? PersonelGorsel { get; set; }

        public ICollection<SatisHareket>? SatisHareketleri { get; set; }
        public Departman? Departman { get; set; }
    }
}
