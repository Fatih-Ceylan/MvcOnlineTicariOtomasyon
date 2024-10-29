using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcOnlineTicariOtomasyon.Models.Classes.Faturalar
{
    public class FaturaKalem
    {
        [Key]
        public int FaturaKalemId { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(100)]
        public string? Aciklama { get; set; }

        public int Miktar { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal BirimFiyat { get; set; }


        [Column(TypeName = "decimal(18,2)")]
        public decimal Tutar { get; set; }

        public int FaturaId { get; set; }
        public required virtual Fatura Fatura { get; set; }
    }
}
