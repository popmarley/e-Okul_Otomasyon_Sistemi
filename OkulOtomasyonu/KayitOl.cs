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
	public partial class KayitOl : Form
	{
		public KayitOl()
		{
			InitializeComponent();

			// Başlangıçta tüm grup kutularını devre dışı bırak
			gboxOgrenci.Enabled = false;
			gboxOgretmen.Enabled = false;
			gboxMudur.Enabled = false;

			// Radyo butonlarına tıklama olayını ekleyin
			btnTurOgrenci.Click += RadyoButon_Tiklandi;
			btnTurOgretmen.Click += RadyoButon_Tiklandi;
			btnTurMudur.Click += RadyoButon_Tiklandi;
		}

		private void btn_Geri_Click(object sender, EventArgs e)
		{
			Giris girisForm = new Giris();
			girisForm.Show();
			this.Hide();
		}

		private void RadyoButon_Tiklandi(object sender, EventArgs e)
		{
			// Tüm grup kutularını devre dışı bırak
			gboxOgrenci.Enabled = false;
			gboxOgretmen.Enabled = false;
			gboxMudur.Enabled = false;

			// Hangi radyo butonuna tıklanırsa ilgili grup kutusunu aktif yap
			if (btnTurOgrenci.Checked)
			{
				gboxOgrenci.Enabled = true;
			}
			else if (btnTurOgretmen.Checked)
			{
				gboxOgretmen.Enabled = true;
			}
			else if (btnTurMudur.Checked)
			{
				gboxMudur.Enabled = true;
			}
		}

	}
}
