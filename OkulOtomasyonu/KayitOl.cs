﻿using System;
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
		}

		private void btn_Geri_Click(object sender, EventArgs e)
		{
			Giris girisForm = new Giris();
			girisForm.Show();
			this.Hide();
		}
	}
}
