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
		private bool isInitialLoad = true;
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
					dataGridView1.Visible = true;
					gOgretmenGuncelle.Visible = false;
					gOgretmenSil.Visible = false;


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
					dataGridView1.Visible = true;
					gOgretmenGuncelle.Visible = false;
					gOgretmenSil.Visible = false;
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
				else if (e.Node.Name == "ogretmenBilgiGuncelle")
				{
					dataGridView1.Visible = false;
					gOgretmenSil.Visible = false;
					gOgretmenGuncelle.Visible = true;



					var ogretmenler = context.Ogretmenler.ToList();
					cOgretmenListesi.DataSource = ogretmenler;
					cOgretmenListesi.DisplayMember = "Ad";
					cOgretmenListesi.ValueMember = "OgretmenID";

					// Öğretmen Branşları için combobox doldurma
					var dersler = context.Dersler.ToList();

					cOgretmenBrans.DataSource = dersler;
					cOgretmenBrans.DisplayMember = "DersAdi";
					cOgretmenBrans.ValueMember = "DersID";


					isInitialLoad = false; // ComboBox doldurulduktan sonra bayrağı false yap.
				}

				else if (e.Node.Name == "OgretmenSil")
				{
					dataGridView1.Visible = false;
					gOgretmenGuncelle.Visible = false;
					gOgretmenSil.Visible = true;

					var ogretmenListesi = (from o in context.Ogretmenler
										   join k in context.Kullanicilar on o.KullaniciID equals k.KullaniciID
										   join b in context.OgretmenBranslari on o.OgretmenBransID equals b.OgretmenBransID
										   join d in context.Dersler on b.DersID equals d.DersID
										   select new
										   {
											   o.OgretmenID,
											   o.Ad,
											   o.Soyad,
											   o.TCNo,
											   o.DogumTarihi,
											   KullaniciAdi = k.KullaniciAdi,
											   BransAdi = d.DersAdi
										   }).ToList();


					gOgretmenSil.DataSource = ogretmenListesi;

					if (!gOgretmenSil.Columns.Contains("btnSil"))
					{
						DataGridViewButtonColumn btnSil = new DataGridViewButtonColumn();
						btnSil.Name = "btnSil";
						btnSil.Text = "Sil";
						btnSil.HeaderText = "Sil";
						btnSil.UseColumnTextForButtonValue = true;
						gOgretmenSil.Columns.Add(btnSil);
					}
				}
				else
				{
					if (gOgretmenSil.Columns.Contains("btnSil"))
					{
						gOgretmenSil.Columns.Remove("btnSil");
					}
				}
			}
		}

		private void cOgretmenListesi_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (isInitialLoad) // İlk yükleme ise bu olayı geç.
			{
				return;
			}
			if (cOgretmenListesi.SelectedValue != null && cOgretmenListesi.SelectedValue is int)
			{
				using (var context = new MyDbContext())
				{
					int selectedOgretmenId = (int)cOgretmenListesi.SelectedValue;
					var ogretmen = context.Ogretmenler.Find(selectedOgretmenId);

					txtOgretmenAd.Text = ogretmen.Ad;
					txtOgretmenSoyad.Text = ogretmen.Soyad;
					txtOgretmenTCNo.Text = ogretmen.TCNo.ToString();
					txtOgretmenDogumTarihi.Value = ogretmen.DogumTarihi;

					// Öğretmenin branşını bul ve combobox'ta otomatik seç
					var ogretmenBrans = context.OgretmenBranslari.FirstOrDefault(ob => ob.OgretmenBransID == selectedOgretmenId);
					if (ogretmenBrans != null)
					{
						cOgretmenBrans.SelectedValue = ogretmenBrans.DersID;
					}

					// Eğer bir sınıf bilgisi de tutuyorsanız, aşağıdaki gibi sınıf bilgisini de ayarlayabilirsiniz:
					// cOgretmenSinif.SelectedValue = ogretmen.SinifID;
				}
			}
			else
			{
				MessageBox.Show("Seçili bir öğretmen yok ya da ID değeri doğru formatta değil.");
			}
		}

		private void btnGuncelle_Click(object sender, EventArgs e)
		{
			if (cOgretmenListesi.SelectedValue != null)
			{
				using (var context = new MyDbContext())
				{
					int selectedOgretmenId = (int)cOgretmenListesi.SelectedValue;
					var ogretmen = context.Ogretmenler.Find(selectedOgretmenId);

					ogretmen.Ad = txtOgretmenAd.Text;
					ogretmen.Soyad = txtOgretmenSoyad.Text;
					ogretmen.TCNo = int.Parse(txtOgretmenTCNo.Text);
					ogretmen.DogumTarihi = txtOgretmenDogumTarihi.Value;

					// Brans ve Sinif combobox'larından alınan değerleri de güncelleyin.
					// Örneğin:
					//ogretmen.OgretmenBransID = (int)cOgretmenBrans.SelectedValue;
					// ve diğerleri...

					context.SaveChanges();

					MessageBox.Show("Öğretmen bilgileri başarıyla güncellendi.");
				}
			}
		}

		// DataGridViewButtonColumn oluştur


		private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			using (var context = new MyDbContext())
			{
				int ogretmenId = Convert.ToInt32(gOgretmenSil.Rows[e.RowIndex].Cells["OgretmenID"].Value);

				// Öğretmeni veritabanından bul
				var ogretmen = context.Ogretmenler.Find(ogretmenId);
				var result = MessageBox.Show("Bu öğretmeni silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo);
				if (result == DialogResult.Yes)
				{
					if (ogretmen != null)
					{
						// Öğretmeni veritabanından sil
						context.Ogretmenler.Remove(ogretmen);

						// Değişiklikleri kaydet
						context.SaveChanges();

						MessageBox.Show("Öğretmen başarıyla silindi.");
						YenidenListele();

					}
					else
					{
						MessageBox.Show("Öğretmen bulunamadı ve silinemedi.");
					}
				}
			}
		}
		private void YenidenListele()
		{
			using (var context = new MyDbContext())
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

				gOgretmenSil.DataSource = ogretmenListesi;
			}
		}

	}
}
