using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OkulOtomasyonu.Entity
{
	public class Ders
	{
		[Key]
		public int DersID { get; set; }
		[ForeignKey("Ogretmen")]
		public int OgretmenID { get; set; }
		public string DersAdi { get; set; }
		public List<Sinav> Sinavlar { get; set; }
		public Ogretmen Ogretmen { get; set; }
		public List<OgrenciDers> OgrenciDersleri { get; set; }
	}
}
