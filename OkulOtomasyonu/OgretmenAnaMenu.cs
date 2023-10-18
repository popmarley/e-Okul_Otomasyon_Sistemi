using OkulOtomasyonu.Context;
using OkulOtomasyonu.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OkulOtomasyonu
{
	public partial class OgretmenAnaMenu : Form
	{
		private string ogretmenAdiVeSoyadi;
		private string dersAdi;
		public int GirisYapanOgretmenID { get; set; }
		public int GirisYapanOgretmeninSinifID { get; set; }
		public OgretmenAnaMenu()
		{
			InitializeComponent();
		}

		public OgretmenAnaMenu(string adiVeSoyadi, string dersAdi, int ogretmenID, int sinifID)
		{
			InitializeComponent();
			this.ogretmenAdiVeSoyadi = adiVeSoyadi;
			this.dersAdi = dersAdi;
			GirisYapanOgretmenID = ogretmenID;
			GirisYapanOgretmeninSinifID = sinifID;
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

		private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
		{
			using (var context = new MyDbContext())
			{
				if (e.Node.Name == "ogrenciListesi")
				{
					if (e.Node.Name == "ogrenciListesi")
					{
						dgOgrenciListele.Visible = true;

						// Giriş yapan öğretmenin sınıfındaki öğrencileri listele
						var ogretmeninOgrencileri = context.Ogrenciler
														   .Where(o => o.SinifID == this.GirisYapanOgretmeninSinifID)
														   .ToList();

						dgOgrenciListele.DataSource = ogretmeninOgrencileri; // DataGridView'in veri kaynağını belirledik
					}
				}
			}
		}








	}
}
