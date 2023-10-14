using Microsoft.EntityFrameworkCore;
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
	public partial class OgrenciGiris : Form
	{
		public OgrenciGiris()
		{
			InitializeComponent();
		}

		private void btn_Giris_Click(object sender, EventArgs e)
		{
			using (var context = new MyDbContext())
			{
				// Güvenlik kodu kontrolü
				if (txtCapca.Text != "6495")
				{
					MessageBox.Show("Güvenlik kodu hatalı!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					txtCapca.Clear(); // Güvenlik kodu alanını temizle
					txtCapca.Focus(); // Güvenlik kodu alanına odakla
					return; // Diğer kontrollere geçmeden fonksiyonu sonlandır
				}

				if (!int.TryParse(txt_TCNo.Text, out int tcNo) || !int.TryParse(txt_OkulNo.Text, out int ogrenciNo))
				{
					MessageBox.Show("TC veya öğrenci numarası geçersiz!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return; // Geçersiz TC veya öğrenci numarası girilirse fonksiyonu sonlandır
				}

				var ogrenci = context.Ogrenciler.Include(o => o.Sinif).FirstOrDefault(u => u.TCNo == tcNo && u.OgrenciNo == ogrenciNo);

				// TC ve öğrenci numarası kontrolü
				if (ogrenci == null)
				{
					MessageBox.Show("Hatalı TC veya öğrenci numarası!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					txt_TCNo.Clear();
					txt_OkulNo.Clear();
					txt_TCNo.Focus(); // TC alanına odakla
					return; // Diğer kontrollere geçmeden fonksiyonu sonlandır
				}

				// Ogrenciler ve Kullanicilar arasındaki ilişkiyi kontrol ederek Kullanici'yi alıyoruz.
				var kullanici = context.Kullanicilar.FirstOrDefault(k => k.KullaniciID == ogrenci.KullaniciID);

				if (kullanici == null)
				{
					MessageBox.Show("Öğrenci için kullanıcı bilgisi bulunamadı!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				switch (kullanici.TipID)
				{
					case 3: // Ogrenci
						OgrenciAnaMenu ogrenciMenuForm = new OgrenciAnaMenu
						{
							GirisYapanKullaniciAdi = ogrenci.Ad,
							OgrenciSinifi = ogrenci.Sinif.SinifAdi.ToString()
						};
						ogrenciMenuForm.Show();
						this.Hide();  // Bu formu gizle
						break;

					case 1: // Mudur
					case 2: // Ogretmen
						MessageBox.Show("Yetkisiz giriş! Lütfen öğrenci giriş ekranını kullanın...", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
						break;

					default:
						MessageBox.Show("Tanımsız kullanıcı tipi!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
						break;
				}
				this.Hide();
			}
		}

		private void btnSistemdenCikis_Click(object sender, EventArgs e)
		{
			e_Okul girisForm = new e_Okul();
			girisForm.Show();
			this.Hide();
		}
	}
}
