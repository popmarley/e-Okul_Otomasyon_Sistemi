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
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
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
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Montserrat Medium", 6F);
			this.label2.Location = new System.Drawing.Point(640, 252);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(96, 14);
			this.label2.TabIndex = 1;
			this.label2.Text = "Şifremi Unuttum";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Montserrat Medium", 7F, System.Drawing.FontStyle.Bold);
			this.label1.Location = new System.Drawing.Point(714, 188);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(159, 32);
			this.label1.TabIndex = 1;
			this.label1.Text = "Öğrenci Bilgilendirme\r\nSistemi Girişi\r\n";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// e_Okul
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1347, 633);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
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
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}