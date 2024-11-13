using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MvcOnlineTicariOtomasyon.Models.Classes
{
    public class Yapilacak
    {
        [Key]
        public int YapilacakId { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(100)]
        public string? Baslik { get; set; }

        [Column(TypeName = "bit")]
        public bool Durum { get; set; }


    }
}
