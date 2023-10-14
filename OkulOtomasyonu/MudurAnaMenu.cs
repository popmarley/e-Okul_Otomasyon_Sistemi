using OkulOtomasyonu.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OkulOtomasyonu
{
	public partial class MudurAnaMenu : Form
	{
		public string GirisYapanMudurKullaniciAdi { get; set; }
		public MudurAnaMenu()
		{
			InitializeComponent();

		}
		public MudurAnaMenu(string mudurAdi)
		{
			InitializeComponent();
			GirisYapanMudurKullaniciAdi = mudurAdi;
			lblGirisYapanMudurKullaniciAdi.Text = mudurAdi;
		}
		private void btn_Cikis_Click(object sender, EventArgs e)
		{
			e_Okul girisForm = new e_Okul();
			girisForm.Show();
			this.Hide();
		}

		private void MudurAnaMenu_Load(object sender, EventArgs e)
		{
			// Saatin anlık olarak güncellenmesi için bir Timer 
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
				if (e.Node.Name == "ogretmenListesi")
				{
					var ogretmenListesi = (from o in context.Ogretmenler
										   join k in context.Kullanicilar on o.KullaniciID equals k.KullaniciID
										   join b in context.OgretmenBranslari on o.OgretmenBransID equals b.OgretmenBransID
										   join d in context.Dersler on b.DersID equals d.DersID
										   select new
										   {
											   o.Ad,
											   o.Soyad,
											   o.TCNo,
											   o.DogumTarihi,
											   KullaniciAdi = k.KullaniciAdi,
											   BransAdi = d.DersAdi
										   }).ToList();


					dataGridView1.DataSource = ogretmenListesi;
				}
				else if (e.Node.Name == "ogrenciListesi")
				{
					var ogrenciListesi = (from ogr in context.Ogrenciler
										  join k in context.Kullanicilar on ogr.KullaniciID equals k.KullaniciID
										  join s in context.Siniflar on ogr.SinifID equals s.SinifID
										  join v in context.Veliler on ogr.VeliID equals v.VeliID
										  select new
										  {
											  ogr.Ad,
											  ogr.Soyad,
											  ogr.TCNo,
											  ogr.DogumTarihi,
											  ogr.OgrenciNo,
											  Telefon = k.Telefon,
											  KullaniciAdi = k.KullaniciAdi,
											  SinifAdi = s.SinifAdi,
											  ogr.Adres,
											  VeliAdi = v.Ad,
											  VeliSoyadi = v.Soyad,
											  VeliTelefonu = v.Telefon
										  }).ToList();
					dataGridView1.DataSource = ogrenciListesi;
				}
			}
		}
	}
}
