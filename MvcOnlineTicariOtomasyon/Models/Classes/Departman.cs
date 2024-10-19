using System.ComponentModel.DataAnnotations;

namespace MvcOnlineTicariOtomasyon.Models.Classes
{
    public class Departman
    {
        [Key]
        public int DepartmanId { get; set; }
        public string? DepartmanAdi { get; set; }

        public ICollection<Personel> Personels { get; set; }
    }
}
