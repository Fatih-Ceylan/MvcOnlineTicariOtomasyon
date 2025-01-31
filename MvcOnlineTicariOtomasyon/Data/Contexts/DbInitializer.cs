using Microsoft.EntityFrameworkCore;
using MvcOnlineTicariOtomasyon.Models.Classes.Hareketler;
using MvcOnlineTicariOtomasyon.Models.Classes;

namespace MvcOnlineTicariOtomasyon.Data.Contexts
{
    public class DbInitializer
    {
        public static void Seed(OtomasyonContext context)
        {
            if (!context.Departman.Any())
            {
                var departmanlar = new List<Departman>
                {
                    new Departman { DepartmanAdi = "Satış", Durum = true },
                    new Departman { DepartmanAdi = "Destek", Durum = true },
                    new Departman { DepartmanAdi = "Muhasebe", Durum = true }
                };
                context.Departman.AddRange(departmanlar);
                context.SaveChanges();
            }

            if (!context.Kategori.Any())
            {
                var kategoriler = new List<Kategori>
                {
                    new Kategori { KategoriAd = "Elektronik" },
                    new Kategori { KategoriAd = "Ev Aletleri" },
                    new Kategori { KategoriAd = "Mobilya" }
                };
                context.Kategori.AddRange(kategoriler);
                context.SaveChanges();
            }

            if (!context.Urun.Any())
            {
                var kategoriler = context.Kategori.ToList();

                var urunler = new List<Urun>
                {
                    new Urun
                    {
                        UrunAdi = "Laptop", Marka = "Asus", Stok = 15,
                        AlisFiyat = 12000, SatisFiyat = 15000,
                        Durum = true, UrunGorsel = "laptop.jpg",
                        Kategori = kategoriler.First()
                    },
                    new Urun
                    {
                        UrunAdi = "Buzdolabı", Marka = "Arçelik", Stok = 10,
                        AlisFiyat = 8000, SatisFiyat = 10000,
                        Durum = true, UrunGorsel = "buzdolabi.jpg",
                        Kategori = kategoriler.Skip(1).First()
                    },
                    new Urun
                    {
                        UrunAdi = "Çamaşır Makinesi", Marka = "Arçelik", Stok = 10,
                        AlisFiyat = 12000, SatisFiyat = 15000,
                        Durum = true, UrunGorsel = "makine.jpg",
                        Kategori = kategoriler.Skip(2).First()
                    },
                    new Urun
                    {
                        UrunAdi = "Telefon", Marka = "Samsung", Stok = 30,
                        AlisFiyat = 5000, SatisFiyat = 6500,
                        Durum = true, UrunGorsel = "telefon.jpg",
                        Kategori = kategoriler.First()
                    },
                    new Urun
                    {
                        UrunAdi = "Yatak", Marka = "İstikbal", Stok = 20,
                        AlisFiyat = 2000, SatisFiyat = 3000,
                        Durum = true, UrunGorsel = "yatak.jpg",
                        Kategori = kategoriler.Skip(2).First()
                    }
                };

                context.Urun.AddRange(urunler);
                context.SaveChanges();
            }

            if (!context.Detay.Any())
            {
                var urunler = context.Urun.ToList();

                var detaylar = new List<Detay>
                {
                    new Detay { UrunId = urunler.First().UrunId, UrunAd = "Laptop", UrunBilgi = "16GB RAM, 512GB SSD, Intel i7" },
                    new Detay { UrunId = urunler.Skip(1).First().UrunId, UrunAd = "Buzdolabı", UrunBilgi = "No-Frost, 500 Litre, Enerji Sınıfı A+" },
                    new Detay { UrunId = urunler.Skip(2).First().UrunId, UrunAd = "Çamaşır Makinesi", UrunBilgi = "A+ Enerji, 7 kg Kapasite" },
                    new Detay { UrunId = urunler.Skip(3).First().UrunId, UrunAd = "Telefon", UrunBilgi = "6GB RAM, 128GB Hafıza, 48MP Kamera" },
                    new Detay { UrunId = urunler.Skip(4).First().UrunId, UrunAd = "Yatak", UrunBilgi = "King Size, Ortopedik" }
                };
                context.Detay.AddRange(detaylar);
                context.SaveChanges();
            }

            if (!context.Cari.Any())
            {
                var cariler = new List<Cari>
                {
                    new Cari { CariAd = "Ali", CariSoyad = "Yılmaz", CariSehir = "İstanbul", CariMail = "ali.yilmaz@example.com", CariSifre = "12345", Durum = true },
                    new Cari { CariAd = "Ayşe", CariSoyad = "Demir", CariSehir = "Ankara", CariMail = "ayse.demir@example.com", CariSifre = "abcdef", Durum = true },
                    new Cari { CariAd = "Mehmet", CariSoyad = "Kara", CariSehir = "İzmir", CariMail = "mehmet.kara@example.com", CariSifre = "password123", Durum = true },
                    new Cari { CariAd = "Zeynep", CariSoyad = "Şahin", CariSehir = "Bursa", CariMail = "zeynep.sahin@example.com", CariSifre = "qwerty123", Durum = true },
                    new Cari { CariAd = "Ahmet", CariSoyad = "Çelik", CariSehir = "Antalya", CariMail = "ahmet.celik@example.com", CariSifre = "654321", Durum = true }
                };
                context.Cari.AddRange(cariler);
                context.SaveChanges();
            }

            if (!context.Personel.Any())
            {
                var departmanlar = context.Departman.ToList();

                var personeller = new List<Personel>
                {
                   new Personel
                    {
                        PersonelAd = "Baran", PersonelSoyad = "Kılıç",
                        PersonelGorsel = "baran.jpg",
                        Departman = departmanlar.First()
                    },
                    new Personel
                    {
                        PersonelAd = "Duru", PersonelSoyad = "Demirtaş",
                        PersonelGorsel = "duru.jpg",
                        Departman = departmanlar.Skip(1).First()
                    },
                    new Personel
                    {
                        PersonelAd = "Efe", PersonelSoyad = "Yüce",
                        PersonelGorsel = "efe.jpg",
                        Departman = departmanlar.Skip(2).First()
                    },
                    new Personel
                    {
                        PersonelAd = "Seda", PersonelSoyad = "Özdemir",
                        PersonelGorsel = "seda.jpg",
                        Departman = departmanlar.Skip(1).First()
                    },
                    new Personel
                    {
                        PersonelAd = "Can", PersonelSoyad = "Çetin",
                        PersonelGorsel = "can.jpg",
                        Departman = departmanlar.First()
                    }
                };

                context.Personel.AddRange(personeller);
                context.SaveChanges();
            }

            if (!context.SatisHareketleri.Any())
            {
                var urunler = context.Urun.ToList();
                var cariler = context.Cari.ToList();
                var personeller = context.Personel.ToList();

                var satisHareketleri = new List<SatisHareket>
                {
                    new SatisHareket
                    {
                        Tarih = DateTime.Now, Adet = 2,
                        Fiyat = urunler.First().SatisFiyat,
                        ToplamTutar = 2 * urunler.First().SatisFiyat,
                        Urun = urunler.First(),
                        Cari = cariler.First(),
                        Personel = personeller.First()
                    },
                    new SatisHareket
                    {
                        Tarih = DateTime.Now, Adet = 1,
                        Fiyat = urunler.Skip(1).First().SatisFiyat,
                        ToplamTutar = urunler.Skip(1).First().SatisFiyat,
                        Urun = urunler.Skip(1).First(),
                        Cari = cariler.Skip(1).First(),
                        Personel = personeller.First()
                    },
                    new SatisHareket
                    {
                        Tarih = DateTime.Now, Adet = 2,
                        Fiyat = urunler.Skip(2).First().SatisFiyat,
                        ToplamTutar = 2 * urunler.Skip(2).First().SatisFiyat,
                        Urun = urunler.Skip(2).First(),
                        Cari = cariler.Skip(2).First(),
                        Personel = personeller.Skip(1).First()
                    },
                    new SatisHareket
                    {
                        Tarih = DateTime.Now, Adet = 1,
                        Fiyat = urunler.Skip(3).First().SatisFiyat,
                        ToplamTutar = urunler.Skip(3).First().SatisFiyat,
                        Urun = urunler.Skip(3).First(),
                        Cari = cariler.Skip(3).First(),
                        Personel = personeller.Skip(1).First()
                    },
                    new SatisHareket
                    {
                        Tarih = DateTime.Now, Adet = 3,
                        Fiyat = urunler.Skip(4).First().SatisFiyat,
                        ToplamTutar = 3 * urunler.Skip(4).First().SatisFiyat,
                        Urun = urunler.Skip(4).First(),
                        Cari = cariler.Skip(4).First(),
                        Personel = personeller.Skip(2).First()
                    },
                    new SatisHareket
                    {
                        Tarih = DateTime.Now, Adet = 1,
                        Fiyat = urunler.First().SatisFiyat,
                        ToplamTutar = urunler.First().SatisFiyat,
                        Urun = urunler.First(),
                        Cari = cariler.Skip(1).First(),
                        Personel = personeller.Skip(2).First()
                    },
                    new SatisHareket
                    {
                        Tarih = DateTime.Now, Adet = 2,
                        Fiyat = urunler.Skip(1).First().SatisFiyat,
                        ToplamTutar = 2 * urunler.Skip(1).First().SatisFiyat,
                        Urun = urunler.Skip(1).First(),
                        Cari = cariler.Skip(2).First(),
                        Personel = personeller.Skip(3).First()
                    },
                    new SatisHareket
                    {
                        Tarih = DateTime.Now, Adet = 3,
                        Fiyat = urunler.Skip(2).First().SatisFiyat,
                        ToplamTutar = 3 * urunler.Skip(2).First().SatisFiyat,
                        Urun = urunler.Skip(2).First(),
                        Cari = cariler.Skip(3).First(),
                        Personel = personeller.Skip(3).First()
                    },
                    new SatisHareket
                    {
                        Tarih = DateTime.Now, Adet = 1,
                        Fiyat = urunler.Skip(3).First().SatisFiyat,
                        ToplamTutar = urunler.Skip(3).First().SatisFiyat,
                        Urun = urunler.Skip(3).First(),
                        Cari = cariler.Skip(4).First(),
                        Personel = personeller.Skip(4).First()
                    },
                    new SatisHareket
                    {
                        Tarih = DateTime.Now, Adet = 2,
                        Fiyat = urunler.Skip(4).First().SatisFiyat,
                        ToplamTutar = 2 * urunler.Skip(4).First().SatisFiyat,
                        Urun = urunler.Skip(4).First(),
                        Cari = cariler.First(),
                        Personel = personeller.Skip(4).First()
                    }
                };

                context.SatisHareketleri.AddRange(satisHareketleri);
                context.SaveChanges();
            }
        }
    }
}
