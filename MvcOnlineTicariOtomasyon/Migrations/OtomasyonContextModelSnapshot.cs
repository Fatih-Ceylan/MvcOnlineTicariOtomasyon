﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MvcOnlineTicariOtomasyon.Models.Classes.Context;

#nullable disable

namespace MvcOnlineTicariOtomasyon.Migrations
{
    [DbContext(typeof(OtomasyonContext))]
    partial class OtomasyonContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MvcOnlineTicariOtomasyon.Models.Classes.Admin", b =>
                {
                    b.Property<int>("AdminId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AdminId"));

                    b.Property<string>("KullaniciAd")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar");

                    b.Property<string>("Sifre")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar");

                    b.Property<string>("Yetki")
                        .IsRequired()
                        .HasMaxLength(1)
                        .HasColumnType("char");

                    b.HasKey("AdminId");

                    b.ToTable("Admin");
                });

            modelBuilder.Entity("MvcOnlineTicariOtomasyon.Models.Classes.Cari", b =>
                {
                    b.Property<int>("CariId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CariId"));

                    b.Property<string>("CariAd")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar");

                    b.Property<string>("CariMail")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar");

                    b.Property<string>("CariSehir")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar");

                    b.Property<string>("CariSifre")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar");

                    b.Property<string>("CariSoyad")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar");

                    b.Property<bool>("Durum")
                        .HasColumnType("bit");

                    b.HasKey("CariId");

                    b.ToTable("Cari");
                });

            modelBuilder.Entity("MvcOnlineTicariOtomasyon.Models.Classes.Departman", b =>
                {
                    b.Property<int>("DepartmanId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DepartmanId"));

                    b.Property<string>("DepartmanAdi")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar");

                    b.Property<bool>("Durum")
                        .HasColumnType("bit");

                    b.HasKey("DepartmanId");

                    b.ToTable("Departman");
                });

            modelBuilder.Entity("MvcOnlineTicariOtomasyon.Models.Classes.Detay", b =>
                {
                    b.Property<int>("DetayId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DetayId"));

                    b.Property<string>("UrunAd")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar");

                    b.Property<string>("UrunBilgi")
                        .IsRequired()
                        .HasMaxLength(2000)
                        .HasColumnType("nvarchar");

                    b.Property<int?>("UrunId")
                        .HasColumnType("int");

                    b.HasKey("DetayId");

                    b.HasIndex("UrunId");

                    b.ToTable("Detay");
                });

            modelBuilder.Entity("MvcOnlineTicariOtomasyon.Models.Classes.Faturalar.Fatura", b =>
                {
                    b.Property<int>("FaturaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FaturaId"));

                    b.Property<string>("FaturaSeriNo")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar");

                    b.Property<string>("FaturaSıraNo")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar");

                    b.Property<string>("Saat")
                        .HasMaxLength(5)
                        .HasColumnType("Char");

                    b.Property<DateTime>("Tarih")
                        .HasColumnType("datetime2");

                    b.Property<string>("TeslimAlan")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar");

                    b.Property<string>("TeslimEden")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar");

                    b.Property<decimal>("Toplam")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("VergiDairesi")
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar");

                    b.HasKey("FaturaId");

                    b.ToTable("Fatura");
                });

            modelBuilder.Entity("MvcOnlineTicariOtomasyon.Models.Classes.Faturalar.FaturaKalem", b =>
                {
                    b.Property<int>("FaturaKalemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FaturaKalemId"));

                    b.Property<string>("Aciklama")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar");

                    b.Property<decimal>("BirimFiyat")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("FaturaId")
                        .HasColumnType("int");

                    b.Property<int>("Miktar")
                        .HasColumnType("int");

                    b.Property<decimal>("Tutar")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("FaturaKalemId");

                    b.HasIndex("FaturaId");

                    b.ToTable("FaturaKalemleri");

                    b.HasAnnotation("SqlServer:UseSqlOutputClause", false);
                });

            modelBuilder.Entity("MvcOnlineTicariOtomasyon.Models.Classes.Gider", b =>
                {
                    b.Property<int>("GiderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GiderId"));

                    b.Property<string>("Aciklama")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar");

                    b.Property<DateTime>("Tarih")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Tutar")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("GiderId");

                    b.ToTable("Gider");
                });

            modelBuilder.Entity("MvcOnlineTicariOtomasyon.Models.Classes.Hareketler.SatisHareket", b =>
                {
                    b.Property<int>("SatisId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SatisId"));

                    b.Property<int>("Adet")
                        .HasColumnType("int");

                    b.Property<int>("CariId")
                        .HasColumnType("int");

                    b.Property<decimal>("Fiyat")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("PersonelId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Tarih")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("ToplamTutar")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("UrunId")
                        .HasColumnType("int");

                    b.HasKey("SatisId");

                    b.HasIndex("CariId");

                    b.HasIndex("PersonelId");

                    b.HasIndex("UrunId");

                    b.ToTable("SatisHareketleri");

                    b.HasAnnotation("SqlServer:UseSqlOutputClause", false);
                });

            modelBuilder.Entity("MvcOnlineTicariOtomasyon.Models.Classes.Kargo.KargoDetay", b =>
                {
                    b.Property<int>("KargoDetayId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("KargoDetayId"));

                    b.Property<string>("Aciklama")
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("Alici")
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Personel")
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("TakipKodu")
                        .HasColumnType("nvarchar(10)");

                    b.Property<DateTime>("Tarih")
                        .HasColumnType("datetime2");

                    b.HasKey("KargoDetayId");

                    b.ToTable("KargoDetay");
                });

            modelBuilder.Entity("MvcOnlineTicariOtomasyon.Models.Classes.Kargo.KargoTakip", b =>
                {
                    b.Property<int>("KargoTakipId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("KargoTakipId"));

                    b.Property<string>("Aciklama")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("TakipKodu")
                        .HasColumnType("nvarchar(10)");

                    b.Property<DateTime>("Tarih")
                        .HasColumnType("datetime2");

                    b.HasKey("KargoTakipId");

                    b.ToTable("KargoTakip");
                });

            modelBuilder.Entity("MvcOnlineTicariOtomasyon.Models.Classes.Kategori", b =>
                {
                    b.Property<int>("KategoriId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("KategoriId"));

                    b.Property<string>("KategoriAd")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar");

                    b.HasKey("KategoriId");

                    b.ToTable("Kategori");
                });

            modelBuilder.Entity("MvcOnlineTicariOtomasyon.Models.Classes.Personel", b =>
                {
                    b.Property<int>("PersonelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PersonelId"));

                    b.Property<int>("DepartmanId")
                        .HasColumnType("int");

                    b.Property<string>("PersonelAd")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar");

                    b.Property<string>("PersonelGorsel")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar");

                    b.Property<string>("PersonelSoyad")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar");

                    b.HasKey("PersonelId");

                    b.HasIndex("DepartmanId");

                    b.ToTable("Personel");
                });

            modelBuilder.Entity("MvcOnlineTicariOtomasyon.Models.Classes.Urun", b =>
                {
                    b.Property<int>("UrunId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UrunId"));

                    b.Property<decimal>("AlisFiyat")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("Durum")
                        .HasColumnType("bit");

                    b.Property<int>("KategoriId")
                        .HasColumnType("int");

                    b.Property<string>("Marka")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar");

                    b.Property<decimal>("SatisFiyat")
                        .HasColumnType("decimal(18,2)");

                    b.Property<short>("Stok")
                        .HasColumnType("smallint");

                    b.Property<string>("UrunAdi")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar");

                    b.Property<string>("UrunGorsel")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar");

                    b.HasKey("UrunId");

                    b.HasIndex("KategoriId");

                    b.ToTable("Urun");
                });

            modelBuilder.Entity("MvcOnlineTicariOtomasyon.Models.Classes.Yapilacak", b =>
                {
                    b.Property<int>("YapilacakId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("YapilacakId"));

                    b.Property<string>("Baslik")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar");

                    b.Property<bool>("Durum")
                        .HasColumnType("bit");

                    b.HasKey("YapilacakId");

                    b.ToTable("Yapilacaklar");
                });

            modelBuilder.Entity("MvcOnlineTicariOtomasyon.Models.Classes.Detay", b =>
                {
                    b.HasOne("MvcOnlineTicariOtomasyon.Models.Classes.Urun", "Urun")
                        .WithMany("UrunDetay")
                        .HasForeignKey("UrunId");

                    b.Navigation("Urun");
                });

            modelBuilder.Entity("MvcOnlineTicariOtomasyon.Models.Classes.Faturalar.FaturaKalem", b =>
                {
                    b.HasOne("MvcOnlineTicariOtomasyon.Models.Classes.Faturalar.Fatura", "Fatura")
                        .WithMany("FaturaKalemleri")
                        .HasForeignKey("FaturaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Fatura");
                });

            modelBuilder.Entity("MvcOnlineTicariOtomasyon.Models.Classes.Hareketler.SatisHareket", b =>
                {
                    b.HasOne("MvcOnlineTicariOtomasyon.Models.Classes.Cari", "Cari")
                        .WithMany("SatisHareketleri")
                        .HasForeignKey("CariId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MvcOnlineTicariOtomasyon.Models.Classes.Personel", "Personel")
                        .WithMany("SatisHareketleri")
                        .HasForeignKey("PersonelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MvcOnlineTicariOtomasyon.Models.Classes.Urun", "Urun")
                        .WithMany("SatisHareketleri")
                        .HasForeignKey("UrunId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cari");

                    b.Navigation("Personel");

                    b.Navigation("Urun");
                });

            modelBuilder.Entity("MvcOnlineTicariOtomasyon.Models.Classes.Personel", b =>
                {
                    b.HasOne("MvcOnlineTicariOtomasyon.Models.Classes.Departman", "Departman")
                        .WithMany("Personels")
                        .HasForeignKey("DepartmanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Departman");
                });

            modelBuilder.Entity("MvcOnlineTicariOtomasyon.Models.Classes.Urun", b =>
                {
                    b.HasOne("MvcOnlineTicariOtomasyon.Models.Classes.Kategori", "Kategori")
                        .WithMany("Urun")
                        .HasForeignKey("KategoriId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kategori");
                });

            modelBuilder.Entity("MvcOnlineTicariOtomasyon.Models.Classes.Cari", b =>
                {
                    b.Navigation("SatisHareketleri");
                });

            modelBuilder.Entity("MvcOnlineTicariOtomasyon.Models.Classes.Departman", b =>
                {
                    b.Navigation("Personels");
                });

            modelBuilder.Entity("MvcOnlineTicariOtomasyon.Models.Classes.Faturalar.Fatura", b =>
                {
                    b.Navigation("FaturaKalemleri");
                });

            modelBuilder.Entity("MvcOnlineTicariOtomasyon.Models.Classes.Kategori", b =>
                {
                    b.Navigation("Urun");
                });

            modelBuilder.Entity("MvcOnlineTicariOtomasyon.Models.Classes.Personel", b =>
                {
                    b.Navigation("SatisHareketleri");
                });

            modelBuilder.Entity("MvcOnlineTicariOtomasyon.Models.Classes.Urun", b =>
                {
                    b.Navigation("SatisHareketleri");

                    b.Navigation("UrunDetay");
                });
#pragma warning restore 612, 618
        }
    }
}
