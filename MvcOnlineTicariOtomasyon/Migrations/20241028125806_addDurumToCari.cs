﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MvcOnlineTicariOtomasyon.Migrations
{
    /// <inheritdoc />
    public partial class addDurumToCari : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Durum",
                table: "Cari",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Durum",
                table: "Cari");
        }
    }
}
