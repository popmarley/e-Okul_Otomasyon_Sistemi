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
	public partial class SifremiUnuttum : Form
	{
		public SifremiUnuttum()
		{
			InitializeComponent();
			lblYeniSifre.Visible = false;
			txtSifremiUnuttumYeniSifre.Visible = false;
			btnSifremiUnuttumSifreDegistir.Visible = false;
		}

		private void btnSifremiUnuttumKontrol_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtSifremiUnuttumKullaniciAdi.Text) || string.IsNullOrEmpty(txtSifremiUnuttumEposta.Text))
			{
				MessageBox.Show("Kullanıcı adı ve eposta alanları boş bırakılamaz.");
				return;
			}

			if (txtSifremiUnuttumBotKontrol.Text != "7111")
			{
				MessageBox.Show("Güvenlik kodu yanlış. Lütfen tekrar deneyin.");
				return;
			}

			using (var context = new MyDbContext())
			{
				var kullanici = context.Kullanicilar.FirstOrDefault(k => k.KullaniciAdi == txtSifremiUnuttumKullaniciAdi.Text && k.Eposta == txtSifremiUnuttumEposta.Text);
				if (kullanici != null)
				{
					lblYeniSifre.Visible = true;
					txtSifremiUnuttumYeniSifre.Visible = true;
					btnSifremiUnuttumSifreDegistir.Visible = true;
				}
				else
				{
					MessageBox.Show("Kullanıcı adı veya eposta sistemde kayıtlı değil.", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}
		}

		private void btnSifremiUnuttumSifreDegistir_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtSifremiUnuttumYeniSifre.Text))
			{
				MessageBox.Show("Yeni şifre alanı boş bırakılamaz.", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			using (var context = new MyDbContext())
			{
				var kullanici = context.Kullanicilar.FirstOrDefault(k => k.KullaniciAdi == txtSifremiUnuttumKullaniciAdi.Text && k.Eposta == txtSifremiUnuttumEposta.Text);
				if (kullanici != null)
				{
					if (kullanici.Sifre == txtSifremiUnuttumYeniSifre.Text)
					{
						MessageBox.Show("Yeni şifre mevcut şifrenizle aynı olamaz. Farklı bir şifre girin.","Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						return;
					}

					kullanici.Sifre = txtSifremiUnuttumYeniSifre.Text;
					context.SaveChanges();
					MessageBox.Show("Şifreniz başarıyla güncellendi.Giriş ekranına yönlendiriliyorsunuz...", "Bilgi!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
				else
				{
					MessageBox.Show("Kullanıcı adı veya eposta doğru değil.", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}

			e_Okul girisForm = new e_Okul();
			girisForm.Show();
			this.Hide();
		}

		

		private void pSifremiUnuttumGeri_Click(object sender, EventArgs e)
		{
			e_Okul girisForm = new e_Okul();
			girisForm.Show();
			this.Hide();
		}
	}
}

