using System;
using System.ComponentModel.DataAnnotations;

namespace OkulOtomasyonu.Entity
{
	public class Exam
	{
		[Key]
		public int ExamID { get; set; }
		public int CourseID { get; set; }  // ForeignKey ile ilişkilendirme yapılabilir.
		public DateTime ExamDate { get; set; }
		public string Location { get; set; }
	}
}
