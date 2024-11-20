using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcOnlineTicariOtomasyon.Models.Classes
{
    public class Admin
    {
        [Key]
        public int AdminId { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(30)]
        public required string KullaniciAd { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(30)]
        public required string Sifre { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public required string Yetki { get; set; }
    }
}
