using Microsoft.EntityFrameworkCore.Migrations;

namespace OkulOtomasyonu.Migrations
{
    public partial class _10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Deger",
                table: "Notlar");

            migrationBuilder.AddColumn<int>(
                name: "Performans",
                table: "Notlar",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Sinav1",
                table: "Notlar",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Sinav2",
                table: "Notlar",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Sozlu",
                table: "Notlar",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Performans",
                table: "Notlar");

            migrationBuilder.DropColumn(
                name: "Sinav1",
                table: "Notlar");

            migrationBuilder.DropColumn(
                name: "Sinav2",
                table: "Notlar");

            migrationBuilder.DropColumn(
                name: "Sozlu",
                table: "Notlar");

            migrationBuilder.AddColumn<float>(
                name: "Deger",
                table: "Notlar",
                type: "real",
                nullable: false,
                defaultValue: 0f);
        }
    }
}
