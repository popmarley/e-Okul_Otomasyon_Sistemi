using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulOtomasyonu.Entity
{
	public class Not
	{
		[Key]
		public int NotID { get; set; }
		[ForeignKey("Ogrenci")]
		public int OgrenciID { get; set; }
		[ForeignKey("Ogretmen")]
		public int OgretmenID { get; set; }
		[ForeignKey("Ders")]
		public int DersID { get; set; }

        public int Sinav1 { get; set; }
        public int Sinav2 { get; set; }
        public int Sozlu { get; set; }
        public int Performans{ get; set; }


        public Ogrenci Ogrenci { get; set; }
		public Ogretmen Ogretmen { get; set; }
		public Ders Ders { get; set; }
	}
}
