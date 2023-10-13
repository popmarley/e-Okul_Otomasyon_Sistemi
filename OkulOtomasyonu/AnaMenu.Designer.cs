namespace OkulOtomasyonu
{
	partial class AnaMenu
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
			this.btn_Cikis = new System.Windows.Forms.Button();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.menuStrip2 = new System.Windows.Forms.MenuStrip();
			this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.yönetimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.raporlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.yardımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip2.SuspendLayout();
			this.SuspendLayout();
			// 
			// btn_Cikis
			// 
			this.btn_Cikis.Location = new System.Drawing.Point(511, 138);
			this.btn_Cikis.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btn_Cikis.Name = "btn_Cikis";
			this.btn_Cikis.Size = new System.Drawing.Size(56, 19);
			this.btn_Cikis.TabIndex = 0;
			this.btn_Cikis.Text = "Çıkış";
			this.btn_Cikis.UseVisualStyleBackColor = true;
			this.btn_Cikis.Click += new System.EventHandler(this.btn_Cikis_Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Location = new System.Drawing.Point(0, 24);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
			this.menuStrip1.Size = new System.Drawing.Size(600, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// menuStrip2
			// 
			this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.yönetimToolStripMenuItem,
            this.raporlarToolStripMenuItem,
            this.yardımToolStripMenuItem});
			this.menuStrip2.Location = new System.Drawing.Point(0, 0);
			this.menuStrip2.Name = "menuStrip2";
			this.menuStrip2.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
			this.menuStrip2.Size = new System.Drawing.Size(600, 24);
			this.menuStrip2.TabIndex = 2;
			this.menuStrip2.Text = "menuStrip2";
			// 
			// dosyaToolStripMenuItem
			// 
			this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
			this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
			this.dosyaToolStripMenuItem.Text = "Dosya";
			// 
			// yönetimToolStripMenuItem
			// 
			this.yönetimToolStripMenuItem.Name = "yönetimToolStripMenuItem";
			this.yönetimToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
			this.yönetimToolStripMenuItem.Text = "Yönetim";
			// 
			// raporlarToolStripMenuItem
			// 
			this.raporlarToolStripMenuItem.Name = "raporlarToolStripMenuItem";
			this.raporlarToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
			this.raporlarToolStripMenuItem.Text = "Raporlar";
			// 
			// yardımToolStripMenuItem
			// 
			this.yardımToolStripMenuItem.Name = "yardımToolStripMenuItem";
			this.yardımToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
			this.yardımToolStripMenuItem.Text = "Yardım";
			// 
			// AnaMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(600, 366);
			this.Controls.Add(this.btn_Cikis);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.menuStrip2);
			this.MainMenuStrip = this.menuStrip1;
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "AnaMenu";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AnaMenu";
			this.menuStrip2.ResumeLayout(false);
			this.menuStrip2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btn_Cikis;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.MenuStrip menuStrip2;
		private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem yönetimToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem raporlarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem yardımToolStripMenuItem;
	}
}