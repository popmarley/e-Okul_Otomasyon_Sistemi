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
			System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Sınav Tarihleri");
			System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Sınav Sonuçları");
			System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Sınav Bilgileri", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
			System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Duyurular");
			System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Devamsızlık Bilgisi");
			System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Haftalık Ders Programı");
			System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Kişisel Bilgiler");
			System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Aldığı Belgeler");
			System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Pansiyon Ödeme Bilgileri");
			System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Ortalama Yükseltme Puanları");
			System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Nakil Durumu");
			System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Şube Yazılı Ortalamaları");
			System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Öğrenci Bilgileri", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode11,
            treeNode12});
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
			this.btn_Cikis.Location = new System.Drawing.Point(42, 188);
			this.btn_Cikis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btn_Cikis.Name = "btn_Cikis";
			this.btn_Cikis.Size = new System.Drawing.Size(115, 23);
			this.btn_Cikis.TabIndex = 1;
			this.btn_Cikis.Text = "Çıkış Yap";
			this.btn_Cikis.UseVisualStyleBackColor = true;
			this.btn_Cikis.Click += new System.EventHandler(this.btn_Cikis_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(26, 9);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(146, 121);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			// 
			// lblGirisYapanKullaniciAdi
			// 
			this.lblGirisYapanKullaniciAdi.AutoSize = true;
			this.lblGirisYapanKullaniciAdi.Location = new System.Drawing.Point(59, 133);
			this.lblGirisYapanKullaniciAdi.Name = "lblGirisYapanKullaniciAdi";
			this.lblGirisYapanKullaniciAdi.Size = new System.Drawing.Size(80, 16);
			this.lblGirisYapanKullaniciAdi.TabIndex = 3;
			this.lblGirisYapanKullaniciAdi.Text = "adı yazacak";
			// 
			// lblOgrenciSinif
			// 
			this.lblOgrenciSinif.AutoSize = true;
			this.lblOgrenciSinif.Location = new System.Drawing.Point(59, 160);
			this.lblOgrenciSinif.Name = "lblOgrenciSinif";
			this.lblOgrenciSinif.Size = new System.Drawing.Size(87, 16);
			this.lblOgrenciSinif.TabIndex = 3;
			this.lblOgrenciSinif.Text = "sınıfı yazacak";
			// 
			// treeView1
			// 
			this.treeView1.Location = new System.Drawing.Point(1, 216);
			this.treeView1.Name = "treeView1";
			treeNode1.Name = "Node13";
			treeNode1.Text = "Sınav Tarihleri";
			treeNode2.Name = "Node0";
			treeNode2.Text = "Sınav Sonuçları";
			treeNode3.Name = "Node0";
			treeNode3.Text = "Sınav Bilgileri";
			treeNode4.Name = "Node1";
			treeNode4.Text = "Duyurular";
			treeNode5.Name = "Node2";
			treeNode5.Text = "Devamsızlık Bilgisi";
			treeNode6.Name = "Node4";
			treeNode6.Text = "Haftalık Ders Programı";
			treeNode7.Name = "Node6";
			treeNode7.Text = "Kişisel Bilgiler";
			treeNode8.Name = "Node7";
			treeNode8.Text = "Aldığı Belgeler";
			treeNode9.Name = "Node8";
			treeNode9.Text = "Pansiyon Ödeme Bilgileri";
			treeNode10.Name = "Node10";
			treeNode10.Text = "Ortalama Yükseltme Puanları";
			treeNode11.Name = "Node11";
			treeNode11.Text = "Nakil Durumu";
			treeNode12.Name = "Node12";
			treeNode12.Text = "Şube Yazılı Ortalamaları";
			treeNode13.Name = "Node0";
			treeNode13.Text = "Öğrenci Bilgileri";
			this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode13});
			this.treeView1.Size = new System.Drawing.Size(229, 396);
			this.treeView1.TabIndex = 4;
			// 
			// lblAnlikSaat
			// 
			this.lblAnlikSaat.AutoSize = true;
			this.lblAnlikSaat.Location = new System.Drawing.Point(1200, 9);
			this.lblAnlikSaat.Name = "lblAnlikSaat";
			this.lblAnlikSaat.Size = new System.Drawing.Size(135, 16);
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
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btn_Cikis);
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