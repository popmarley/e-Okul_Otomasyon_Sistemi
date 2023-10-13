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
	public partial class e_Okul : Form
	{
		public e_Okul()
		{
			InitializeComponent();
		}

		private void lbl_KayitOl_Click(object sender, EventArgs e)
		{
			KayitOl kayitOlForm = new KayitOl();
			kayitOlForm.Show();
			this.Hide();
		}

		private void lbl_SifremiUnuttum_Click(object sender, EventArgs e)
		{
			SifremiUnuttum sifremiUnuttumForm = new SifremiUnuttum();
			sifremiUnuttumForm.Show();
			this.Hide();
		}

		private void lblYonetimGiris_Click(object sender, EventArgs e)
		{
			Giris girisForm = new Giris();
			girisForm.Show();
			this.Hide();
		}

		private void lblOgrenciGiris_Click(object sender, EventArgs e)
		{
			Giris girisForm = new Giris();
			girisForm.Show();
			this.Hide();
		}
	}
}
