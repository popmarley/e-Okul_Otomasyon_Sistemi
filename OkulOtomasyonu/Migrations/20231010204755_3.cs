using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OkulOtomasyonu.Migrations
{
    public partial class _3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DogumTarihi",
                table: "Ogretmenler",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "TCNo",
                table: "Ogretmenler",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Adres",
                table: "Ogrenciler",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DogumTarihi",
                table: "Ogrenciler",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "OgrenciNo",
                table: "Ogrenciler",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TCNo",
                table: "Ogrenciler",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "DogumTarihi",
                table: "Mudurler",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "TCNo",
                table: "Mudurler",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Eposta",
                table: "Kullanicilar",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Telefon",
                table: "Kullanicilar",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DogumTarihi",
                table: "Ogretmenler");

            migrationBuilder.DropColumn(
                name: "TCNo",
                table: "Ogretmenler");

            migrationBuilder.DropColumn(
                name: "Adres",
                table: "Ogrenciler");

            migrationBuilder.DropColumn(
                name: "DogumTarihi",
                table: "Ogrenciler");

            migrationBuilder.DropColumn(
                name: "OgrenciNo",
                table: "Ogrenciler");

            migrationBuilder.DropColumn(
                name: "TCNo",
                table: "Ogrenciler");

            migrationBuilder.DropColumn(
                name: "DogumTarihi",
                table: "Mudurler");

            migrationBuilder.DropColumn(
                name: "TCNo",
                table: "Mudurler");

            migrationBuilder.DropColumn(
                name: "Eposta",
                table: "Kullanicilar");

            migrationBuilder.DropColumn(
                name: "Telefon",
                table: "Kullanicilar");
        }
    }
}
