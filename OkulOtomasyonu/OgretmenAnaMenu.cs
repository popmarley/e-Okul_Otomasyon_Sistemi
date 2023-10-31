using Microsoft.EntityFrameworkCore;
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

			FillOgrenciComboBox();
			FillNotTuruComboBox();
		}

		private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
		{
			using (var context = new MyDbContext())
			{

				if (e.Node.Name == "ogrenciListesi")
				{
					dgOgrenciListele.Visible = true;
					dgOgrenciVeliListele.Visible = false;
					ogrenciNotDuzenle.Visible = false;
					// Giriş yapan öğretmenin sınıfındaki öğrencileri listele
					var ogretmeninOgrencileri = context.Ogrenciler
														 .Include(o => o.Veli)  // Veli bilgisi için
										   .Include(o => o.Sinif) // Sınıf bilgisi için
										   .Where(o => o.SinifID == this.GirisYapanOgretmeninSinifID)
										   .Select(o => new
										   {
											   Ad = o.Ad,
											   Soyad = o.Soyad,
											   Adres = o.Adres,
											   OgrenciNo = o.OgrenciNo,
											   TCNo = o.TCNo,
											   DogumTarihi = o.DogumTarihi,
											   Sinif = o.Sinif.SinifAdi,
											   VeliAd = o.Veli.Ad,
											   VeliSoyad = o.Veli.Soyad,
											   VeliTelefon = o.Veli.Telefon
										   })
										   .ToList();

					dgOgrenciListele.DataSource = ogretmeninOgrencileri; // DataGridView'in veri kaynağını belirledik
				}
				else if (e.Node.Name == "ogrenciVeliBilgi")
				{
					dgOgrenciListele.Visible = false;
					dgOgrenciVeliListele.Visible = true;
					ogrenciNotDuzenle.Visible = false;

					// Giriş yapan öğretmenin sınıfındaki öğrencileri listele
					var ogretmeninOgrencileri = context.Ogrenciler
														 .Include(o => o.Veli)  // Veli bilgisi için
										   .Include(o => o.Sinif) // Sınıf bilgisi için
										   .Where(o => o.SinifID == this.GirisYapanOgretmeninSinifID)
										   .Select(o => new
										   {
											   Ad = o.Ad,
											   Soyad = o.Soyad,
											   Sinif = o.Sinif.SinifAdi,
											   VeliAd = o.Veli.Ad,
											   VeliSoyad = o.Veli.Soyad,
											   VeliTelefon = o.Veli.Telefon
										   })
										   .ToList();

					dgOgrenciVeliListele.DataSource = ogretmeninOgrencileri; // DataGridView'in veri kaynağını belirledik
				}


				else if (e.Node.Name == "ogrenciNotDuzenle")
				{
					dgOgrenciListele.Visible = false;
					dgOgrenciVeliListele.Visible = false;
					ogrenciNotDuzenle.Visible = true;
				}




			}
		}

		private void btnOgrenciNotKaydet_Click(object sender, EventArgs e)
		{
			
		}

		private void FillOgrenciComboBox()
		{
			using (var context = new MyDbContext())
			{
				// Giriş yapan öğretmenin sınıfındaki öğrencilerin isim ve soyadını getir
				var ogrenciIsimleri = context.Ogrenciler
							.Where(o => o.SinifID == this.GirisYapanOgretmeninSinifID)
							.Select(o => o.Ad + " " + o.Soyad)
							.ToList();

				
				cNotOgrenciAdi.Items.Clear();
				foreach (var isim in ogrenciIsimleri)
				{
					cNotOgrenciAdi.Items.Add(isim);
				}
			}
		}

		private void FillNotTuruComboBox()
		{
			cNotTuru.Items.Clear();
			cNotTuru.Items.Add("1. Sınav");
			cNotTuru.Items.Add("2. Sınav");
			cNotTuru.Items.Add("Sözlü");
			cNotTuru.Items.Add("Performans");
			
		}
	}
}
