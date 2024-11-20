using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcOnlineTicariOtomasyon.Models.Classes.Faturalar
{
    public class Fatura
    {
        [Key]
        public int FaturaId { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(10)]
        public required string FaturaSeriNo { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(30)]
        public required string FaturaSıraNo { get; set; }
        public DateTime Tarih { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(60)]
        public string? VergiDairesi { get; set; }

        [Column(TypeName = "Char")]
        [StringLength(5)]
        public string? Saat { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(30)]
        public string? TeslimEden { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(30)]
        public string? TeslimAlan { get; set; }

        [Precision(18, 2)]
        public decimal Toplam { get; set; }

        public virtual ICollection<FaturaKalem>? FaturaKalemleri { get; set; }
    }
}
