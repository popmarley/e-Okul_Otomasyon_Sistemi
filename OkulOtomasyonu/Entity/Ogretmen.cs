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
		public string Ad { get; set; }
		public string Soyad { get; set; }

		public Kullanici Kullanici { get; set; }
	}
}
