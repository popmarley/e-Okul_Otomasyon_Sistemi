﻿namespace OkulOtomasyonu
{
	partial class KayitOl
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
			this.btn_Geri = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btn_Geri
			// 
			this.btn_Geri.Location = new System.Drawing.Point(696, 22);
			this.btn_Geri.Name = "btn_Geri";
			this.btn_Geri.Size = new System.Drawing.Size(75, 23);
			this.btn_Geri.TabIndex = 0;
			this.btn_Geri.Text = "Geri";
			this.btn_Geri.UseVisualStyleBackColor = true;
			this.btn_Geri.Click += new System.EventHandler(this.btn_Geri_Click);
			// 
			// KayitOl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btn_Geri);
			this.Name = "KayitOl";
			this.Text = "KayıtOl";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btn_Geri;
	}
}