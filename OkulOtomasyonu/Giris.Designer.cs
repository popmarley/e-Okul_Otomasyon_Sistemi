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
			this.SuspendLayout();
			// 
			// txt_UserName
			// 
			this.txt_UserName.Location = new System.Drawing.Point(224, 91);
			this.txt_UserName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txt_UserName.Name = "txt_UserName";
			this.txt_UserName.Size = new System.Drawing.Size(76, 20);
			this.txt_UserName.TabIndex = 0;
			// 
			// txt_Password
			// 
			this.txt_Password.Location = new System.Drawing.Point(224, 172);
			this.txt_Password.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txt_Password.Name = "txt_Password";
			this.txt_Password.Size = new System.Drawing.Size(76, 20);
			this.txt_Password.TabIndex = 1;
			// 
			// btn_Giris
			// 
			this.btn_Giris.Location = new System.Drawing.Point(236, 251);
			this.btn_Giris.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btn_Giris.Name = "btn_Giris";
			this.btn_Giris.Size = new System.Drawing.Size(56, 19);
			this.btn_Giris.TabIndex = 2;
			this.btn_Giris.Text = "Giriş";
			this.btn_Giris.UseVisualStyleBackColor = true;
			this.btn_Giris.Click += new System.EventHandler(this.btn_Giris_Click);
			// 
			// lbl_KayitOl
			// 
			this.lbl_KayitOl.AutoSize = true;
			this.lbl_KayitOl.Location = new System.Drawing.Point(184, 300);
			this.lbl_KayitOl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbl_KayitOl.Name = "lbl_KayitOl";
			this.lbl_KayitOl.Size = new System.Drawing.Size(43, 13);
			this.lbl_KayitOl.TabIndex = 3;
			this.lbl_KayitOl.TabStop = true;
			this.lbl_KayitOl.Text = "Kayıt Ol";
			this.lbl_KayitOl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_KayitOl_LinkClicked);
			// 
			// lbl_SifremiUnuttum
			// 
			this.lbl_SifremiUnuttum.AutoSize = true;
			this.lbl_SifremiUnuttum.Location = new System.Drawing.Point(310, 300);
			this.lbl_SifremiUnuttum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbl_SifremiUnuttum.Name = "lbl_SifremiUnuttum";
			this.lbl_SifremiUnuttum.Size = new System.Drawing.Size(81, 13);
			this.lbl_SifremiUnuttum.TabIndex = 4;
			this.lbl_SifremiUnuttum.TabStop = true;
			this.lbl_SifremiUnuttum.Text = "Şifremi Unuttum";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(150, 96);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(67, 13);
			this.label1.TabIndex = 5;
			this.label1.Text = "Kullanıcı Adı:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(184, 177);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(31, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Şifre:";
			// 
			// Giris
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(600, 366);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lbl_SifremiUnuttum);
			this.Controls.Add(this.lbl_KayitOl);
			this.Controls.Add(this.btn_Giris);
			this.Controls.Add(this.txt_Password);
			this.Controls.Add(this.txt_UserName);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "Giris";
			this.Text = "BÇAL Yönetim Bilgi Sistemi I Giriş Ekranı ";
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
	}
}

