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
		private bool isInitialLoadOgrenci = true;
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
			DialogResult dr = MessageBox.Show("Sistemden çıkmak istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (dr == DialogResult.Yes)
			{
				e_Okul girisForm = new e_Okul();
				girisForm.Show();
				this.Hide();
			}
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
					dgOgretmenListele.Visible = true;
					gOgretmenGuncelle.Visible = false;
					gOgretmenSil.Visible = false;
					gOgrenciGuncelle.Visible=false;
					dgOgrenciSil.Visible = false;


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


					dgOgretmenListele.DataSource = ogretmenListesi;
				}
				else if (e.Node.Name == "ogrenciListesi")
				{
					dgOgretmenListele.Visible = true;
					gOgretmenGuncelle.Visible = false;
					gOgretmenSil.Visible = false;
					gOgrenciGuncelle.Visible = false;
					dgOgrenciSil.Visible = false;

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
					dgOgretmenListele.DataSource = ogrenciListesi;
				}
				else if (e.Node.Name == "ogretmenBilgiGuncelle")
				{
					dgOgretmenListele.Visible = false;
					gOgretmenSil.Visible = false;
					gOgretmenGuncelle.Visible = true;
					gOgrenciGuncelle.Visible = false;
					dgOgrenciSil.Visible = false;


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
					dgOgretmenListele.Visible=false;
					gOgretmenGuncelle.Visible = false;
					gOgretmenSil.Visible = true;
					gOgrenciGuncelle.Visible = false;
					dgOgrenciSil.Visible = false;

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

				else if (e.Node.Name == "ogrenciBilgiGuncelle")
				{
					dgOgretmenListele.Visible = false;
					gOgretmenGuncelle.Visible = false;
					gOgretmenSil.Visible = false;
					gOgrenciGuncelle.Visible = true; 
					dgOgrenciSil.Visible = false;

					// Öğrencileri veritabanından çekip combobox'a ekliyoruz
					var ogrenciler = context.Ogrenciler.ToList();
					cOgrenciGuncelleme.DataSource = ogrenciler;
					cOgrenciGuncelleme.DisplayMember = "Ad";
					cOgrenciGuncelleme.ValueMember = "OgrenciID";
					
					isInitialLoadOgrenci = false; // İlk yükleme bittiğini belirtin.

				}

				else if (e.Node.Name == "ogrenciSil")
				{
					dgOgrenciSil.Visible = true;
					gOgretmenGuncelle.Visible = false;
					gOgretmenSil.Visible = false;
					gOgrenciGuncelle.Visible = false;

					var ogrenciListesi = (from ogr in context.Ogrenciler
										  join k in context.Kullanicilar on ogr.KullaniciID equals k.KullaniciID
										  join s in context.Siniflar on ogr.SinifID equals s.SinifID
										  join v in context.Veliler on ogr.VeliID equals v.VeliID
										  select new
										  {
											  ogr.OgrenciID,
											  ogr.Ad,
											  ogr.Soyad,
											  ogr.TCNo,
											  ogr.DogumTarihi,
											  Telefon = k.Telefon,
											  KullaniciAdi = k.KullaniciAdi,
											  SinifAdi = s.SinifAdi,
											  ogr.Adres,
											  VeliAdi = v.Ad,
											  VeliSoyadi = v.Soyad,
											  VeliTelefonu = v.Telefon
										  }).ToList();

					dgOgrenciSil.DataSource = ogrenciListesi;

					if (!dgOgrenciSil.Columns.Contains("btnSilOgrenci"))
					{
						DataGridViewButtonColumn btnSilOgrenci = new DataGridViewButtonColumn();
						btnSilOgrenci.Name = "btnSilOgrenci";
						btnSilOgrenci.Text = "Sil";
						btnSilOgrenci.HeaderText = "Sil";
						btnSilOgrenci.UseColumnTextForButtonValue = true;
						dgOgrenciSil.Columns.Add(btnSilOgrenci);
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

		#region öğretmen silme 
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

		#endregion

		#region ögretmen silince anlık tablo güncelleme
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
		#endregion

		private void cOgrenciGuncelleme_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (isInitialLoadOgrenci) // İlk yükleme ise bu olayı geç.
			{
				return;
			}

			try
			{
				int ogrenciId = (int)cOgrenciGuncelleme.SelectedValue;

				using (var context = new MyDbContext())
				{
					var ogrenci = context.Ogrenciler.Find(ogrenciId);

					if (ogrenci != null)
					{
						txtOgrenciAdi.Text = ogrenci.Ad;
						txtOgrenciSoyadi.Text = ogrenci.Soyad;
						txtOgrenciTC.Text = ogrenci.TCNo.ToString();
						dOgrenciDogumTarihi.Value = ogrenci.DogumTarihi;
						txtOgrenciNo.Text = ogrenci.OgrenciNo.ToString();
						txtOgrenciAdresi.Text = ogrenci.Adres;
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Bir hata oluştu: " + ex.Message);
			}
		}

		private void btnOgrenciGuncelle_Click(object sender, EventArgs e)
		{
			int ogrenciId;
			if (int.TryParse(cOgrenciGuncelleme.SelectedValue.ToString(), out ogrenciId))
			{
				using (var context = new MyDbContext())
				{
					var ogrenciToUpdate = context.Ogrenciler.Find(ogrenciId);

					if (ogrenciToUpdate != null)
					{
						ogrenciToUpdate.Ad = txtOgrenciAdi.Text;
						ogrenciToUpdate.Soyad = txtOgrenciSoyadi.Text;
						ogrenciToUpdate.TCNo = int.Parse(txtOgrenciTC.Text);
						ogrenciToUpdate.DogumTarihi = dOgrenciDogumTarihi.Value;
						ogrenciToUpdate.OgrenciNo = int.Parse(txtOgrenciNo.Text);
						ogrenciToUpdate.Adres = txtOgrenciAdresi.Text;

						context.SaveChanges();
						MessageBox.Show("Öğrenci bilgileri başarıyla güncellendi.");
					}
					else
					{
						MessageBox.Show("Seçili öğrenci bulunamadı.");
					}
				}
			}
			else
			{
				MessageBox.Show("Seçili öğrenci ID'si geçerli bir tam sayı değil.");
			}
		}

		private void dgOgrenciSil_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (dgOgrenciSil.Columns[e.ColumnIndex].Name == "btnSilOgrenci")
			{
				using (var context = new MyDbContext())
				{
					int ogrenciId = Convert.ToInt32(dgOgrenciSil.Rows[e.RowIndex].Cells["OgrenciID"].Value);

					var ogrenci = context.Ogrenciler.Find(ogrenciId);
					var result = MessageBox.Show("Bu öğrenciyi silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo);
					if (result == DialogResult.Yes)
					{
						if (ogrenci != null)
						{
							context.Ogrenciler.Remove(ogrenci);
							context.SaveChanges();

							MessageBox.Show("Öğrenci başarıyla silindi.");
							OgrenciListesiYenidenYukle();
						}
						else
						{
							MessageBox.Show("Öğrenci bulunamadı ve silinemedi.");
						}
					}
				}
			}
		}
		private void OgrenciListesiYenidenYukle()
		{
			using (var context = new MyDbContext())
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

				dgOgrenciSil.DataSource = ogrenciListesi;

				// Öğrenci silme işlevi için DataGridView'da butonu kontrol ediyoruz
				if (!dgOgrenciSil.Columns.Contains("btnOgrenciSil"))
				{
					DataGridViewButtonColumn btnOgrenciSil = new DataGridViewButtonColumn();
					btnOgrenciSil.Name = "btnOgrenciSil";
					btnOgrenciSil.Text = "Sil";
					btnOgrenciSil.HeaderText = "Sil";
					btnOgrenciSil.UseColumnTextForButtonValue = true;
					dgOgrenciSil.Columns.Add(btnOgrenciSil);
				}
			}
		}


	}
}
