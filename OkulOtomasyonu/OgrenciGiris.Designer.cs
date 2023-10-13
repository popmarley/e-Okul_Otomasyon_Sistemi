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
			this.btnSistemdenCikis = new System.Windows.Forms.Button();
			this.btn_Giris = new System.Windows.Forms.Button();
			this.txt_Password = new System.Windows.Forms.TextBox();
			this.txtCapca = new System.Windows.Forms.TextBox();
			this.txt_UserName = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
			this.label2.Location = new System.Drawing.Point(400, 295);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(99, 27);
			this.label2.TabIndex = 10;
			this.label2.Text = "Şifreniz:";
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
			this.label1.Location = new System.Drawing.Point(309, 193);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(190, 54);
			this.label1.TabIndex = 12;
			this.label1.Text = "Kullanıcı Adınız\r\nyada E-postanız :";
			// 
			// btnSistemdenCikis
			// 
			this.btnSistemdenCikis.BackColor = System.Drawing.Color.IndianRed;
			this.btnSistemdenCikis.Font = new System.Drawing.Font("Montserrat Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnSistemdenCikis.Location = new System.Drawing.Point(731, 26);
			this.btnSistemdenCikis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnSistemdenCikis.Name = "btnSistemdenCikis";
			this.btnSistemdenCikis.Size = new System.Drawing.Size(116, 73);
			this.btnSistemdenCikis.TabIndex = 13;
			this.btnSistemdenCikis.Text = "Ana Menüye Dön";
			this.btnSistemdenCikis.UseVisualStyleBackColor = false;
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
			// 
			// txt_Password
			// 
			this.txt_Password.Location = new System.Drawing.Point(515, 300);
			this.txt_Password.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txt_Password.MaxLength = 8;
			this.txt_Password.Name = "txt_Password";
			this.txt_Password.PasswordChar = '*';
			this.txt_Password.Size = new System.Drawing.Size(221, 22);
			this.txt_Password.TabIndex = 8;
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
			// txt_UserName
			// 
			this.txt_UserName.Location = new System.Drawing.Point(515, 211);
			this.txt_UserName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txt_UserName.MaxLength = 32;
			this.txt_UserName.Name = "txt_UserName";
			this.txt_UserName.Size = new System.Drawing.Size(221, 22);
			this.txt_UserName.TabIndex = 7;
			// 
			// OgrenciGiris
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1347, 633);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnSistemdenCikis);
			this.Controls.Add(this.btn_Giris);
			this.Controls.Add(this.txt_Password);
			this.Controls.Add(this.txtCapca);
			this.Controls.Add(this.txt_UserName);
			this.Controls.Add(this.pictureBox1);
			this.Name = "OgrenciGiris";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "OgrenciGiris";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnSistemdenCikis;
		private System.Windows.Forms.Button btn_Giris;
		private System.Windows.Forms.TextBox txt_Password;
		private System.Windows.Forms.TextBox txtCapca;
		private System.Windows.Forms.TextBox txt_UserName;
	}
}