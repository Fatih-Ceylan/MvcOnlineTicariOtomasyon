using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcOnlineTicariOtomasyon.Models.Classes.Faturalar
{
    public class Fatura
    {
        [Key]
        public int FaturaId { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(10)]
        public required string FaturaSeriNo { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public required string FaturaSıraNo { get; set; }
        public DateTime Tarih { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(60)]
        public  string? VergiDairesi { get; set; }
        public DateTime Saat { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string? TeslimEden { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string? TeslimAlan { get; set; }
        public ICollection<FaturaKalem>? FaturaKalemleri { get; set; }
    }
}
