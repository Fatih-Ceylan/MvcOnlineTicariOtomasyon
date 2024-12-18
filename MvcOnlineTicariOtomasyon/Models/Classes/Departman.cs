﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcOnlineTicariOtomasyon.Models.Classes
{
    public class Departman
    {
        [Key]
        public int DepartmanId { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(30)]
        public string? DepartmanAdi { get; set; }

        public bool Durum { get; set; } = true;

        public virtual ICollection<Personel>? Personels { get; set; }
    }
}
