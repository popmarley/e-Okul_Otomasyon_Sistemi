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
	public partial class OgrenciAnaMenu : Form
	{
		public string GirisYapanKullaniciAdi { get; set; }
		public string OgrenciSinifi { get; set; }
		public OgrenciAnaMenu()
		{
			InitializeComponent();
		}

		private void btn_Cikis_Click(object sender, EventArgs e)
		{
			DialogResult dr = MessageBox.Show("Sistemden çıkmak istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (dr == DialogResult.Yes)
			{
				e_Okul girisForm = new e_Okul();
				girisForm.Show();
				this.Hide();
			}
		}

		private void OgrenciAnaMenu_Load(object sender, EventArgs e)
		{
			lblGirisYapanKullaniciAdi.Text = GirisYapanKullaniciAdi;
			lblOgrenciSinif.Text = OgrenciSinifi;

			// Saatin anlık olarak güncellenmesi için bir Timer oluşturalım
			Timer saatTimer = new Timer();
			saatTimer.Interval = 1000; // her saniye
			saatTimer.Tick += SaatTimer_Tick;
			saatTimer.Start();
		}

		private void SaatTimer_Tick(object sender, EventArgs e)
		{
			lblAnlikSaat.Text = DateTime.Now.ToString("HH:mm:ss");
		}

		private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
		{
			using (var context = new MyDbContext())
			{

				if (e.Node.Name == "ogrenciDuyuru")
				{
					pDuyuru.Visible = true;
				}

			}
		}
	}
}
