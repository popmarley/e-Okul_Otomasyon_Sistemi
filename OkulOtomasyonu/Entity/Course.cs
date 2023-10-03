using System.ComponentModel.DataAnnotations;

namespace OkulOtomasyonu.Entity
{
	public class Course
	{
		[Key]
		public int CourseID { get; set; }
		public string CourseName { get; set; }
		public string Description { get; set; }
	}
}
