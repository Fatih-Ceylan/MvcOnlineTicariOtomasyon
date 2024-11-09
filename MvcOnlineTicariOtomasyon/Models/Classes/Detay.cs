using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcOnlineTicariOtomasyon.Models.Classes
{
    public class Detay
    {
        [Key]
        public int DetayId { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public required string UrunAd { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(2000)]
        public required string UrunBilgi { get; set; }

        public virtual int? UrunId { get; set; }
        public virtual Urun? Urun { get; set; }

    }
}
