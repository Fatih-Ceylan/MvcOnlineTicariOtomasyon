﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcOnlineTicariOtomasyon.Models.Classes
{
    public class Gider
    {
        [Key]
        public int GiderId { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(100)]
        public string? Aciklama { get; set; }
        public DateTime Tarih { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Tutar { get; set; }
    }
}
