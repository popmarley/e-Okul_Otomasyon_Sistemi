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
	public partial class OgretmenAnaMenu : Form
	{
		private string ogretmenAdiVeSoyadi;
		private string dersAdi;
		public OgretmenAnaMenu()
		{
			InitializeComponent();
		}

		public OgretmenAnaMenu(string adiVeSoyadi, string dersAdi)
		{
			InitializeComponent();
			this.ogretmenAdiVeSoyadi = adiVeSoyadi;
			this.dersAdi = dersAdi;
		}
		private void btn_Cikis_Click(object sender, EventArgs e)
		{
			e_Okul girisForm = new e_Okul();
			girisForm.Show();
			this.Hide();
		}

		private void SaatTimer_Tick(object sender, EventArgs e)
		{
			lblAnlikSaat.Text = DateTime.Now.ToString("HH:mm:ss");
		}

		private void OgretmenAnaMenu_Load(object sender, EventArgs e)
		{
			// Saatin anlık olarak güncellenmesi için bir Timer 
			Timer saatTimer = new Timer();
			saatTimer.Interval = 1000; // her saniye
			saatTimer.Tick += SaatTimer_Tick;
			saatTimer.Start();

			lblGirisYapanOgretmenKullaniciAdi.Text = ogretmenAdiVeSoyadi;
			lblOgretmenBrans.Text = dersAdi;
		}
	}
}
