using System.ComponentModel.DataAnnotations;

namespace OkulOtomasyonu.Entity
{
	public class ExamResult
	{
		[Key]
		public int ResultID { get; set; }
		public int ExamID { get; set; }    // ForeignKey ile ilişkilendirme yapılabilir.
		public int StudentID { get; set; } // ForeignKey ile ilişkilendirme yapılabilir.
		public int Score { get; set; }
	}
}
