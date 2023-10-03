using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulOtomasyonu.Entity
{
	public class Parent
	{
		[Key]
		public int ParentID { get; set; }
        public int StudentID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Phone { get; set; }



		public virtual ICollection<Student> Students { get; set; }

	}
}
