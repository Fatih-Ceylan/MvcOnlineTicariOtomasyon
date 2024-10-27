using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MvcOnlineTicariOtomasyon.Migrations
{
    /// <inheritdoc />
    public partial class KtgIdAddedToUrun : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Urun_Kategori_KategoriId",
                table: "Urun");

            migrationBuilder.AlterColumn<int>(
                name: "KategoriId",
                table: "Urun",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Urun_Kategori_KategoriId",
                table: "Urun",
                column: "KategoriId",
                principalTable: "Kategori",
                principalColumn: "KategoriId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Urun_Kategori_KategoriId",
                table: "Urun");

            migrationBuilder.AlterColumn<int>(
                name: "KategoriId",
                table: "Urun",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Urun_Kategori_KategoriId",
                table: "Urun",
                column: "KategoriId",
                principalTable: "Kategori",
                principalColumn: "KategoriId");
        }
    }
}
