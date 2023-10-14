namespace OkulOtomasyonu
{
	partial class MudurAnaMenu
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MudurAnaMenu));
			System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Öğretmen Ekle/Sil");
			System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Öğretmen Listesi");
			System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Öğretmen Bilgi Güncelle");
			System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Öğretmen İşlemleri", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
			System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Öğrenci Ekle/Sil");
			System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Öğrenci Listesi");
			System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Öğrenci Bilgi Güncelle");
			System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Veli Bilgileri");
			System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Öğrenci Not Düzenle");
			System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Öğrenci İşlemleri", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9});
			System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Haftalık Ders Programı");
			System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Ders ve Sınıf İşlemleri", new System.Windows.Forms.TreeNode[] {
            treeNode11});
			System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Genel Rapor");
			System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Raporlama", new System.Windows.Forms.TreeNode[] {
            treeNode13});
			this.btn_Cikis = new System.Windows.Forms.Button();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.lblAnlikSaat = new System.Windows.Forms.Label();
			this.lblOgrenciSinif = new System.Windows.Forms.Label();
			this.lblGirisYapanMudurKullaniciAdi = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.treeView1 = new System.Windows.Forms.TreeView();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// btn_Cikis
			// 
			this.btn_Cikis.Location = new System.Drawing.Point(49, 192);
			this.btn_Cikis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btn_Cikis.Name = "btn_Cikis";
			this.btn_Cikis.Size = new System.Drawing.Size(75, 23);
			this.btn_Cikis.TabIndex = 0;
			this.btn_Cikis.Text = "Çıkış Yap";
			this.btn_Cikis.UseVisualStyleBackColor = true;
			this.btn_Cikis.Click += new System.EventHandler(this.btn_Cikis_Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
			this.menuStrip1.Size = new System.Drawing.Size(1347, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// lblAnlikSaat
			// 
			this.lblAnlikSaat.AutoSize = true;
			this.lblAnlikSaat.Location = new System.Drawing.Point(1200, 9);
			this.lblAnlikSaat.Name = "lblAnlikSaat";
			this.lblAnlikSaat.Size = new System.Drawing.Size(135, 16);
			this.lblAnlikSaat.TabIndex = 8;
			this.lblAnlikSaat.Text = "anlık saat gösterecek";
			// 
			// lblOgrenciSinif
			// 
			this.lblOgrenciSinif.AutoSize = true;
			this.lblOgrenciSinif.Location = new System.Drawing.Point(29, 136);
			this.lblOgrenciSinif.Name = "lblOgrenciSinif";
			this.lblOgrenciSinif.Size = new System.Drawing.Size(109, 16);
			this.lblOgrenciSinif.TabIndex = 9;
			this.lblOgrenciSinif.Text = "Hoşgeldin Müdür";
			// 
			// lblGirisYapanMudurKullaniciAdi
			// 
			this.lblGirisYapanMudurKullaniciAdi.AutoSize = true;
			this.lblGirisYapanMudurKullaniciAdi.Location = new System.Drawing.Point(46, 165);
			this.lblGirisYapanMudurKullaniciAdi.Name = "lblGirisYapanMudurKullaniciAdi";
			this.lblGirisYapanMudurKullaniciAdi.Size = new System.Drawing.Size(80, 16);
			this.lblGirisYapanMudurKullaniciAdi.TabIndex = 10;
			this.lblGirisYapanMudurKullaniciAdi.Text = "adı yazacak";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(12, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(146, 121);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 7;
			this.pictureBox1.TabStop = false;
			// 
			// treeView1
			// 
			this.treeView1.Location = new System.Drawing.Point(0, 234);
			this.treeView1.Name = "treeView1";
			treeNode1.Name = "Node6";
			treeNode1.Text = "Öğretmen Ekle/Sil";
			treeNode2.Name = "Node7";
			treeNode2.Text = "Öğretmen Listesi";
			treeNode3.Name = "Node10";
			treeNode3.Text = "Öğretmen Bilgi Güncelle";
			treeNode4.Name = "Node0";
			treeNode4.Text = "Öğretmen İşlemleri";
			treeNode5.Name = "Node8";
			treeNode5.Text = "Öğrenci Ekle/Sil";
			treeNode6.Name = "Node9";
			treeNode6.Text = "Öğrenci Listesi";
			treeNode7.Name = "Node12";
			treeNode7.Text = "Öğrenci Bilgi Güncelle";
			treeNode8.Name = "Node13";
			treeNode8.Text = "Veli Bilgileri";
			treeNode9.Name = "Node17";
			treeNode9.Text = "Öğrenci Not Düzenle";
			treeNode10.Name = "Node1";
			treeNode10.Text = "Öğrenci İşlemleri";
			treeNode11.Name = "Node16";
			treeNode11.Text = "Haftalık Ders Programı";
			treeNode12.Name = "Node15";
			treeNode12.Text = "Ders ve Sınıf İşlemleri";
			treeNode13.Name = "Node14";
			treeNode13.Text = "Genel Rapor";
			treeNode14.Name = "Node3";
			treeNode14.Text = "Raporlama";
			this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode10,
            treeNode12,
            treeNode14});
			this.treeView1.Size = new System.Drawing.Size(210, 387);
			this.treeView1.TabIndex = 11;
			// 
			// MudurAnaMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1347, 633);
			this.Controls.Add(this.treeView1);
			this.Controls.Add(this.lblAnlikSaat);
			this.Controls.Add(this.lblOgrenciSinif);
			this.Controls.Add(this.lblGirisYapanMudurKullaniciAdi);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btn_Cikis);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "MudurAnaMenu";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "BÇAL Yönetim Bilgi Sistemi ";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btn_Cikis;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.Label lblAnlikSaat;
		private System.Windows.Forms.Label lblOgrenciSinif;
		private System.Windows.Forms.Label lblGirisYapanMudurKullaniciAdi;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TreeView treeView1;
		private System.Windows.Forms.Timer timer1;
	}
}