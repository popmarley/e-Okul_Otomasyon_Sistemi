namespace OkulOtomasyonu
{
	partial class OgrenciGiris
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OgrenciGiris));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btn_Giris = new System.Windows.Forms.Button();
			this.txt_OkulNo = new System.Windows.Forms.TextBox();
			this.txtCapca = new System.Windows.Forms.TextBox();
			this.txt_TCNo = new System.Windows.Forms.TextBox();
			this.pSistemdenCikis = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pSistemdenCikis)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(-1, -3);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(1351, 637);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.Location = new System.Drawing.Point(311, 295);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(188, 27);
			this.label2.TabIndex = 10;
			this.label2.Text = "Okul Numaranız:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
			this.label3.Location = new System.Drawing.Point(369, 117);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(130, 54);
			this.label3.TabIndex = 11;
			this.label3.Text = "Resimdeki \r\nRakamlar:\r\n";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
			this.label1.Location = new System.Drawing.Point(367, 195);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(132, 54);
			this.label1.TabIndex = 12;
			this.label1.Text = "T.C. Kimlik \r\nNumaranız:";
			// 
			// btn_Giris
			// 
			this.btn_Giris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.btn_Giris.Font = new System.Drawing.Font("Montserrat Medium", 7.8F, System.Drawing.FontStyle.Bold);
			this.btn_Giris.Location = new System.Drawing.Point(537, 370);
			this.btn_Giris.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btn_Giris.Name = "btn_Giris";
			this.btn_Giris.Size = new System.Drawing.Size(151, 69);
			this.btn_Giris.TabIndex = 9;
			this.btn_Giris.Text = "Giriş";
			this.btn_Giris.UseVisualStyleBackColor = false;
			this.btn_Giris.Click += new System.EventHandler(this.btn_Giris_Click);
			// 
			// txt_OkulNo
			// 
			this.txt_OkulNo.Location = new System.Drawing.Point(515, 300);
			this.txt_OkulNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txt_OkulNo.MaxLength = 8;
			this.txt_OkulNo.Name = "txt_OkulNo";
			this.txt_OkulNo.PasswordChar = '*';
			this.txt_OkulNo.Size = new System.Drawing.Size(221, 22);
			this.txt_OkulNo.TabIndex = 8;
			// 
			// txtCapca
			// 
			this.txtCapca.Location = new System.Drawing.Point(515, 138);
			this.txtCapca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtCapca.MaxLength = 4;
			this.txtCapca.Name = "txtCapca";
			this.txtCapca.Size = new System.Drawing.Size(221, 22);
			this.txtCapca.TabIndex = 6;
			// 
			// txt_TCNo
			// 
			this.txt_TCNo.Location = new System.Drawing.Point(515, 211);
			this.txt_TCNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txt_TCNo.MaxLength = 32;
			this.txt_TCNo.Name = "txt_TCNo";
			this.txt_TCNo.Size = new System.Drawing.Size(221, 22);
			this.txt_TCNo.TabIndex = 7;
			// 
			// pSistemdenCikis
			// 
			this.pSistemdenCikis.BackColor = System.Drawing.Color.Transparent;
			this.pSistemdenCikis.Image = ((System.Drawing.Image)(resources.GetObject("pSistemdenCikis.Image")));
			this.pSistemdenCikis.Location = new System.Drawing.Point(755, 44);
			this.pSistemdenCikis.Name = "pSistemdenCikis";
			this.pSistemdenCikis.Size = new System.Drawing.Size(72, 38);
			this.pSistemdenCikis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pSistemdenCikis.TabIndex = 14;
			this.pSistemdenCikis.TabStop = false;
			this.pSistemdenCikis.Click += new System.EventHandler(this.pSistemdenCikis_Click);
			// 
			// OgrenciGiris
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1347, 633);
			this.Controls.Add(this.pSistemdenCikis);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btn_Giris);
			this.Controls.Add(this.txt_OkulNo);
			this.Controls.Add(this.txtCapca);
			this.Controls.Add(this.txt_TCNo);
			this.Controls.Add(this.pictureBox1);
			this.Name = "OgrenciGiris";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "BÇAL Yönetim Bilgi Sistemi ";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pSistemdenCikis)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btn_Giris;
		private System.Windows.Forms.TextBox txt_OkulNo;
		private System.Windows.Forms.TextBox txtCapca;
		private System.Windows.Forms.TextBox txt_TCNo;
		private System.Windows.Forms.PictureBox pSistemdenCikis;
	}
}