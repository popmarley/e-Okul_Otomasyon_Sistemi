using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulOtomasyonu.Entity
{
	public class Manager
	{
        [Key]
        public int ManagerID { get; set; }
        public int UserID { get; set; }
        public string Name { get; set; }
		public string LastName { get; set; }
        public DateTime StartDate { get; set; }


		public virtual ICollection<User> Users { get; set; }

	}
}
