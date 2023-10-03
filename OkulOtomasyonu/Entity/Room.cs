using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulOtomasyonu.Entity
{
	public class Room
	{
        public int RoomID { get; set; }
		public string Name { get; set; }


		public virtual ICollection<Student> Students { get; set; }
	}
}
