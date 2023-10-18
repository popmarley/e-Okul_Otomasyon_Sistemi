using Microsoft.EntityFrameworkCore.Migrations;

namespace OkulOtomasyonu.Migrations
{
    public partial class _8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Notlar",
                columns: table => new
                {
                    NotID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OgrenciID = table.Column<int>(nullable: false),
                    OgretmenID = table.Column<int>(nullable: false),
                    DersID = table.Column<int>(nullable: false),
                    Deger = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notlar", x => x.NotID);
                    table.ForeignKey(
                        name: "FK_Notlar_Dersler_DersID",
                        column: x => x.DersID,
                        principalTable: "Dersler",
                        principalColumn: "DersID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Notlar_Ogrenciler_OgrenciID",
                        column: x => x.OgrenciID,
                        principalTable: "Ogrenciler",
                        principalColumn: "OgrenciID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Notlar_Ogretmenler_OgretmenID",
                        column: x => x.OgretmenID,
                        principalTable: "Ogretmenler",
                        principalColumn: "OgretmenID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Notlar_DersID",
                table: "Notlar",
                column: "DersID");

            migrationBuilder.CreateIndex(
                name: "IX_Notlar_OgrenciID",
                table: "Notlar",
                column: "OgrenciID");

            migrationBuilder.CreateIndex(
                name: "IX_Notlar_OgretmenID",
                table: "Notlar",
                column: "OgretmenID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Notlar");
        }
    }
}
