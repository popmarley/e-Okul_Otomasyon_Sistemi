using Microsoft.EntityFrameworkCore.Migrations;

namespace OkulOtomasyonu.Migrations
{
    public partial class _3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OgretmenBranslari_Ogretmenler_OgretmenID",
                table: "OgretmenBranslari");

            migrationBuilder.DropIndex(
                name: "IX_OgretmenBranslari_OgretmenID",
                table: "OgretmenBranslari");

            migrationBuilder.DropColumn(
                name: "OgretmenID",
                table: "OgretmenBranslari");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OgretmenID",
                table: "OgretmenBranslari",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_OgretmenBranslari_OgretmenID",
                table: "OgretmenBranslari",
                column: "OgretmenID");

            migrationBuilder.AddForeignKey(
                name: "FK_OgretmenBranslari_Ogretmenler_OgretmenID",
                table: "OgretmenBranslari",
                column: "OgretmenID",
                principalTable: "Ogretmenler",
                principalColumn: "OgretmenID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
