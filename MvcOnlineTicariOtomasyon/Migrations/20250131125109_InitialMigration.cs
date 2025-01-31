using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MvcOnlineTicariOtomasyon.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admin",
                columns: table => new
                {
                    AdminId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KullaniciAd = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Sifre = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Yetki = table.Column<string>(type: "char(1)", maxLength: 1, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admin", x => x.AdminId);
                });

            migrationBuilder.CreateTable(
                name: "Cari",
                columns: table => new
                {
                    CariId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CariAd = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    CariSoyad = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    CariSehir = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    CariMail = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Durum = table.Column<bool>(type: "bit", nullable: false),
                    CariSifre = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cari", x => x.CariId);
                });

            migrationBuilder.CreateTable(
                name: "Departman",
                columns: table => new
                {
                    DepartmanId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmanAdi = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Durum = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departman", x => x.DepartmanId);
                });

            migrationBuilder.CreateTable(
                name: "Fatura",
                columns: table => new
                {
                    FaturaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FaturaSeriNo = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    FaturaSıraNo = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Tarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VergiDairesi = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    Saat = table.Column<string>(type: "Char(5)", maxLength: 5, nullable: true),
                    TeslimEden = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    TeslimAlan = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Toplam = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fatura", x => x.FaturaId);
                });

            migrationBuilder.CreateTable(
                name: "Gider",
                columns: table => new
                {
                    GiderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Aciklama = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Tarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Tutar = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gider", x => x.GiderId);
                });

            migrationBuilder.CreateTable(
                name: "KargoDetay",
                columns: table => new
                {
                    KargoDetayId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Aciklama = table.Column<string>(type: "nvarchar(300)", nullable: true),
                    TakipKodu = table.Column<string>(type: "nvarchar(10)", nullable: true),
                    Personel = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    Alici = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    Tarih = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KargoDetay", x => x.KargoDetayId);
                });

            migrationBuilder.CreateTable(
                name: "KargoTakip",
                columns: table => new
                {
                    KargoTakipId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TakipKodu = table.Column<string>(type: "nvarchar(10)", nullable: true),
                    Aciklama = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Tarih = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KargoTakip", x => x.KargoTakipId);
                });

            migrationBuilder.CreateTable(
                name: "Kategori",
                columns: table => new
                {
                    KategoriId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KategoriAd = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategori", x => x.KategoriId);
                });

            migrationBuilder.CreateTable(
                name: "Yapilacaklar",
                columns: table => new
                {
                    YapilacakId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Baslik = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Durum = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yapilacaklar", x => x.YapilacakId);
                });

            migrationBuilder.CreateTable(
                name: "Personel",
                columns: table => new
                {
                    PersonelId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonelAd = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    PersonelSoyad = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    PersonelGorsel = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    DepartmanId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personel", x => x.PersonelId);
                    table.ForeignKey(
                        name: "FK_Personel_Departman_DepartmanId",
                        column: x => x.DepartmanId,
                        principalTable: "Departman",
                        principalColumn: "DepartmanId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FaturaKalemleri",
                columns: table => new
                {
                    FaturaKalemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Aciklama = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Miktar = table.Column<int>(type: "int", nullable: false),
                    BirimFiyat = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Tutar = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FaturaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FaturaKalemleri", x => x.FaturaKalemId);
                    table.ForeignKey(
                        name: "FK_FaturaKalemleri_Fatura_FaturaId",
                        column: x => x.FaturaId,
                        principalTable: "Fatura",
                        principalColumn: "FaturaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Urun",
                columns: table => new
                {
                    UrunId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UrunAdi = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Marka = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Stok = table.Column<short>(type: "smallint", nullable: false),
                    AlisFiyat = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SatisFiyat = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Durum = table.Column<bool>(type: "bit", nullable: false),
                    UrunGorsel = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    KategoriId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Urun", x => x.UrunId);
                    table.ForeignKey(
                        name: "FK_Urun_Kategori_KategoriId",
                        column: x => x.KategoriId,
                        principalTable: "Kategori",
                        principalColumn: "KategoriId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Detay",
                columns: table => new
                {
                    DetayId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UrunAd = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    UrunBilgi = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    UrunId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Detay", x => x.DetayId);
                    table.ForeignKey(
                        name: "FK_Detay_Urun_UrunId",
                        column: x => x.UrunId,
                        principalTable: "Urun",
                        principalColumn: "UrunId");
                });

            migrationBuilder.CreateTable(
                name: "SatisHareketleri",
                columns: table => new
                {
                    SatisId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Adet = table.Column<int>(type: "int", nullable: false),
                    Fiyat = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ToplamTutar = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UrunId = table.Column<int>(type: "int", nullable: false),
                    CariId = table.Column<int>(type: "int", nullable: false),
                    PersonelId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SatisHareketleri", x => x.SatisId);
                    table.ForeignKey(
                        name: "FK_SatisHareketleri_Cari_CariId",
                        column: x => x.CariId,
                        principalTable: "Cari",
                        principalColumn: "CariId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SatisHareketleri_Personel_PersonelId",
                        column: x => x.PersonelId,
                        principalTable: "Personel",
                        principalColumn: "PersonelId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SatisHareketleri_Urun_UrunId",
                        column: x => x.UrunId,
                        principalTable: "Urun",
                        principalColumn: "UrunId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Detay_UrunId",
                table: "Detay",
                column: "UrunId");

            migrationBuilder.CreateIndex(
                name: "IX_FaturaKalemleri_FaturaId",
                table: "FaturaKalemleri",
                column: "FaturaId");

            migrationBuilder.CreateIndex(
                name: "IX_Personel_DepartmanId",
                table: "Personel",
                column: "DepartmanId");

            migrationBuilder.CreateIndex(
                name: "IX_SatisHareketleri_CariId",
                table: "SatisHareketleri",
                column: "CariId");

            migrationBuilder.CreateIndex(
                name: "IX_SatisHareketleri_PersonelId",
                table: "SatisHareketleri",
                column: "PersonelId");

            migrationBuilder.CreateIndex(
                name: "IX_SatisHareketleri_UrunId",
                table: "SatisHareketleri",
                column: "UrunId");

            migrationBuilder.CreateIndex(
                name: "IX_Urun_KategoriId",
                table: "Urun",
                column: "KategoriId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admin");

            migrationBuilder.DropTable(
                name: "Detay");

            migrationBuilder.DropTable(
                name: "FaturaKalemleri");

            migrationBuilder.DropTable(
                name: "Gider");

            migrationBuilder.DropTable(
                name: "KargoDetay");

            migrationBuilder.DropTable(
                name: "KargoTakip");

            migrationBuilder.DropTable(
                name: "SatisHareketleri");

            migrationBuilder.DropTable(
                name: "Yapilacaklar");

            migrationBuilder.DropTable(
                name: "Fatura");

            migrationBuilder.DropTable(
                name: "Cari");

            migrationBuilder.DropTable(
                name: "Personel");

            migrationBuilder.DropTable(
                name: "Urun");

            migrationBuilder.DropTable(
                name: "Departman");

            migrationBuilder.DropTable(
                name: "Kategori");
        }
    }
}
