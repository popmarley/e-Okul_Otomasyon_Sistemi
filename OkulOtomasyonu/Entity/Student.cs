using System;
using System.ComponentModel.DataAnnotations;

namespace OkulOtomasyonu.Entity
{
	public class Student
	{
		[Key]
		public int StudentID { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public DateTime DOB { get; set; }
		public string Address { get; set; }
	}
}
