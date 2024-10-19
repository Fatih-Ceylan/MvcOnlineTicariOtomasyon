using System.ComponentModel.DataAnnotations;

namespace MvcOnlineTicariOtomasyon.Models.Classes.Faturalar
{
    public class FaturaKalem
    {
        [Key]
        public int FaturaKalemId { get; set; }
        public string? Aciklama { get; set; }
        public int Miktar { get; set; }
        public decimal BirimFiyat { get; set; }
        public decimal Tutar { get; set; }
    }
}
