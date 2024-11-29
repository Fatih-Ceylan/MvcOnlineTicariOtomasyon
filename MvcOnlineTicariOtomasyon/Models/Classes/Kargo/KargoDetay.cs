using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcOnlineTicariOtomasyon.Models.Classes.Kargo
{
    public class KargoDetay
    {
        [Key]
        public int KargoDetayId { get; set; }

        [Column(TypeName = "nvarchar(300)")]
        public string? Aciklama { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        public string? TakipKodu { get; set; }

        [Column(TypeName = "nvarchar(20)")]
        public string? Personel { get; set; }

        [Column(TypeName = "nvarchar(20)")]
        public string? Alici { get; set; }

        public DateTime Tarih { get; set; }
    }
}
