using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulOtomasyonu.Entity
{
	public class User
	{
		[Key]
		public int UserID { get; set; }
		public string Username { get; set; }
		public string Password { get; set; }
		public string Email { get; set; }
		public string SecurityQuestion { get; set; }
		public int Phone { get; set; }
		public int UserTypeID { get; set; } 
		public int StudentID { get; set; } 

		

		public virtual UserType UserType { get; set; }
		public virtual Student Student { get; set; }
		public virtual Teacher Teacher { get; set; }
		public virtual Manager Manager { get; set; }
	}
}
