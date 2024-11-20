using MvcOnlineTicariOtomasyon.Models.Classes.Hareketler;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcOnlineTicariOtomasyon.Models.Classes
{
    public class Personel
    {
        [Key]
        public int PersonelId { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(30)]
        [DisplayName("Personel Adı")]
        public string? PersonelAd { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(30)]
        [DisplayName("Personel Soyadı")]

        public string? PersonelSoyad { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(250)]
        [DisplayName("Personel Görsel")]
        public string? PersonelGorsel { get; set; }

        public virtual ICollection<SatisHareket>? SatisHareketleri { get; set; }

        public int DepartmanId { get; set; }
        public virtual required Departman Departman { get; set; }
    }
}
