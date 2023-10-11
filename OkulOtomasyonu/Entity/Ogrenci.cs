using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OkulOtomasyonu.Entity
{
	public class Ogrenci
	{
		[Key]
		public int OgrenciID { get; set; }
		[ForeignKey("Kullanici")]
		public int KullaniciID { get; set; }
		[ForeignKey("Sinif")]
		public int SinifID { get; set; }
		[ForeignKey("Veli")]
		public int VeliID { get; set; }
		public string Ad { get; set; }
		public string Soyad { get; set; }
		public string Adres { get; set; }
		public int OgrenciNo { get; set; }
		public int TCNo { get; set; }
		public DateTime DogumTarihi { get; set; }


		public List<OgrenciDers> OgrenciDersleri { get; set; }
		public Kullanici Kullanici { get; set; }
		public Sinif Sinif { get; set; }
		public Veli Veli { get; set; }
		public List<SinavSonucu> SinavSonuclari { get; set; }
	}
}
