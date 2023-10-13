namespace OkulOtomasyonu
{
	partial class e_Okul
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(e_Okul));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.lblYonetimGiris = new System.Windows.Forms.Label();
			this.lbl_SifremiUnuttum = new System.Windows.Forms.Label();
			this.lblOgrenciGiris = new System.Windows.Forms.Label();
			this.lbl_KayitOl = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(-2, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(1353, 634);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// lblYonetimGiris
			// 
			this.lblYonetimGiris.AutoSize = true;
			this.lblYonetimGiris.Font = new System.Drawing.Font("Montserrat Medium", 7F, System.Drawing.FontStyle.Bold);
			this.lblYonetimGiris.Location = new System.Drawing.Point(544, 188);
			this.lblYonetimGiris.Name = "lblYonetimGiris";
			this.lblYonetimGiris.Size = new System.Drawing.Size(140, 32);
			this.lblYonetimGiris.TabIndex = 1;
			this.lblYonetimGiris.Text = "Okul Yönetimi Bilgi\r\nSistemi Girişi\r\n";
			this.lblYonetimGiris.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblYonetimGiris.Click += new System.EventHandler(this.lblYonetimGiris_Click);
			// 
			// lbl_SifremiUnuttum
			// 
			this.lbl_SifremiUnuttum.AutoSize = true;
			this.lbl_SifremiUnuttum.Font = new System.Drawing.Font("Montserrat Medium", 6F);
			this.lbl_SifremiUnuttum.Location = new System.Drawing.Point(532, 254);
			this.lbl_SifremiUnuttum.Name = "lbl_SifremiUnuttum";
			this.lbl_SifremiUnuttum.Size = new System.Drawing.Size(96, 14);
			this.lbl_SifremiUnuttum.TabIndex = 1;
			this.lbl_SifremiUnuttum.Text = "Şifremi Unuttum";
			this.lbl_SifremiUnuttum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lbl_SifremiUnuttum.Click += new System.EventHandler(this.lbl_SifremiUnuttum_Click);
			// 
			// lblOgrenciGiris
			// 
			this.lblOgrenciGiris.AutoSize = true;
			this.lblOgrenciGiris.Font = new System.Drawing.Font("Montserrat Medium", 7F, System.Drawing.FontStyle.Bold);
			this.lblOgrenciGiris.Location = new System.Drawing.Point(714, 188);
			this.lblOgrenciGiris.Name = "lblOgrenciGiris";
			this.lblOgrenciGiris.Size = new System.Drawing.Size(159, 32);
			this.lblOgrenciGiris.TabIndex = 1;
			this.lblOgrenciGiris.Text = "Öğrenci Bilgilendirme\r\nSistemi Girişi\r\n";
			this.lblOgrenciGiris.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblOgrenciGiris.Click += new System.EventHandler(this.lblOgrenciGiris_Click);
			// 
			// lbl_KayitOl
			// 
			this.lbl_KayitOl.AutoSize = true;
			this.lbl_KayitOl.Font = new System.Drawing.Font("Montserrat Medium", 6F);
			this.lbl_KayitOl.Location = new System.Drawing.Point(766, 254);
			this.lbl_KayitOl.Name = "lbl_KayitOl";
			this.lbl_KayitOl.Size = new System.Drawing.Size(47, 14);
			this.lbl_KayitOl.TabIndex = 1;
			this.lbl_KayitOl.Text = "Kayıt Ol";
			this.lbl_KayitOl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lbl_KayitOl.Click += new System.EventHandler(this.lbl_KayitOl_Click);
			// 
			// e_Okul
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1347, 633);
			this.Controls.Add(this.lbl_KayitOl);
			this.Controls.Add(this.lbl_SifremiUnuttum);
			this.Controls.Add(this.lblOgrenciGiris);
			this.Controls.Add(this.lblYonetimGiris);
			this.Controls.Add(this.pictureBox1);
			this.Name = "e_Okul";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "BÇAL Yönetim Bilgi Sistemi ";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label lblYonetimGiris;
		private System.Windows.Forms.Label lbl_SifremiUnuttum;
		private System.Windows.Forms.Label lblOgrenciGiris;
		private System.Windows.Forms.Label lbl_KayitOl;
	}
}