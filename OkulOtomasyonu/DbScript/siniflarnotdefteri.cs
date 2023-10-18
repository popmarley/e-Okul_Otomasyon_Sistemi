using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulOtomasyonu.DbScript
{
	internal class siniflarnotdefteri
	{
		//public class Ders
		//{
		//	[Key]
		//	public int DersID { get; set; }
		//	public string DersAdi { get; set; }
		//	public List<Sinav> Sinavlar { get; set; }
		//	public List<OgrenciDers> OgrenciDersleri { get; set; }
		//}

		//public class Kullanici
		//{
		//	[Key]
		//	public int KullaniciID { get; set; }
		//	[ForeignKey("KullaniciTipi")]
		//	public int TipID { get; set; }
		//	public string KullaniciAdi { get; set; }
		//	public string Sifre { get; set; }
		//	public string Eposta { get; set; }
		//	public int Telefon { get; set; }

		//	public KullaniciTipi KullaniciTipi { get; set; }
		//}

		//public class KullaniciTipi
		//{
		//	[Key]
		//	public int TipID { get; set; }
		//	public string TipAdi { get; set; }
		//	public List<Kullanici> Kullanicilar { get; set; }
		//}

		//public class Mudur
		//{
		//	[Key]
		//	public int MudurID { get; set; }
		//	[ForeignKey("Kullanici")]
		//	public int KullaniciID { get; set; }
		//	public string Ad { get; set; }
		//	public string Soyad { get; set; }
		//	public int TCNo { get; set; }
		//	public DateTime DogumTarihi { get; set; }


		//	public Kullanici Kullanici { get; set; }
		//}

		//public class Ogrenci
		//{
		//	[Key]
		//	public int OgrenciID { get; set; }
		//	[ForeignKey("Kullanici")]
		//	public int KullaniciID { get; set; }
		//	[ForeignKey("Sinif")]
		//	public int SinifID { get; set; }
		//	[ForeignKey("Veli")]
		//	public int VeliID { get; set; }
		//	public string Ad { get; set; }
		//	public string Soyad { get; set; }
		//	public string Adres { get; set; }
		//	public int OgrenciNo { get; set; }
		//	public int TCNo { get; set; }
		//	public DateTime DogumTarihi { get; set; }


		//	public List<OgrenciDers> OgrenciDersleri { get; set; }
		//	public Kullanici Kullanici { get; set; }
		//	public Sinif Sinif { get; set; }
		//	public Veli Veli { get; set; }
		//	public List<SinavSonucu> SinavSonuclari { get; set; }
		//	public List<Not> Not { get; set; }
		//}

		//public class OgrenciDers
		//{
		//	[Key]
		//	public int OgrenciDersID { get; set; }
		//	public string DersAdi { get; set; }
		//	[ForeignKey("Ogrenci")]
		//	public int OgrenciID { get; set; }
		//	[ForeignKey("Ders")]
		//	public int DersID { get; set; }



		//	public Ogrenci Ogrenci { get; set; }
		//	public Ders Ders { get; set; }
		//}

		//public class Ogretmen
		//{
		//	[Key]
		//	public int OgretmenID { get; set; }
		//	[ForeignKey("Kullanici")]
		//	public int KullaniciID { get; set; }
		//	[ForeignKey("OgretmenBrans")]
		//	public int OgretmenBransID { get; set; }
		//	[ForeignKey("Sinif")]
		//	public int SinifID { get; set; }
		//	public string Ad { get; set; }
		//	public string Soyad { get; set; }
		//	public int TCNo { get; set; }
		//	public DateTime DogumTarihi { get; set; }

		//	public Kullanici Kullanici { get; set; }
		//	public OgretmenBrans OgretmenBrans { get; set; }
		//	public List<Not> Not { get; set; }
		//	public Sinif Sinif { get; set; }
		//}
		//public class Sinav
		//{
		//	[Key]
		//	public int SinavID { get; set; }
		//	[ForeignKey("Ders")]
		//	public int DersID { get; set; }

		//	public Ders Ders { get; set; }
		//	public List<SinavSonucu> SinavSonuclari { get; set; }
		//}


		//public class SinavSonucu
		//{
		//	[Key]
		//	public int SonucID { get; set; }
		//	[ForeignKey("Ogrenci")]
		//	public int OgrenciID { get; set; }
		//	[ForeignKey("Sinav")]
		//	public int SinavID { get; set; }
		//	public float Puan { get; set; }

		//	public Ogrenci Ogrenci { get; set; }
		//	public Sinav Sinav { get; set; }
		//}

		//public class Sinif
		//{
		//	[Key]
		//	public int SinifID { get; set; }
		//	public string SinifAdi { get; set; }
		//	public List<Ogrenci> Ogrenciler { get; set; }
		//}

		//public class Veli
		//{
		//	[Key]
		//	public int VeliID { get; set; }
		//	public string Ad { get; set; }
		//	public string Soyad { get; set; }
		//	public string Telefon { get; set; }

		//	public Ogrenci Ogrenci { get; set; }
		//}
		//public class OgretmenBrans
		//{
		//	[Key]
		//	public int OgretmenBransID { get; set; }
		//	[ForeignKey("Ders")]
		//	public int DersID { get; set; }


		//	public List<Ogretmen> Ogretmen { get; set; }
		//}
		//public class Not
		//{
		//	[Key]
		//	public int NotID { get; set; }
		//	[ForeignKey("Ogrenci")]
		//	public int OgrenciID { get; set; }
		//	[ForeignKey("Ogretmen")]
		//	public int OgretmenID { get; set; }
		//	[ForeignKey("Ders")]
		//	public int DersID { get; set; }
		//	public int Sinav1 { get; set; }
		//	public int Sinav2 { get; set; }
		//	public int Sozlu { get; set; }
		//	public int Performans { get; set; }


		//	public Ogrenci Ogrenci { get; set; }
		//	public Ogretmen Ogretmen { get; set; }
		//	public Ders Ders { get; set; }
		//}

		//public class MyDbContext : DbContext
		//{
		//	public DbSet<KullaniciTipi> KullaniciTipleri { get; set; }
		//	public DbSet<Kullanici> Kullanicilar { get; set; }
		//	public DbSet<Sinif> Siniflar { get; set; }
		//	public DbSet<Ders> Dersler { get; set; }
		//	public DbSet<Sinav> Sinavlar { get; set; }
		//	public DbSet<Ogrenci> Ogrenciler { get; set; }
		//	public DbSet<Veli> Veliler { get; set; }
		//	public DbSet<Ogretmen> Ogretmenler { get; set; }
		//	public DbSet<Mudur> Mudurler { get; set; }
		//	public DbSet<SinavSonucu> SinavSonuclari { get; set; }
		//	public DbSet<OgrenciDers> OgrenciDersleri { get; set; }



		//	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		//	{
		//		optionsBuilder.UseSqlServer(@"Data Source=OZGUVEN;Initial Catalog=EgitimOtomasyonu;Integrated Security=True");
		//	}


		//}
	}
}
