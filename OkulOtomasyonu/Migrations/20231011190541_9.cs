using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OkulOtomasyonu.Migrations
{
    public partial class _9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "KullaniciTipleri",
                columns: table => new
                {
                    TipID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipAdi = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KullaniciTipleri", x => x.TipID);
                });

            migrationBuilder.CreateTable(
                name: "Siniflar",
                columns: table => new
                {
                    SinifID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SinifAdi = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Siniflar", x => x.SinifID);
                });

            migrationBuilder.CreateTable(
                name: "Veliler",
                columns: table => new
                {
                    VeliID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(nullable: true),
                    Soyad = table.Column<string>(nullable: true),
                    Telefon = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Veliler", x => x.VeliID);
                });

            migrationBuilder.CreateTable(
                name: "Kullanicilar",
                columns: table => new
                {
                    KullaniciID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipID = table.Column<int>(nullable: false),
                    KullaniciAdi = table.Column<string>(nullable: true),
                    Sifre = table.Column<string>(nullable: true),
                    Eposta = table.Column<string>(nullable: true),
                    Telefon = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kullanicilar", x => x.KullaniciID);
                    table.ForeignKey(
                        name: "FK_Kullanicilar_KullaniciTipleri_TipID",
                        column: x => x.TipID,
                        principalTable: "KullaniciTipleri",
                        principalColumn: "TipID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Mudurler",
                columns: table => new
                {
                    MudurID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KullaniciID = table.Column<int>(nullable: false),
                    Ad = table.Column<string>(nullable: true),
                    Soyad = table.Column<string>(nullable: true),
                    TCNo = table.Column<int>(nullable: false),
                    DogumTarihi = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mudurler", x => x.MudurID);
                    table.ForeignKey(
                        name: "FK_Mudurler_Kullanicilar_KullaniciID",
                        column: x => x.KullaniciID,
                        principalTable: "Kullanicilar",
                        principalColumn: "KullaniciID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ogrenciler",
                columns: table => new
                {
                    OgrenciID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KullaniciID = table.Column<int>(nullable: false),
                    SinifID = table.Column<int>(nullable: false),
                    VeliID = table.Column<int>(nullable: false),
                    Ad = table.Column<string>(nullable: true),
                    Soyad = table.Column<string>(nullable: true),
                    Adres = table.Column<string>(nullable: true),
                    OgrenciNo = table.Column<int>(nullable: false),
                    TCNo = table.Column<int>(nullable: false),
                    DogumTarihi = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ogrenciler", x => x.OgrenciID);
                    table.ForeignKey(
                        name: "FK_Ogrenciler_Kullanicilar_KullaniciID",
                        column: x => x.KullaniciID,
                        principalTable: "Kullanicilar",
                        principalColumn: "KullaniciID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ogrenciler_Siniflar_SinifID",
                        column: x => x.SinifID,
                        principalTable: "Siniflar",
                        principalColumn: "SinifID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ogrenciler_Veliler_VeliID",
                        column: x => x.VeliID,
                        principalTable: "Veliler",
                        principalColumn: "VeliID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ogretmenler",
                columns: table => new
                {
                    OgretmenID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KullaniciID = table.Column<int>(nullable: false),
                    DersID = table.Column<int>(nullable: false),
                    Ad = table.Column<string>(nullable: true),
                    Soyad = table.Column<string>(nullable: true),
                    TCNo = table.Column<int>(nullable: false),
                    DogumTarihi = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ogretmenler", x => x.OgretmenID);
                    table.ForeignKey(
                        name: "FK_Ogretmenler_Kullanicilar_KullaniciID",
                        column: x => x.KullaniciID,
                        principalTable: "Kullanicilar",
                        principalColumn: "KullaniciID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Dersler",
                columns: table => new
                {
                    DersID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DersAdi = table.Column<string>(nullable: true),
                    OgretmenID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dersler", x => x.DersID);
                    table.ForeignKey(
                        name: "FK_Dersler_Ogretmenler_OgretmenID",
                        column: x => x.OgretmenID,
                        principalTable: "Ogretmenler",
                        principalColumn: "OgretmenID",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.CreateTable(
                name: "Sinavlar",
                columns: table => new
                {
                    SinavID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DersID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sinavlar", x => x.SinavID);
                    table.ForeignKey(
                        name: "FK_Sinavlar_Dersler_DersID",
                        column: x => x.DersID,
                        principalTable: "Dersler",
                        principalColumn: "DersID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SinavSonuclari",
                columns: table => new
                {
                    SonucID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OgrenciID = table.Column<int>(nullable: false),
                    SinavID = table.Column<int>(nullable: false),
                    Puan = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SinavSonuclari", x => x.SonucID);
                    table.ForeignKey(
                        name: "FK_SinavSonuclari_Ogrenciler_OgrenciID",
                        column: x => x.OgrenciID,
                        principalTable: "Ogrenciler",
                        principalColumn: "OgrenciID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SinavSonuclari_Sinavlar_SinavID",
                        column: x => x.SinavID,
                        principalTable: "Sinavlar",
                        principalColumn: "SinavID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Dersler_OgretmenID",
                table: "Dersler",
                column: "OgretmenID");

            migrationBuilder.CreateIndex(
                name: "IX_Kullanicilar_TipID",
                table: "Kullanicilar",
                column: "TipID");

            migrationBuilder.CreateIndex(
                name: "IX_Mudurler_KullaniciID",
                table: "Mudurler",
                column: "KullaniciID");

            migrationBuilder.CreateIndex(
                name: "IX_OgrenciDersleri_DersID",
                table: "OgrenciDersleri",
                column: "DersID");

            migrationBuilder.CreateIndex(
                name: "IX_OgrenciDersleri_OgrenciID",
                table: "OgrenciDersleri",
                column: "OgrenciID");

            migrationBuilder.CreateIndex(
                name: "IX_Ogrenciler_KullaniciID",
                table: "Ogrenciler",
                column: "KullaniciID");

            migrationBuilder.CreateIndex(
                name: "IX_Ogrenciler_SinifID",
                table: "Ogrenciler",
                column: "SinifID");

            migrationBuilder.CreateIndex(
                name: "IX_Ogrenciler_VeliID",
                table: "Ogrenciler",
                column: "VeliID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ogretmenler_KullaniciID",
                table: "Ogretmenler",
                column: "KullaniciID");

            migrationBuilder.CreateIndex(
                name: "IX_Sinavlar_DersID",
                table: "Sinavlar",
                column: "DersID");

            migrationBuilder.CreateIndex(
                name: "IX_SinavSonuclari_OgrenciID",
                table: "SinavSonuclari",
                column: "OgrenciID");

            migrationBuilder.CreateIndex(
                name: "IX_SinavSonuclari_SinavID",
                table: "SinavSonuclari",
                column: "SinavID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Mudurler");

            migrationBuilder.DropTable(
                name: "OgrenciDersleri");

            migrationBuilder.DropTable(
                name: "SinavSonuclari");

            migrationBuilder.DropTable(
                name: "Ogrenciler");

            migrationBuilder.DropTable(
                name: "Sinavlar");

            migrationBuilder.DropTable(
                name: "Siniflar");

            migrationBuilder.DropTable(
                name: "Veliler");

            migrationBuilder.DropTable(
                name: "Dersler");

            migrationBuilder.DropTable(
                name: "Ogretmenler");

            migrationBuilder.DropTable(
                name: "Kullanicilar");

            migrationBuilder.DropTable(
                name: "KullaniciTipleri");
        }
    }
}
