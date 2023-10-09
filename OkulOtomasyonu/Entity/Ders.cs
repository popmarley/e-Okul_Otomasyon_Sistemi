using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OkulOtomasyonu.Entity
{
	public class Ders
	{
		[Key]
		public int DersID { get; set; }
		public string DersAdi { get; set; }
		public List<Sinav> Sinavlar { get; set; }
	}
}
