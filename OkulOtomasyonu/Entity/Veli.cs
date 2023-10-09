using System.ComponentModel.DataAnnotations;

namespace OkulOtomasyonu.Entity
{
	public class Veli
	{
		[Key]
		public int VeliID { get; set; }
		public string Ad { get; set; }
		public string Soyad { get; set; }
		public string Telefon { get; set; }

		public Ogrenci Ogrenci { get; set; }
	}
}
