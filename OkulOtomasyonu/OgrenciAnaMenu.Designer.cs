namespace OkulOtomasyonu
{
	partial class OgrenciAnaMenu
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OgrenciAnaMenu));
			System.Windows.Forms.TreeNode treeNode40 = new System.Windows.Forms.TreeNode("Sınav Tarihleri");
			System.Windows.Forms.TreeNode treeNode41 = new System.Windows.Forms.TreeNode("Sınav Sonuçları");
			System.Windows.Forms.TreeNode treeNode42 = new System.Windows.Forms.TreeNode("Sınav Bilgileri", new System.Windows.Forms.TreeNode[] {
            treeNode40,
            treeNode41});
			System.Windows.Forms.TreeNode treeNode43 = new System.Windows.Forms.TreeNode("Duyurular");
			System.Windows.Forms.TreeNode treeNode44 = new System.Windows.Forms.TreeNode("Devamsızlık Bilgisi");
			System.Windows.Forms.TreeNode treeNode45 = new System.Windows.Forms.TreeNode("Haftalık Ders Programı");
			System.Windows.Forms.TreeNode treeNode46 = new System.Windows.Forms.TreeNode("Kişisel Bilgiler");
			System.Windows.Forms.TreeNode treeNode47 = new System.Windows.Forms.TreeNode("Aldığı Belgeler");
			System.Windows.Forms.TreeNode treeNode48 = new System.Windows.Forms.TreeNode("Pansiyon Ödeme Bilgileri");
			System.Windows.Forms.TreeNode treeNode49 = new System.Windows.Forms.TreeNode("Ortalama Yükseltme Puanları");
			System.Windows.Forms.TreeNode treeNode50 = new System.Windows.Forms.TreeNode("Nakil Durumu");
			System.Windows.Forms.TreeNode treeNode51 = new System.Windows.Forms.TreeNode("Şube Yazılı Ortalamaları");
			System.Windows.Forms.TreeNode treeNode52 = new System.Windows.Forms.TreeNode("Öğrenci Bilgileri", new System.Windows.Forms.TreeNode[] {
            treeNode43,
            treeNode44,
            treeNode45,
            treeNode46,
            treeNode47,
            treeNode48,
            treeNode49,
            treeNode50,
            treeNode51});
			this.btn_Cikis = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.lblGirisYapanKullaniciAdi = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.lblOgrenciSinif = new System.Windows.Forms.Label();
			this.treeView1 = new System.Windows.Forms.TreeView();
			this.lblAnlikSaat = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// btn_Cikis
			// 
			this.btn_Cikis.Location = new System.Drawing.Point(31, 179);
			this.btn_Cikis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btn_Cikis.Name = "btn_Cikis";
			this.btn_Cikis.Size = new System.Drawing.Size(115, 32);
			this.btn_Cikis.TabIndex = 1;
			this.btn_Cikis.Text = "Çıkış Yap";
			this.btn_Cikis.UseVisualStyleBackColor = true;
			this.btn_Cikis.Click += new System.EventHandler(this.btn_Cikis_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(1, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(1350, 631);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			// 
			// lblGirisYapanKullaniciAdi
			// 
			this.lblGirisYapanKullaniciAdi.AutoSize = true;
			this.lblGirisYapanKullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblGirisYapanKullaniciAdi.ForeColor = System.Drawing.Color.SkyBlue;
			this.lblGirisYapanKullaniciAdi.Location = new System.Drawing.Point(38, 128);
			this.lblGirisYapanKullaniciAdi.Name = "lblGirisYapanKullaniciAdi";
			this.lblGirisYapanKullaniciAdi.Size = new System.Drawing.Size(108, 20);
			this.lblGirisYapanKullaniciAdi.TabIndex = 3;
			this.lblGirisYapanKullaniciAdi.Text = "adı yazacak";
			// 
			// lblOgrenciSinif
			// 
			this.lblOgrenciSinif.AutoSize = true;
			this.lblOgrenciSinif.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblOgrenciSinif.ForeColor = System.Drawing.Color.Red;
			this.lblOgrenciSinif.Location = new System.Drawing.Point(39, 159);
			this.lblOgrenciSinif.Name = "lblOgrenciSinif";
			this.lblOgrenciSinif.Size = new System.Drawing.Size(110, 18);
			this.lblOgrenciSinif.TabIndex = 3;
			this.lblOgrenciSinif.Text = "sınıfı yazacak";
			// 
			// treeView1
			// 
			this.treeView1.Location = new System.Drawing.Point(1, 216);
			this.treeView1.Name = "treeView1";
			treeNode40.Name = "Node13";
			treeNode40.Text = "Sınav Tarihleri";
			treeNode41.Name = "Node0";
			treeNode41.Text = "Sınav Sonuçları";
			treeNode42.Name = "Node0";
			treeNode42.Text = "Sınav Bilgileri";
			treeNode43.Name = "Node1";
			treeNode43.Text = "Duyurular";
			treeNode44.Name = "Node2";
			treeNode44.Text = "Devamsızlık Bilgisi";
			treeNode45.Name = "Node4";
			treeNode45.Text = "Haftalık Ders Programı";
			treeNode46.Name = "Node6";
			treeNode46.Text = "Kişisel Bilgiler";
			treeNode47.Name = "Node7";
			treeNode47.Text = "Aldığı Belgeler";
			treeNode48.Name = "Node8";
			treeNode48.Text = "Pansiyon Ödeme Bilgileri";
			treeNode49.Name = "Node10";
			treeNode49.Text = "Ortalama Yükseltme Puanları";
			treeNode50.Name = "Node11";
			treeNode50.Text = "Nakil Durumu";
			treeNode51.Name = "Node12";
			treeNode51.Text = "Şube Yazılı Ortalamaları";
			treeNode52.Name = "Node0";
			treeNode52.Text = "Öğrenci Bilgileri";
			this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode42,
            treeNode52});
			this.treeView1.Size = new System.Drawing.Size(229, 396);
			this.treeView1.TabIndex = 4;
			// 
			// lblAnlikSaat
			// 
			this.lblAnlikSaat.AutoSize = true;
			this.lblAnlikSaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
			this.lblAnlikSaat.ForeColor = System.Drawing.Color.IndianRed;
			this.lblAnlikSaat.Location = new System.Drawing.Point(1230, 20);
			this.lblAnlikSaat.Name = "lblAnlikSaat";
			this.lblAnlikSaat.Size = new System.Drawing.Size(188, 20);
			this.lblAnlikSaat.TabIndex = 3;
			this.lblAnlikSaat.Text = "anlık saat gösterecek";
			// 
			// OgrenciAnaMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1347, 633);
			this.Controls.Add(this.treeView1);
			this.Controls.Add(this.lblAnlikSaat);
			this.Controls.Add(this.lblOgrenciSinif);
			this.Controls.Add(this.lblGirisYapanKullaniciAdi);
			this.Controls.Add(this.btn_Cikis);
			this.Controls.Add(this.pictureBox1);
			this.Name = "OgrenciAnaMenu";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "BÇAL Yönetim Bilgi Sistemi ";
			this.Load += new System.EventHandler(this.OgrenciAnaMenu_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btn_Cikis;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label lblGirisYapanKullaniciAdi;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Label lblOgrenciSinif;
		private System.Windows.Forms.TreeView treeView1;
		private System.Windows.Forms.Label lblAnlikSaat;
	}
}