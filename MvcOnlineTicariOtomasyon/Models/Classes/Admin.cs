using System.ComponentModel.DataAnnotations;

namespace MvcOnlineTicariOtomasyon.Models.Classes
{
    public class Admin
    {
        [Key]
        public int AdminId { get; set; }
        public string KullaniciAd { get; set; }
        public string Sifre { get; set; }
        public string Yetki { get; set; }
    }
}
