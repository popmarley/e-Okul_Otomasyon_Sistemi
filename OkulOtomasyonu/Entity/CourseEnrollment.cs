using System.ComponentModel.DataAnnotations;

namespace OkulOtomasyonu.Entity
{
	public class CourseEnrollment
	{
		[Key]
		public int EnrollmentID { get; set; }
		public int StudentID { get; set; } // ForeignKey ile ilişkilendirme yapılabilir.
		public int CourseID { get; set; }  // ForeignKey ile ilişkilendirme yapılabilir.
	}
}
