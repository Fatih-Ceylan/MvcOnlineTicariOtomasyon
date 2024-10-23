using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using MvcOnlineTicariOtomasyon.Models.Classes.Faturalar;
using MvcOnlineTicariOtomasyon.Models.Classes.Hareketler;

namespace MvcOnlineTicariOtomasyon.Models.Classes.Context
{
    public class OtomasyonContext : DbContext
    {
        public OtomasyonContext(DbContextOptions<OtomasyonContext> options) : base(options)
        {
        }
        public DbSet<Admin> Admin { get; set; }
        public DbSet<Cari> Cari { get; set; }
        public DbSet<Departman> Departman { get; set; }
        public DbSet<Personel> Personel { get; set; }
        public DbSet<Fatura> Fatura { get; set; }
        public DbSet<FaturaKalem> FaturaKalemleri { get; set; }
        public DbSet<Gider> Gider { get; set; }
        public DbSet<SatisHareket> SatisHareketleri { get; set; }
        public DbSet<Urun> Urun { get; set; }
        public DbSet<Kategori> Kategori { get; set; }
    }
}
