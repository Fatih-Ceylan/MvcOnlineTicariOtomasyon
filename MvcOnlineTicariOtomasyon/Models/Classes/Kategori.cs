using System.ComponentModel.DataAnnotations;

namespace MvcOnlineTicariOtomasyon.Models.Classes
{
    public class Kategori
    {
        [Key]
        public int KategoriId { get; set; }

        public string KategoriAd { get; set; }

        public ICollection<Urun> Urun { get; set; }
    }
}
