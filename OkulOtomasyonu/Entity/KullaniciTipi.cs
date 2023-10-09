using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OkulOtomasyonu.Entity
{
	public class KullaniciTipi
	{
		[Key]
		public int TipID { get; set; }
		public string TipAdi { get; set; }
		public List<Kullanici> Kullanicilar { get; set; }
	}
}
