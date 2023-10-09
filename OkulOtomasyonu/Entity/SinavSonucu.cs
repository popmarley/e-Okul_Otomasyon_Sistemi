using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OkulOtomasyonu.Entity
{
	public class SinavSonucu
	{
		[Key]
		public int SonucID { get; set; }
		[ForeignKey("Ogrenci")]
		public int OgrenciID { get; set; }
		[ForeignKey("Sinav")]
		public int SinavID { get; set; }
		public float Puan { get; set; }

		public Ogrenci Ogrenci { get; set; }
		public Sinav Sinav { get; set; }
	}
}
