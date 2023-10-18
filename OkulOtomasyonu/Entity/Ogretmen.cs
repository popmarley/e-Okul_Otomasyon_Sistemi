using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OkulOtomasyonu.Entity
{
	public class Ogretmen
	{
		[Key]
		public int OgretmenID { get; set; }
		[ForeignKey("Kullanici")]
		public int KullaniciID { get; set; }
		[ForeignKey("OgretmenBrans")]
		public int OgretmenBransID { get; set; }
		[ForeignKey("Sinif")]
		public int SinifID { get; set; }
		public string Ad { get; set; }
		public string Soyad { get; set; }
		public int TCNo { get; set; }
		public DateTime DogumTarihi { get; set; }



		public Kullanici Kullanici { get; set; }
		public OgretmenBrans OgretmenBrans { get; set; }
		public List<Not> Not { get; set; }
		public Sinif Sinif { get; set; }

	}
}
