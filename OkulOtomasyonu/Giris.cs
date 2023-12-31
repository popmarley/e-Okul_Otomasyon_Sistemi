﻿using Microsoft.EntityFrameworkCore;
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
	public partial class Giris : Form
	{
		public Giris()
		{
			InitializeComponent();
		}

		private void btn_Giris_Click(object sender, EventArgs e)
		{
			using (var context = new MyDbContext())
			{
				// Güvenlik kodu kontrolü
				if (txtCapca.Text != "5341")
				{
					MessageBox.Show("Güvenlik kodu hatalı!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					txtCapca.Clear(); // Güvenlik kodu alanını temizle
					txtCapca.Focus(); // Güvenlik kodu alanına odakla
					return; // Diğer kontrollere geçmeden fonksiyonu sonlandır
				}

				var userInDb = context.Kullanicilar
									  .FirstOrDefault(u => (u.KullaniciAdi == txt_UserName.Text || u.Eposta == txt_UserName.Text) && u.Sifre == txt_Password.Text);

				// Kullanıcı adı ve şifre kontrolü
				if (userInDb == null)
				{
					MessageBox.Show("Hatalı kullanıcı adı,e-posta veya şifre!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					txt_UserName.Clear();
					txt_Password.Clear();
					txt_UserName.Focus(); // Kullanıcı adı/e-posta alanına odakla
					return; // Diğer kontrollere geçmeden fonksiyonu sonlandır
				}

				switch (userInDb.TipID)
				{
					case 1: // Mudur
						var mudur = context.Mudurler.FirstOrDefault(m => m.KullaniciID == userInDb.KullaniciID);
						if (mudur != null)
						{
							MudurAnaMenu mudurMenuForm = new MudurAnaMenu(mudur.Ad + " " + mudur.Soyad);
							mudurMenuForm.Show();
							this.Hide();
						}
						else
						{
							MessageBox.Show("Müdür bilgisi bulunamadı!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
						break;

					case 2: // Ogretmen
						var ogretmen = context.Ogretmenler
							.Include(o => o.OgretmenBrans)
							.FirstOrDefault(o => o.KullaniciID == userInDb.KullaniciID);
						if (ogretmen != null)
						{
							var ders = context.Dersler.FirstOrDefault(d => d.DersID == ogretmen.OgretmenBrans.DersID);
							var dersAdi = ders != null ? ders.DersAdi : "Bilinmeyen Ders";
							OgretmenAnaMenu ogretmenMenuForm = new OgretmenAnaMenu(ogretmen.Ad + " " + ogretmen.Soyad, dersAdi, ogretmen.OgretmenID, ogretmen.SinifID);
							ogretmenMenuForm.Show();
							this.Hide();
						}
						else
						{
							MessageBox.Show("Öğretmen bilgisi bulunamadı!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
						break;

					case 3: // Ogrenci
						MessageBox.Show("Yetkisiz giriş! Lütfen öğrenci giriş ekranını kullanın...", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
						break;

					default:
						MessageBox.Show("Tanımsız kullanıcı tipi!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
						break;
				}
			
			}
		}

		private void pSistemdenCikis_Click(object sender, EventArgs e)
		{
			DialogResult dr = MessageBox.Show("Sistemden çıkmak istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (dr == DialogResult.Yes)
			{
				e_Okul girisForm = new e_Okul();
				girisForm.Show();
				this.Hide();
			}
		}
	}
}
