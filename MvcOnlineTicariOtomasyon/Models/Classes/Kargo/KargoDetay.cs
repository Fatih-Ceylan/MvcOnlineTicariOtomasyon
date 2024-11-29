namespace MvcOnlineTicariOtomasyon.Models.Classes.Kargo
{
    public class KargoDetay
    {
        public int KargoDetayId { get; set; }
        public string? Aciklama { get; set; }
        public string? TakipKodu { get; set; }
        public string? Personel { get; set; }
        public string? Alici { get; set; }
        public DateTime Tarih { get; set; }
    }
}
