using Microsoft.EntityFrameworkCore.Migrations;

namespace OkulOtomasyonu.Migrations
{
    public partial class _2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dersler_Ogretmenler_OgretmenID",
                table: "Dersler");

            migrationBuilder.DropIndex(
                name: "IX_Dersler_OgretmenID",
                table: "Dersler");

            migrationBuilder.DropColumn(
                name: "DersID",
                table: "Ogretmenler");

            migrationBuilder.DropColumn(
                name: "OgretmenID",
                table: "Dersler");

            migrationBuilder.AddColumn<int>(
                name: "OgretmenBransID",
                table: "Ogretmenler",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "OgretmenBranslari",
                columns: table => new
                {
                    OgretmenBransID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OgretmenID = table.Column<int>(nullable: false),
                    DersID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OgretmenBranslari", x => x.OgretmenBransID);
                    table.ForeignKey(
                        name: "FK_OgretmenBranslari_Ogretmenler_OgretmenID",
                        column: x => x.OgretmenID,
                        principalTable: "Ogretmenler",
                        principalColumn: "OgretmenID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ogretmenler_OgretmenBransID",
                table: "Ogretmenler",
                column: "OgretmenBransID");

            migrationBuilder.CreateIndex(
                name: "IX_OgretmenBranslari_OgretmenID",
                table: "OgretmenBranslari",
                column: "OgretmenID");

            migrationBuilder.AddForeignKey(
                name: "FK_Ogretmenler_OgretmenBranslari_OgretmenBransID",
                table: "Ogretmenler",
                column: "OgretmenBransID",
                principalTable: "OgretmenBranslari",
                principalColumn: "OgretmenBransID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ogretmenler_OgretmenBranslari_OgretmenBransID",
                table: "Ogretmenler");

            migrationBuilder.DropTable(
                name: "OgretmenBranslari");

            migrationBuilder.DropIndex(
                name: "IX_Ogretmenler_OgretmenBransID",
                table: "Ogretmenler");

            migrationBuilder.DropColumn(
                name: "OgretmenBransID",
                table: "Ogretmenler");

            migrationBuilder.AddColumn<int>(
                name: "DersID",
                table: "Ogretmenler",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OgretmenID",
                table: "Dersler",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Dersler_OgretmenID",
                table: "Dersler",
                column: "OgretmenID");

            migrationBuilder.AddForeignKey(
                name: "FK_Dersler_Ogretmenler_OgretmenID",
                table: "Dersler",
                column: "OgretmenID",
                principalTable: "Ogretmenler",
                principalColumn: "OgretmenID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
