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
        [StringLength(30, ErrorMessage = "İsim 30 karakterden uzun olamaz")]
        [Required(ErrorMessage = "İsim alanı boş geçilemez")]
        public required string CariAd { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30, ErrorMessage = "Soyisim 30 karakterden uzun olamaz")]
        public string? CariSoyad { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(15, ErrorMessage = "Şehir adı 15 karakterden uzun olamaz")]
        public string? CariSehir { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30, ErrorMessage = "Mail adresi 30 karakterden uzun olamaz")]
        public string? CariMail { get; set; }

        public bool Durum { get; set; } = true;

        [Column(TypeName = "Varchar")]
        [StringLength(15)]
        public string? CariSifre { get; set; }

        public virtual ICollection<SatisHareket>? SatisHareketleri { get; set; }
    }
}
