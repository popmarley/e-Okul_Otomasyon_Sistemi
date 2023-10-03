using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulOtomasyonu.Entity
{
	public class Teacher
	{
		[Key]
		public int TeacherID { get; set; }
		public int UserID { get; set; }
		public int CourseID { get; set; }
		public int RegistrationNumber { get; set; }
		public string Name { get; set; }
		public string Branch { get; set; }
		public string LastName { get; set; }
		public DateTime StartDate { get; set; }


		public virtual ICollection<User> Users { get; set; }
	}
}
