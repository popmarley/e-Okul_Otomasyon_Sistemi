using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulOtomasyonu.Entity
{
	public class OgretmenBrans
	{
		[Key]
		public int OgretmenBransID { get; set; }
		[ForeignKey("Ders")]
		public int DersID { get; set; }


		public List<Ogretmen> Ogretmen { get; set; }
	}
}
