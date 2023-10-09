using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OkulOtomasyonu.Entity
{
	public class Kullanici
	{
		[Key]
		public int KullaniciID { get; set; }
		[ForeignKey("KullaniciTipi")]
		public int TipID { get; set; }
		public string KullaniciAdi { get; set; }
		public string Sifre { get; set; }

		public KullaniciTipi KullaniciTipi { get; set; }
	}
}
