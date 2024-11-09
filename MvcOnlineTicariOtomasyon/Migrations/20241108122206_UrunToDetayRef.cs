using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MvcOnlineTicariOtomasyon.Migrations
{
    /// <inheritdoc />
    public partial class UrunToDetayRef : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UrunId",
                table: "Detay",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Detay_UrunId",
                table: "Detay",
                column: "UrunId");

            migrationBuilder.AddForeignKey(
                name: "FK_Detay_Urun_UrunId",
                table: "Detay",
                column: "UrunId",
                principalTable: "Urun",
                principalColumn: "UrunId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Detay_Urun_UrunId",
                table: "Detay");

            migrationBuilder.DropIndex(
                name: "IX_Detay_UrunId",
                table: "Detay");

            migrationBuilder.DropColumn(
                name: "UrunId",
                table: "Detay");
        }
    }
}
