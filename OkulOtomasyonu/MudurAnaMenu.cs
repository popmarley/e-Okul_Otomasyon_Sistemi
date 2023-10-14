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

		
	}
}
