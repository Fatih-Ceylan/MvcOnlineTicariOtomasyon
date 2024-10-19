using System.ComponentModel.DataAnnotations;

namespace MvcOnlineTicariOtomasyon.Models.Classes.Faturalar
{
    public class Fatura
    {
        [Key]
        public int FaturaId { get; set; }
        public string FaturaSeriNo { get; set; }
        public string FaturaSıraNo { get; set; }
        public DateTime Tarih { get; set; }
        public string VergiDairesi { get; set; }
        public DateTime Saat { get; set; }
        public string TeslimEden { get; set; }
        public string TeslimAlan { get; set; }
        public ICollection<FaturaKalem> FaturaKalems { get; set; }
    }
}
