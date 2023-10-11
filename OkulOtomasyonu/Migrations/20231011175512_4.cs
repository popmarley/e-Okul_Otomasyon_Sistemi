using Microsoft.EntityFrameworkCore.Migrations;

namespace OkulOtomasyonu.Migrations
{
    public partial class _4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OgretmenID",
                table: "Dersler",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "OgrenciDersleri",
                columns: table => new
                {
                    OgrenciDersID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DersAdi = table.Column<string>(nullable: true),
                    OgrenciID = table.Column<int>(nullable: false),
                    DersID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OgrenciDersleri", x => x.OgrenciDersID);
                    table.ForeignKey(
                        name: "FK_OgrenciDersleri_Dersler_DersID",
                        column: x => x.DersID,
                        principalTable: "Dersler",
                        principalColumn: "DersID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OgrenciDersleri_Ogrenciler_OgrenciID",
                        column: x => x.OgrenciID,
                        principalTable: "Ogrenciler",
                        principalColumn: "OgrenciID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Dersler_OgretmenID",
                table: "Dersler",
                column: "OgretmenID");

            migrationBuilder.CreateIndex(
                name: "IX_OgrenciDersleri_DersID",
                table: "OgrenciDersleri",
                column: "DersID");

            migrationBuilder.CreateIndex(
                name: "IX_OgrenciDersleri_OgrenciID",
                table: "OgrenciDersleri",
                column: "OgrenciID");

            migrationBuilder.AddForeignKey(
                name: "FK_Dersler_Ogretmenler_OgretmenID",
                table: "Dersler",
                column: "OgretmenID",
                principalTable: "Ogretmenler",
                principalColumn: "OgretmenID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dersler_Ogretmenler_OgretmenID",
                table: "Dersler");

            migrationBuilder.DropTable(
                name: "OgrenciDersleri");

            migrationBuilder.DropIndex(
                name: "IX_Dersler_OgretmenID",
                table: "Dersler");

            migrationBuilder.DropColumn(
                name: "OgretmenID",
                table: "Dersler");
        }
    }
}
