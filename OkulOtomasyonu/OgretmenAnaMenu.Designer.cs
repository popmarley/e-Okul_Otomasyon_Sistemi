namespace OkulOtomasyonu
{
	partial class OgretmenAnaMenu
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OgretmenAnaMenu));
			this.btn_Cikis = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.lblAnlikSaat = new System.Windows.Forms.Label();
			this.lblOgrenciSinif = new System.Windows.Forms.Label();
			this.lblGirisYapanKullaniciAdi = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// btn_Cikis
			// 
			this.btn_Cikis.Location = new System.Drawing.Point(42, 193);
			this.btn_Cikis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btn_Cikis.Name = "btn_Cikis";
			this.btn_Cikis.Size = new System.Drawing.Size(75, 23);
			this.btn_Cikis.TabIndex = 1;
			this.btn_Cikis.Text = "Çıkış Yap";
			this.btn_Cikis.UseVisualStyleBackColor = true;
			this.btn_Cikis.Click += new System.EventHandler(this.btn_Cikis_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(12, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(146, 121);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 3;
			this.pictureBox1.TabStop = false;
			// 
			// lblAnlikSaat
			// 
			this.lblAnlikSaat.AutoSize = true;
			this.lblAnlikSaat.Location = new System.Drawing.Point(1180, 12);
			this.lblAnlikSaat.Name = "lblAnlikSaat";
			this.lblAnlikSaat.Size = new System.Drawing.Size(135, 16);
			this.lblAnlikSaat.TabIndex = 4;
			this.lblAnlikSaat.Text = "anlık saat gösterecek";
			// 
			// lblOgrenciSinif
			// 
			this.lblOgrenciSinif.AutoSize = true;
			this.lblOgrenciSinif.Location = new System.Drawing.Point(39, 163);
			this.lblOgrenciSinif.Name = "lblOgrenciSinif";
			this.lblOgrenciSinif.Size = new System.Drawing.Size(87, 16);
			this.lblOgrenciSinif.TabIndex = 5;
			this.lblOgrenciSinif.Text = "sınıfı yazacak";
			// 
			// lblGirisYapanKullaniciAdi
			// 
			this.lblGirisYapanKullaniciAdi.AutoSize = true;
			this.lblGirisYapanKullaniciAdi.Location = new System.Drawing.Point(39, 136);
			this.lblGirisYapanKullaniciAdi.Name = "lblGirisYapanKullaniciAdi";
			this.lblGirisYapanKullaniciAdi.Size = new System.Drawing.Size(80, 16);
			this.lblGirisYapanKullaniciAdi.TabIndex = 6;
			this.lblGirisYapanKullaniciAdi.Text = "adı yazacak";
			// 
			// OgretmenAnaMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1347, 633);
			this.Controls.Add(this.lblAnlikSaat);
			this.Controls.Add(this.lblOgrenciSinif);
			this.Controls.Add(this.lblGirisYapanKullaniciAdi);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btn_Cikis);
			this.Name = "OgretmenAnaMenu";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "BÇAL Yönetim Bilgi Sistemi ";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btn_Cikis;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label lblAnlikSaat;
		private System.Windows.Forms.Label lblOgrenciSinif;
		private System.Windows.Forms.Label lblGirisYapanKullaniciAdi;
		private System.Windows.Forms.Timer timer1;
	}
}