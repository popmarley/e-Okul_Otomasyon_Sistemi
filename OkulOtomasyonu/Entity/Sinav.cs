using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OkulOtomasyonu.Entity
{
	public class Sinav
	{
		[Key]
		public int SinavID { get; set; }
		[ForeignKey("Ders")]
		public int DersID { get; set; }

		public Ders Ders { get; set; }
		public List<SinavSonucu> SinavSonuclari { get; set; }
	}
}
