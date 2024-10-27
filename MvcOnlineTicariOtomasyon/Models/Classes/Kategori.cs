using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcOnlineTicariOtomasyon.Models.Classes
{
    public class Kategori
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int KategoriId { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]

        public required string KategoriAd { get; set; }

        public ICollection<Urun>? Urun { get; set; }
    }
}
