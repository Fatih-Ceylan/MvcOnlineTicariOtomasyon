using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MvcOnlineTicariOtomasyon.Migrations
{
    /// <inheritdoc />
    public partial class addFKToSatHar : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SatisHareketleri_Cari_CariId",
                table: "SatisHareketleri");

            migrationBuilder.DropForeignKey(
                name: "FK_SatisHareketleri_Personel_PersonelId",
                table: "SatisHareketleri");

            migrationBuilder.DropForeignKey(
                name: "FK_SatisHareketleri_Urun_UrunId",
                table: "SatisHareketleri");

            migrationBuilder.AlterColumn<int>(
                name: "UrunId",
                table: "SatisHareketleri",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PersonelId",
                table: "SatisHareketleri",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CariId",
                table: "SatisHareketleri",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_SatisHareketleri_Cari_CariId",
                table: "SatisHareketleri",
                column: "CariId",
                principalTable: "Cari",
                principalColumn: "CariId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SatisHareketleri_Personel_PersonelId",
                table: "SatisHareketleri",
                column: "PersonelId",
                principalTable: "Personel",
                principalColumn: "PersonelId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SatisHareketleri_Urun_UrunId",
                table: "SatisHareketleri",
                column: "UrunId",
                principalTable: "Urun",
                principalColumn: "UrunId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SatisHareketleri_Cari_CariId",
                table: "SatisHareketleri");

            migrationBuilder.DropForeignKey(
                name: "FK_SatisHareketleri_Personel_PersonelId",
                table: "SatisHareketleri");

            migrationBuilder.DropForeignKey(
                name: "FK_SatisHareketleri_Urun_UrunId",
                table: "SatisHareketleri");

            migrationBuilder.AlterColumn<int>(
                name: "UrunId",
                table: "SatisHareketleri",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "PersonelId",
                table: "SatisHareketleri",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CariId",
                table: "SatisHareketleri",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_SatisHareketleri_Cari_CariId",
                table: "SatisHareketleri",
                column: "CariId",
                principalTable: "Cari",
                principalColumn: "CariId");

            migrationBuilder.AddForeignKey(
                name: "FK_SatisHareketleri_Personel_PersonelId",
                table: "SatisHareketleri",
                column: "PersonelId",
                principalTable: "Personel",
                principalColumn: "PersonelId");

            migrationBuilder.AddForeignKey(
                name: "FK_SatisHareketleri_Urun_UrunId",
                table: "SatisHareketleri",
                column: "UrunId",
                principalTable: "Urun",
                principalColumn: "UrunId");
        }
    }
}
