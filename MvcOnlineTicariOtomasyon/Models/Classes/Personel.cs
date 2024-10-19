using MvcOnlineTicariOtomasyon.Models.Classes.Hareketler;
using System.ComponentModel.DataAnnotations;

namespace MvcOnlineTicariOtomasyon.Models.Classes
{
    public class Personel
    {
        [Key]
        public int PersonelId { get; set; }
        public string? PersonelAd { get; set; }
        public string? PersonelSoyad { get; set; }
        public string? PersonelGorsel { get; set; }

        public SatisHareket SatisHareket { get; set; }
        public Departman Departman { get; set; }
    }
}
