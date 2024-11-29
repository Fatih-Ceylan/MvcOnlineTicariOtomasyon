using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcOnlineTicariOtomasyon.Models.Classes.Kargo
{
    public class KargoTakip
    {
        [Key]
        public int KargoTakipId { get; set; }

        [Column(TypeName ="nvarchar(10)")]
        public string? TakipKodu { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string? Aciklama { get; set; }

        public DateTime Tarih { get; set; }
    }
}
