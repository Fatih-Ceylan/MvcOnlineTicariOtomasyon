using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MvcOnlineTicariOtomasyon.Migrations
{
    /// <inheritdoc />
    public partial class DetayAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Detay",
                columns: table => new
                {
                    DetayId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UrunAd = table.Column<string>(type: "Varchar(30)", maxLength: 30, nullable: false),
                    UrunBilgi = table.Column<string>(type: "Varchar(2000)", maxLength: 2000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Detay", x => x.DetayId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Detay");
        }
    }
}
