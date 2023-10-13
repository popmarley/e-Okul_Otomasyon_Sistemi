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
				var userInDb = context.Kullanicilar
									  .FirstOrDefault(u => u.KullaniciAdi == txt_UserName.Text && u.Sifre == txt_Password.Text);

				if (userInDb != null)
				{
					switch (userInDb.TipID)
					{
						case 1: // Mudur
							MudurAnaMenu mudurMenuForm = new MudurAnaMenu();
							mudurMenuForm.Show();
							break;

						case 2: // Ogretmen
							OgretmenAnaMenu ogretmenMenuForm = new OgretmenAnaMenu();
							ogretmenMenuForm.Show();
							break;

						case 3: // Ogrenci
							OgrenciAnaMenu ogrenciMenuForm = new OgrenciAnaMenu();
							ogrenciMenuForm.Show();
							break;

						default:
							MessageBox.Show("Tanımsız kullanıcı tipi!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
							break;
					}
					this.Hide();
				}
				else
				{
					txt_UserName.Clear();
					txt_Password.Clear();
					MessageBox.Show("Hatalı kullanıcı adı veya şifre!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}
		}

		

		private void btnSistemdenCikis_Click(object sender, EventArgs e)
		{
			e_Okul girisForm = new e_Okul();
			girisForm.Show();
			this.Hide();
		}
	}
}
