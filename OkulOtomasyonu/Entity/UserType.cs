using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OkulOtomasyonu.Entity
{
	public class UserType
	{
		[Key]
		public int UserTypeID { get; set; }
		public string Name { get; set; }

		
		public virtual ICollection<User> Users { get; set; } = new List<User>();
	}
}
