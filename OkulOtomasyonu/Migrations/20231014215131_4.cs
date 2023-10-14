using Microsoft.EntityFrameworkCore.Migrations;

namespace OkulOtomasyonu.Migrations
{
    public partial class _4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SinifID",
                table: "Ogretmenler",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Ogretmenler_SinifID",
                table: "Ogretmenler",
                column: "SinifID");

            migrationBuilder.AddForeignKey(
                name: "FK_Ogretmenler_Siniflar_SinifID",
                table: "Ogretmenler",
                column: "SinifID",
                principalTable: "Siniflar",
                principalColumn: "SinifID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ogretmenler_Siniflar_SinifID",
                table: "Ogretmenler");

            migrationBuilder.DropIndex(
                name: "IX_Ogretmenler_SinifID",
                table: "Ogretmenler");

            migrationBuilder.DropColumn(
                name: "SinifID",
                table: "Ogretmenler");
        }
    }
}
