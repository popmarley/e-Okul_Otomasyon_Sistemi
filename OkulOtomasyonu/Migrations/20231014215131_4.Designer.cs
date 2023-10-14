﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OkulOtomasyonu.Context;

namespace OkulOtomasyonu.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20231014215131_4")]
    partial class _4
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("OkulOtomasyonu.Entity.Ders", b =>
                {
                    b.Property<int>("DersID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DersAdi")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DersID");

                    b.ToTable("Dersler");
                });

            modelBuilder.Entity("OkulOtomasyonu.Entity.Kullanici", b =>
                {
                    b.Property<int>("KullaniciID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Eposta")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KullaniciAdi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sifre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Telefon")
                        .HasColumnType("int");

                    b.Property<int>("TipID")
                        .HasColumnType("int");

                    b.HasKey("KullaniciID");

                    b.HasIndex("TipID");

                    b.ToTable("Kullanicilar");
                });

            modelBuilder.Entity("OkulOtomasyonu.Entity.KullaniciTipi", b =>
                {
                    b.Property<int>("TipID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TipAdi")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TipID");

                    b.ToTable("KullaniciTipleri");
                });

            modelBuilder.Entity("OkulOtomasyonu.Entity.Mudur", b =>
                {
                    b.Property<int>("MudurID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DogumTarihi")
                        .HasColumnType("datetime2");

                    b.Property<int>("KullaniciID")
                        .HasColumnType("int");

                    b.Property<string>("Soyad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TCNo")
                        .HasColumnType("int");

                    b.HasKey("MudurID");

                    b.HasIndex("KullaniciID");

                    b.ToTable("Mudurler");
                });

            modelBuilder.Entity("OkulOtomasyonu.Entity.Ogrenci", b =>
                {
                    b.Property<int>("OgrenciID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Adres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DogumTarihi")
                        .HasColumnType("datetime2");

                    b.Property<int>("KullaniciID")
                        .HasColumnType("int");

                    b.Property<int>("OgrenciNo")
                        .HasColumnType("int");

                    b.Property<int>("SinifID")
                        .HasColumnType("int");

                    b.Property<string>("Soyad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TCNo")
                        .HasColumnType("int");

                    b.Property<int>("VeliID")
                        .HasColumnType("int");

                    b.HasKey("OgrenciID");

                    b.HasIndex("KullaniciID");

                    b.HasIndex("SinifID");

                    b.HasIndex("VeliID")
                        .IsUnique();

                    b.ToTable("Ogrenciler");
                });

            modelBuilder.Entity("OkulOtomasyonu.Entity.OgrenciDers", b =>
                {
                    b.Property<int>("OgrenciDersID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DersAdi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DersID")
                        .HasColumnType("int");

                    b.Property<int>("OgrenciID")
                        .HasColumnType("int");

                    b.HasKey("OgrenciDersID");

                    b.HasIndex("DersID");

                    b.HasIndex("OgrenciID");

                    b.ToTable("OgrenciDersleri");
                });

            modelBuilder.Entity("OkulOtomasyonu.Entity.Ogretmen", b =>
                {
                    b.Property<int>("OgretmenID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DogumTarihi")
                        .HasColumnType("datetime2");

                    b.Property<int>("KullaniciID")
                        .HasColumnType("int");

                    b.Property<int>("OgretmenBransID")
                        .HasColumnType("int");

                    b.Property<int>("SinifID")
                        .HasColumnType("int");

                    b.Property<string>("Soyad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TCNo")
                        .HasColumnType("int");

                    b.HasKey("OgretmenID");

                    b.HasIndex("KullaniciID");

                    b.HasIndex("OgretmenBransID");

                    b.HasIndex("SinifID");

                    b.ToTable("Ogretmenler");
                });

            modelBuilder.Entity("OkulOtomasyonu.Entity.OgretmenBrans", b =>
                {
                    b.Property<int>("OgretmenBransID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DersID")
                        .HasColumnType("int");

                    b.HasKey("OgretmenBransID");

                    b.ToTable("OgretmenBranslari");
                });

            modelBuilder.Entity("OkulOtomasyonu.Entity.Sinav", b =>
                {
                    b.Property<int>("SinavID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DersID")
                        .HasColumnType("int");

                    b.HasKey("SinavID");

                    b.HasIndex("DersID");

                    b.ToTable("Sinavlar");
                });

            modelBuilder.Entity("OkulOtomasyonu.Entity.SinavSonucu", b =>
                {
                    b.Property<int>("SonucID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("OgrenciID")
                        .HasColumnType("int");

                    b.Property<float>("Puan")
                        .HasColumnType("real");

                    b.Property<int>("SinavID")
                        .HasColumnType("int");

                    b.HasKey("SonucID");

                    b.HasIndex("OgrenciID");

                    b.HasIndex("SinavID");

                    b.ToTable("SinavSonuclari");
                });

            modelBuilder.Entity("OkulOtomasyonu.Entity.Sinif", b =>
                {
                    b.Property<int>("SinifID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("SinifAdi")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SinifID");

                    b.ToTable("Siniflar");
                });

            modelBuilder.Entity("OkulOtomasyonu.Entity.Veli", b =>
                {
                    b.Property<int>("VeliID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Soyad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefon")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("VeliID");

                    b.ToTable("Veliler");
                });

            modelBuilder.Entity("OkulOtomasyonu.Entity.Kullanici", b =>
                {
                    b.HasOne("OkulOtomasyonu.Entity.KullaniciTipi", "KullaniciTipi")
                        .WithMany("Kullanicilar")
                        .HasForeignKey("TipID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OkulOtomasyonu.Entity.Mudur", b =>
                {
                    b.HasOne("OkulOtomasyonu.Entity.Kullanici", "Kullanici")
                        .WithMany()
                        .HasForeignKey("KullaniciID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OkulOtomasyonu.Entity.Ogrenci", b =>
                {
                    b.HasOne("OkulOtomasyonu.Entity.Kullanici", "Kullanici")
                        .WithMany()
                        .HasForeignKey("KullaniciID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OkulOtomasyonu.Entity.Sinif", "Sinif")
                        .WithMany("Ogrenciler")
                        .HasForeignKey("SinifID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OkulOtomasyonu.Entity.Veli", "Veli")
                        .WithOne("Ogrenci")
                        .HasForeignKey("OkulOtomasyonu.Entity.Ogrenci", "VeliID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OkulOtomasyonu.Entity.OgrenciDers", b =>
                {
                    b.HasOne("OkulOtomasyonu.Entity.Ders", "Ders")
                        .WithMany("OgrenciDersleri")
                        .HasForeignKey("DersID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OkulOtomasyonu.Entity.Ogrenci", "Ogrenci")
                        .WithMany("OgrenciDersleri")
                        .HasForeignKey("OgrenciID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OkulOtomasyonu.Entity.Ogretmen", b =>
                {
                    b.HasOne("OkulOtomasyonu.Entity.Kullanici", "Kullanici")
                        .WithMany()
                        .HasForeignKey("KullaniciID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OkulOtomasyonu.Entity.OgretmenBrans", "OgretmenBrans")
                        .WithMany("Ogretmen")
                        .HasForeignKey("OgretmenBransID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OkulOtomasyonu.Entity.Sinif", "Sinif")
                        .WithMany()
                        .HasForeignKey("SinifID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OkulOtomasyonu.Entity.Sinav", b =>
                {
                    b.HasOne("OkulOtomasyonu.Entity.Ders", "Ders")
                        .WithMany("Sinavlar")
                        .HasForeignKey("DersID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OkulOtomasyonu.Entity.SinavSonucu", b =>
                {
                    b.HasOne("OkulOtomasyonu.Entity.Ogrenci", "Ogrenci")
                        .WithMany("SinavSonuclari")
                        .HasForeignKey("OgrenciID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OkulOtomasyonu.Entity.Sinav", "Sinav")
                        .WithMany("SinavSonuclari")
                        .HasForeignKey("SinavID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
