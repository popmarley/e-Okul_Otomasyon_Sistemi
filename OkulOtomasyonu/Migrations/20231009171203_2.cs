using Microsoft.EntityFrameworkCore.Migrations;

namespace OkulOtomasyonu.Migrations
{
    public partial class _2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kullanicilar_KullaniciTipleri_KullaniciTipiTipID",
                table: "Kullanicilar");

            migrationBuilder.DropIndex(
                name: "IX_Kullanicilar_KullaniciTipiTipID",
                table: "Kullanicilar");

            migrationBuilder.DropColumn(
                name: "KullaniciTipiTipID",
                table: "Kullanicilar");

            migrationBuilder.CreateIndex(
                name: "IX_Kullanicilar_TipID",
                table: "Kullanicilar",
                column: "TipID");

            migrationBuilder.AddForeignKey(
                name: "FK_Kullanicilar_KullaniciTipleri_TipID",
                table: "Kullanicilar",
                column: "TipID",
                principalTable: "KullaniciTipleri",
                principalColumn: "TipID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kullanicilar_KullaniciTipleri_TipID",
                table: "Kullanicilar");

            migrationBuilder.DropIndex(
                name: "IX_Kullanicilar_TipID",
                table: "Kullanicilar");

            migrationBuilder.AddColumn<int>(
                name: "KullaniciTipiTipID",
                table: "Kullanicilar",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Kullanicilar_KullaniciTipiTipID",
                table: "Kullanicilar",
                column: "KullaniciTipiTipID");

            migrationBuilder.AddForeignKey(
                name: "FK_Kullanicilar_KullaniciTipleri_KullaniciTipiTipID",
                table: "Kullanicilar",
                column: "KullaniciTipiTipID",
                principalTable: "KullaniciTipleri",
                principalColumn: "TipID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
