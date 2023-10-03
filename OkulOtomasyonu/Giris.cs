using OkulOtomasyonu.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OkulOtomasyonu
{
	public partial class Giris : Form
	{
		public Giris()
		{
			InitializeComponent();
		}

		private void btn_Giris_Click(object sender, EventArgs e)
		{
			using (var context = new MyDbContext())
			{
				var userInDb = context.Users
									  .FirstOrDefault(u => u.Username == txt_UserName.Text && u.Password == txt_Password.Text);

				if (userInDb != null)
				{

					KayitOl kayitOlForm = new KayitOl();
					kayitOlForm.Show();
					this.Hide();
				}
				else
				{
					MessageBox.Show("Hatalı kullanıcı adı veya şifre!");
				}
			}
		}
	}
}
