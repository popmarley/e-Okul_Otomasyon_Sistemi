using System;
using System.Collections.Generic;
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
		public int StudentNo { get; set; }
		public int RoomID { get; set; }
		public int ParentID { get; set; }


		public virtual ICollection<User> Users { get; set; } /*= new List<User>();*/
		public virtual ICollection<Parent> Parents { get; set; } 
		public virtual ICollection<Room> Rooms { get; set; } 
	}
}
