using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MvcOnlineTicariOtomasyon.Migrations
{
    /// <inheritdoc />
    public partial class kargoTakipAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KargoDetay");

            migrationBuilder.DropTable(
                name: "KargoTakip");
        }
    }
}
