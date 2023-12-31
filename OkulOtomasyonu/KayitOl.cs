﻿using OkulOtomasyonu.Context;
using OkulOtomasyonu.Entity;
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

			// Radyo butonlarına tıklama olayı
			btnTurOgrenci.Click += RadyoButon_Tiklandi;
			btnTurOgretmen.Click += RadyoButon_Tiklandi;
			btnTurMudur.Click += RadyoButon_Tiklandi;
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

		private void KayitOl_Load(object sender, EventArgs e)
		{
			using (var context = new MyDbContext())
			{
				// Siniflar'ın combobox'a yüklenmesi
				cboxOgrenciSinif.DataSource = context.Siniflar.ToList();
				cboxOgrenciSinif.DisplayMember = "SinifAdi";
				cboxOgrenciSinif.ValueMember = "SinifID";

				// Ogretmen branşı için Dersler'in combobox'a yüklenmesi
				cboxOgretmenBrans.DataSource=context.Dersler.ToList();
				cboxOgretmenBrans.DisplayMember = "DersAdi";
				cboxOgretmenBrans.ValueMember = "DersID";

				// Öğretmen Sınıflar için
				cboxOgretmenSinif.DataSource = context.Siniflar.ToList();
				cboxOgretmenSinif.DisplayMember = "SinifAdi";
				cboxOgretmenSinif.ValueMember = "SinifID";
			}
		}

		private void btnKayitOl_Click(object sender, EventArgs e)
		{
			// Şifrelerin uyuşup uyuşmadığını kontrol ediyoruz.
			if (txtSifre.Text != txtSifreTekrar.Text)
			{
				// Uyuşmuyorsa bir uyarı verip metottan çıkıyoruz.
				MessageBox.Show("Şifreler uyuşmuyor!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			using (var context = new MyDbContext())
			{
				int secilenTipID = 0;

				// Seçilen tipi belirle
				if (btnTurOgrenci.Checked)
					secilenTipID = 3;
				else if (btnTurOgretmen.Checked)
					secilenTipID = 2;
				else if (btnTurMudur.Checked)
					secilenTipID = 1;

				// Öncelikle Kullanicilar tablosuna verileri ekleme
				var kullanici = new Kullanici
				{
					KullaniciAdi = txtKullaniciAdi.Text,
					Sifre = txtSifre.Text,
					Eposta = txtEPosta.Text,
					Telefon = int.Parse(txtTelefon.Text) , // Telefon numarasını int'a dönüştürdük.
					 TipID = secilenTipID  // Seçilen tipi atadık.

				};
				context.Kullanicilar.Add(kullanici);
				context.SaveChanges();  // Kullanıcıyı kaydedip ID'sini almak için SaveChanges yapıyoruz.
				if (btnTurOgrenci.Checked)
				{
					// Öncelikle Veli nesnesini veritabanına ekleyelim
					var veli = new Veli
					{
						Ad = txtOgrenciVeliAdi.Text,
						Soyad = txtOgrenciVeliSoyadi.Text,
						Telefon = txtOgrenciVeliTel.Text
					};
					context.Veliler.Add(veli);
					context.SaveChanges();  // Veli'yi kaydedip ID'sini almak için SaveChanges yapıyoruz.

					// Şimdi de Ogrenci nesnesini oluşturalım ve VeliID'yi atayalım
					var ogrenci = new Ogrenci
					{
						KullaniciID = kullanici.KullaniciID,
						Ad = txtOgrenciAdi.Text,
						Soyad = txtOgrenciSoyadi.Text,
						TCNo = int.Parse(txtOgrenciTC.Text),
						DogumTarihi = dateOgrenciDogumTarihi.Value,
						SinifID = (int)cboxOgrenciSinif.SelectedValue,
						OgrenciNo = int.Parse(txtOgrenciNo.Text),
						Adres = txtOgrenciAdres.Text,
						VeliID = veli.VeliID  // Atanmış Veli ID'sini Ogrenci'ye atadık
					};
					context.Ogrenciler.Add(ogrenci);
				}
				else if (btnTurOgretmen.Checked)
				{
					var ogretmenBrans = new OgretmenBrans
					{
						DersID = (int)cboxOgretmenBrans.SelectedValue
					};
					context.OgretmenBranslari.Add(ogretmenBrans);
					context.SaveChanges();  // Öğretmen branşını kaydedip ID'sini almak için SaveChanges yapıyoruz.

					var ogretmen = new Ogretmen
					{
						KullaniciID = kullanici.KullaniciID,
						Ad = txtOgretmenAdi.Text,
						Soyad = txtOgretmenSoyadi.Text,
						TCNo = int.Parse(txtOgretmenTC.Text),
						DogumTarihi = dateOgretmenDogumTarihi.Value,
						OgretmenBransID = ogretmenBrans.OgretmenBransID,
						SinifID = (int)cboxOgretmenSinif.SelectedValue

					};
					context.Ogretmenler.Add(ogretmen);
				}
				else if (btnTurMudur.Checked)
				{
					var mudur = new Mudur
					{
						KullaniciID = kullanici.KullaniciID,
						Ad = txtMudurAdi.Text,
						Soyad = txtMudurSoyadi.Text,
						TCNo = int.Parse(txtMudurTC.Text),
						DogumTarihi = dateMudurDogumTarihi.Value
					};
					context.Mudurler.Add(mudur);
				}

				context.SaveChanges();
			}

			MessageBox.Show("Kayıt başarıyla tamamlandı!");
			e_Okul girisForm = new e_Okul();
			girisForm.Show();
			this.Hide();
		}

	
	

		private void txtSifre_TextChanged(object sender, EventArgs e)
		{
			SifreUyusuyorMu();
		}

		private void txtSifreTekrar_TextChanged(object sender, EventArgs e)
		{
			SifreUyusuyorMu();
		}

		private void SifreUyusuyorMu()
		{
			if (txtSifre.Text != txtSifreTekrar.Text)
			{
				lblSifreUyari.Text = "Şifreler uyuşmuyor!";
				lblSifreUyari.ForeColor = Color.Red;
			}
			else
			{
				lblSifreUyari.Text = ""; // Şifreler eşleştiğinde uyarı mesajını temizle
			}
		}

		private void pSistemdenCikis_Click(object sender, EventArgs e)
		{
			e_Okul girisForm = new e_Okul();
			girisForm.Show();
			this.Hide();
		}
	}
}
