using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulOtomasyonu.Entity
{
	public class OgrenciDers
	{
		[Key]
		public int OgrenciDersID { get; set; }
        public string DersAdi { get; set; }
		[ForeignKey("Ogrenci")]
		public int OgrenciID { get; set; }
		[ForeignKey("Ders")]
		public int DersID { get; set; }



		public Ogrenci Ogrenci { get; set; }
		public Ders Ders { get; set; }
	}
}
