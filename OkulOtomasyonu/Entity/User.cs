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
		public int UserTypeID { get; set; } // Foreign Key olarak UserTypeID sütunu

		// UserType sınıfıyla ilişkilendirme
		public virtual UserType UserType { get; set; }
	}
}
