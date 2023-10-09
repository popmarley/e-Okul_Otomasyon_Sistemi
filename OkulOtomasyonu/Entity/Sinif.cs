using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OkulOtomasyonu.Entity
{
	public class Sinif
	{
		[Key]
		public int SinifID { get; set; }
		public string SinifAdi { get; set; }
		public List<Ogrenci> Ogrenciler { get; set; }
	}
}
