using MvcOnlineTicariOtomasyon.Models.Classes.Hareketler;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcOnlineTicariOtomasyon.Models.Classes
{
    public class Cari
    {
        [Key]
        public int CariId { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string? CariAd { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string? CariSoyad { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(15)]
        public string? CariSehir { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string? CariMail { get; set; }

        public SatisHareket SatisHareket { get; set; }
    }
}
