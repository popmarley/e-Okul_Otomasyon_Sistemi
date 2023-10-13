namespace OkulOtomasyonu
{
	partial class Giris
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
			this.txt_UserName = new System.Windows.Forms.TextBox();
			this.txt_Password = new System.Windows.Forms.TextBox();
			this.btn_Giris = new System.Windows.Forms.Button();
			this.lbl_KayitOl = new System.Windows.Forms.LinkLabel();
			this.lbl_SifremiUnuttum = new System.Windows.Forms.LinkLabel();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnSistemdenCikis = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txt_UserName
			// 
			this.txt_UserName.Location = new System.Drawing.Point(299, 112);
			this.txt_UserName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txt_UserName.Name = "txt_UserName";
			this.txt_UserName.Size = new System.Drawing.Size(100, 22);
			this.txt_UserName.TabIndex = 0;
			// 
			// txt_Password
			// 
			this.txt_Password.Location = new System.Drawing.Point(299, 212);
			this.txt_Password.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txt_Password.Name = "txt_Password";
			this.txt_Password.Size = new System.Drawing.Size(100, 22);
			this.txt_Password.TabIndex = 1;
			// 
			// btn_Giris
			// 
			this.btn_Giris.Location = new System.Drawing.Point(315, 309);
			this.btn_Giris.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btn_Giris.Name = "btn_Giris";
			this.btn_Giris.Size = new System.Drawing.Size(75, 23);
			this.btn_Giris.TabIndex = 2;
			this.btn_Giris.Text = "Giriş";
			this.btn_Giris.UseVisualStyleBackColor = true;
			this.btn_Giris.Click += new System.EventHandler(this.btn_Giris_Click);
			// 
			// lbl_KayitOl
			// 
			this.lbl_KayitOl.AutoSize = true;
			this.lbl_KayitOl.Location = new System.Drawing.Point(245, 369);
			this.lbl_KayitOl.Name = "lbl_KayitOl";
			this.lbl_KayitOl.Size = new System.Drawing.Size(52, 16);
			this.lbl_KayitOl.TabIndex = 3;
			this.lbl_KayitOl.TabStop = true;
			this.lbl_KayitOl.Text = "Kayıt Ol";
			this.lbl_KayitOl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_KayitOl_LinkClicked);
			// 
			// lbl_SifremiUnuttum
			// 
			this.lbl_SifremiUnuttum.AutoSize = true;
			this.lbl_SifremiUnuttum.Location = new System.Drawing.Point(413, 369);
			this.lbl_SifremiUnuttum.Name = "lbl_SifremiUnuttum";
			this.lbl_SifremiUnuttum.Size = new System.Drawing.Size(99, 16);
			this.lbl_SifremiUnuttum.TabIndex = 4;
			this.lbl_SifremiUnuttum.TabStop = true;
			this.lbl_SifremiUnuttum.Text = "Şifremi Unuttum";
			this.lbl_SifremiUnuttum.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_SifremiUnuttum_LinkClicked);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(200, 118);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(82, 16);
			this.label1.TabIndex = 5;
			this.label1.Text = "Kullanıcı Adı:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(245, 218);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(37, 16);
			this.label2.TabIndex = 5;
			this.label2.Text = "Şifre:";
			// 
			// btnSistemdenCikis
			// 
			this.btnSistemdenCikis.Location = new System.Drawing.Point(588, 38);
			this.btnSistemdenCikis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnSistemdenCikis.Name = "btnSistemdenCikis";
			this.btnSistemdenCikis.Size = new System.Drawing.Size(86, 45);
			this.btnSistemdenCikis.TabIndex = 2;
			this.btnSistemdenCikis.Text = "Sistemden Çıkış";
			this.btnSistemdenCikis.UseVisualStyleBackColor = true;
			this.btnSistemdenCikis.Click += new System.EventHandler(this.btnSistemdenCikis_Click);
			// 
			// Giris
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lbl_SifremiUnuttum);
			this.Controls.Add(this.lbl_KayitOl);
			this.Controls.Add(this.btnSistemdenCikis);
			this.Controls.Add(this.btn_Giris);
			this.Controls.Add(this.txt_Password);
			this.Controls.Add(this.txt_UserName);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "Giris";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "BÇAL Yönetim Bilgi Sistemi ";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txt_UserName;
		private System.Windows.Forms.TextBox txt_Password;
		private System.Windows.Forms.Button btn_Giris;
		private System.Windows.Forms.LinkLabel lbl_KayitOl;
		private System.Windows.Forms.LinkLabel lbl_SifremiUnuttum;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnSistemdenCikis;
	}
}

