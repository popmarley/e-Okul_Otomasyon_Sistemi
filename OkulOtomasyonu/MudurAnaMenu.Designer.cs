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
			System.Windows.Forms.TreeNode treeNode99 = new System.Windows.Forms.TreeNode("Öğretmen Listesi");
			System.Windows.Forms.TreeNode treeNode100 = new System.Windows.Forms.TreeNode("Öğretmen Bilgi Güncelle");
			System.Windows.Forms.TreeNode treeNode101 = new System.Windows.Forms.TreeNode("Öğretmen Sil");
			System.Windows.Forms.TreeNode treeNode102 = new System.Windows.Forms.TreeNode("Öğretmen İşlemleri", new System.Windows.Forms.TreeNode[] {
            treeNode99,
            treeNode100,
            treeNode101});
			System.Windows.Forms.TreeNode treeNode103 = new System.Windows.Forms.TreeNode("Öğrenci Listesi");
			System.Windows.Forms.TreeNode treeNode104 = new System.Windows.Forms.TreeNode("Öğrenci Ekle/Sil");
			System.Windows.Forms.TreeNode treeNode105 = new System.Windows.Forms.TreeNode("Öğrenci Bilgi Güncelle");
			System.Windows.Forms.TreeNode treeNode106 = new System.Windows.Forms.TreeNode("Veli Bilgileri");
			System.Windows.Forms.TreeNode treeNode107 = new System.Windows.Forms.TreeNode("Öğrenci Not Düzenle");
			System.Windows.Forms.TreeNode treeNode108 = new System.Windows.Forms.TreeNode("Öğrenci İşlemleri", new System.Windows.Forms.TreeNode[] {
            treeNode103,
            treeNode104,
            treeNode105,
            treeNode106,
            treeNode107});
			System.Windows.Forms.TreeNode treeNode109 = new System.Windows.Forms.TreeNode("Haftalık Ders Programı");
			System.Windows.Forms.TreeNode treeNode110 = new System.Windows.Forms.TreeNode("Ders ve Sınıf İşlemleri", new System.Windows.Forms.TreeNode[] {
            treeNode109});
			System.Windows.Forms.TreeNode treeNode111 = new System.Windows.Forms.TreeNode("Genel Rapor");
			System.Windows.Forms.TreeNode treeNode112 = new System.Windows.Forms.TreeNode("Raporlama", new System.Windows.Forms.TreeNode[] {
            treeNode111});
			this.btn_Cikis = new System.Windows.Forms.Button();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.lblAnlikSaat = new System.Windows.Forms.Label();
			this.lblOgrenciSinif = new System.Windows.Forms.Label();
			this.lblGirisYapanMudurKullaniciAdi = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.treeView1 = new System.Windows.Forms.TreeView();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.gOgretmenGuncelle = new System.Windows.Forms.GroupBox();
			this.gOgretmenSil = new System.Windows.Forms.DataGridView();
			this.btnGuncelle = new System.Windows.Forms.Button();
			this.txtOgretmenDogumTarihi = new System.Windows.Forms.DateTimePicker();
			this.txtOgretmenTCNo = new System.Windows.Forms.TextBox();
			this.txtOgretmenSoyad = new System.Windows.Forms.TextBox();
			this.txtOgretmenAd = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.cOgretmenBrans = new System.Windows.Forms.ComboBox();
			this.cOgretmenListesi = new System.Windows.Forms.ComboBox();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.gOgretmenGuncelle.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gOgretmenSil)).BeginInit();
			this.SuspendLayout();
			// 
			// btn_Cikis
			// 
			this.btn_Cikis.Location = new System.Drawing.Point(37, 156);
			this.btn_Cikis.Margin = new System.Windows.Forms.Padding(2);
			this.btn_Cikis.Name = "btn_Cikis";
			this.btn_Cikis.Size = new System.Drawing.Size(56, 19);
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
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
			this.menuStrip1.Size = new System.Drawing.Size(1010, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// lblAnlikSaat
			// 
			this.lblAnlikSaat.AutoSize = true;
			this.lblAnlikSaat.Location = new System.Drawing.Point(900, 7);
			this.lblAnlikSaat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblAnlikSaat.Name = "lblAnlikSaat";
			this.lblAnlikSaat.Size = new System.Drawing.Size(108, 13);
			this.lblAnlikSaat.TabIndex = 8;
			this.lblAnlikSaat.Text = "anlık saat gösterecek";
			// 
			// lblOgrenciSinif
			// 
			this.lblOgrenciSinif.AutoSize = true;
			this.lblOgrenciSinif.Location = new System.Drawing.Point(22, 110);
			this.lblOgrenciSinif.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblOgrenciSinif.Name = "lblOgrenciSinif";
			this.lblOgrenciSinif.Size = new System.Drawing.Size(87, 13);
			this.lblOgrenciSinif.TabIndex = 9;
			this.lblOgrenciSinif.Text = "Hoşgeldin Müdür";
			// 
			// lblGirisYapanMudurKullaniciAdi
			// 
			this.lblGirisYapanMudurKullaniciAdi.AutoSize = true;
			this.lblGirisYapanMudurKullaniciAdi.Location = new System.Drawing.Point(34, 134);
			this.lblGirisYapanMudurKullaniciAdi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblGirisYapanMudurKullaniciAdi.Name = "lblGirisYapanMudurKullaniciAdi";
			this.lblGirisYapanMudurKullaniciAdi.Size = new System.Drawing.Size(64, 13);
			this.lblGirisYapanMudurKullaniciAdi.TabIndex = 10;
			this.lblGirisYapanMudurKullaniciAdi.Text = "adı yazacak";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(9, 10);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(110, 98);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 7;
			this.pictureBox1.TabStop = false;
			// 
			// treeView1
			// 
			this.treeView1.Location = new System.Drawing.Point(0, 190);
			this.treeView1.Margin = new System.Windows.Forms.Padding(2);
			this.treeView1.Name = "treeView1";
			treeNode99.Name = "ogretmenListesi";
			treeNode99.Text = "Öğretmen Listesi";
			treeNode100.Name = "ogretmenBilgiGuncelle";
			treeNode100.Text = "Öğretmen Bilgi Güncelle";
			treeNode101.Name = "OgretmenSil";
			treeNode101.Text = "Öğretmen Sil";
			treeNode102.Name = "Node0";
			treeNode102.Text = "Öğretmen İşlemleri";
			treeNode103.Name = "ogrenciListesi";
			treeNode103.Text = "Öğrenci Listesi";
			treeNode104.Name = "Node8";
			treeNode104.Text = "Öğrenci Ekle/Sil";
			treeNode105.Name = "Node12";
			treeNode105.Text = "Öğrenci Bilgi Güncelle";
			treeNode106.Name = "Node13";
			treeNode106.Text = "Veli Bilgileri";
			treeNode107.Name = "Node17";
			treeNode107.Text = "Öğrenci Not Düzenle";
			treeNode108.Name = "Node1";
			treeNode108.Text = "Öğrenci İşlemleri";
			treeNode109.Name = "Node16";
			treeNode109.Text = "Haftalık Ders Programı";
			treeNode110.Name = "Node15";
			treeNode110.Text = "Ders ve Sınıf İşlemleri";
			treeNode111.Name = "Node14";
			treeNode111.Text = "Genel Rapor";
			treeNode112.Name = "Node3";
			treeNode112.Text = "Raporlama";
			this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode102,
            treeNode108,
            treeNode110,
            treeNode112});
			this.treeView1.Size = new System.Drawing.Size(158, 315);
			this.treeView1.TabIndex = 11;
			this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(166, 190);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(723, 313);
			this.dataGridView1.TabIndex = 12;
			this.dataGridView1.Visible = false;
			// 
			// gOgretmenGuncelle
			// 
			this.gOgretmenGuncelle.Controls.Add(this.btnGuncelle);
			this.gOgretmenGuncelle.Controls.Add(this.txtOgretmenDogumTarihi);
			this.gOgretmenGuncelle.Controls.Add(this.txtOgretmenTCNo);
			this.gOgretmenGuncelle.Controls.Add(this.txtOgretmenSoyad);
			this.gOgretmenGuncelle.Controls.Add(this.txtOgretmenAd);
			this.gOgretmenGuncelle.Controls.Add(this.label6);
			this.gOgretmenGuncelle.Controls.Add(this.label5);
			this.gOgretmenGuncelle.Controls.Add(this.label4);
			this.gOgretmenGuncelle.Controls.Add(this.label3);
			this.gOgretmenGuncelle.Controls.Add(this.label2);
			this.gOgretmenGuncelle.Controls.Add(this.label1);
			this.gOgretmenGuncelle.Controls.Add(this.cOgretmenBrans);
			this.gOgretmenGuncelle.Controls.Add(this.cOgretmenListesi);
			this.gOgretmenGuncelle.Location = new System.Drawing.Point(162, 190);
			this.gOgretmenGuncelle.Margin = new System.Windows.Forms.Padding(2);
			this.gOgretmenGuncelle.Name = "gOgretmenGuncelle";
			this.gOgretmenGuncelle.Padding = new System.Windows.Forms.Padding(2);
			this.gOgretmenGuncelle.Size = new System.Drawing.Size(392, 314);
			this.gOgretmenGuncelle.TabIndex = 13;
			this.gOgretmenGuncelle.TabStop = false;
			this.gOgretmenGuncelle.Visible = false;
			// 
			// gOgretmenSil
			// 
			this.gOgretmenSil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gOgretmenSil.Location = new System.Drawing.Point(166, 190);
			this.gOgretmenSil.Margin = new System.Windows.Forms.Padding(2);
			this.gOgretmenSil.Name = "gOgretmenSil";
			this.gOgretmenSil.RowHeadersWidth = 51;
			this.gOgretmenSil.RowTemplate.Height = 24;
			this.gOgretmenSil.Size = new System.Drawing.Size(723, 310);
			this.gOgretmenSil.TabIndex = 14;
			this.gOgretmenSil.Visible = false;
			this.gOgretmenSil.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
			// 
			// btnGuncelle
			// 
			this.btnGuncelle.Location = new System.Drawing.Point(185, 236);
			this.btnGuncelle.Margin = new System.Windows.Forms.Padding(2);
			this.btnGuncelle.Name = "btnGuncelle";
			this.btnGuncelle.Size = new System.Drawing.Size(67, 28);
			this.btnGuncelle.TabIndex = 4;
			this.btnGuncelle.Text = "Güncelle";
			this.btnGuncelle.UseVisualStyleBackColor = true;
			this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
			// 
			// txtOgretmenDogumTarihi
			// 
			this.txtOgretmenDogumTarihi.Location = new System.Drawing.Point(158, 158);
			this.txtOgretmenDogumTarihi.Margin = new System.Windows.Forms.Padding(2);
			this.txtOgretmenDogumTarihi.Name = "txtOgretmenDogumTarihi";
			this.txtOgretmenDogumTarihi.Size = new System.Drawing.Size(133, 20);
			this.txtOgretmenDogumTarihi.TabIndex = 3;
			// 
			// txtOgretmenTCNo
			// 
			this.txtOgretmenTCNo.Location = new System.Drawing.Point(158, 121);
			this.txtOgretmenTCNo.Margin = new System.Windows.Forms.Padding(2);
			this.txtOgretmenTCNo.Name = "txtOgretmenTCNo";
			this.txtOgretmenTCNo.Size = new System.Drawing.Size(133, 20);
			this.txtOgretmenTCNo.TabIndex = 2;
			// 
			// txtOgretmenSoyad
			// 
			this.txtOgretmenSoyad.Location = new System.Drawing.Point(158, 88);
			this.txtOgretmenSoyad.Margin = new System.Windows.Forms.Padding(2);
			this.txtOgretmenSoyad.Name = "txtOgretmenSoyad";
			this.txtOgretmenSoyad.Size = new System.Drawing.Size(133, 20);
			this.txtOgretmenSoyad.TabIndex = 2;
			// 
			// txtOgretmenAd
			// 
			this.txtOgretmenAd.Location = new System.Drawing.Point(158, 56);
			this.txtOgretmenAd.Margin = new System.Windows.Forms.Padding(2);
			this.txtOgretmenAd.Name = "txtOgretmenAd";
			this.txtOgretmenAd.Size = new System.Drawing.Size(133, 20);
			this.txtOgretmenAd.TabIndex = 2;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(109, 196);
			this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(39, 13);
			this.label6.TabIndex = 1;
			this.label6.Text = "Branşı:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(76, 162);
			this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(73, 13);
			this.label5.TabIndex = 1;
			this.label5.Text = "Doğum Tarihi:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(104, 124);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(47, 13);
			this.label4.TabIndex = 1;
			this.label4.Text = "T.C. No:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(105, 93);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(42, 13);
			this.label3.TabIndex = 1;
			this.label3.Text = "Soyadı:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(122, 61);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(25, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Adı:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(68, 24);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(81, 26);
			this.label1.TabIndex = 1;
			this.label1.Text = "İşlem Yapılacak\r\nÖğretmen:\r\n";
			// 
			// cOgretmenBrans
			// 
			this.cOgretmenBrans.FormattingEnabled = true;
			this.cOgretmenBrans.Location = new System.Drawing.Point(158, 189);
			this.cOgretmenBrans.Margin = new System.Windows.Forms.Padding(2);
			this.cOgretmenBrans.Name = "cOgretmenBrans";
			this.cOgretmenBrans.Size = new System.Drawing.Size(133, 21);
			this.cOgretmenBrans.TabIndex = 0;
			// 
			// cOgretmenListesi
			// 
			this.cOgretmenListesi.FormattingEnabled = true;
			this.cOgretmenListesi.Location = new System.Drawing.Point(158, 24);
			this.cOgretmenListesi.Margin = new System.Windows.Forms.Padding(2);
			this.cOgretmenListesi.Name = "cOgretmenListesi";
			this.cOgretmenListesi.Size = new System.Drawing.Size(133, 21);
			this.cOgretmenListesi.TabIndex = 0;
			this.cOgretmenListesi.SelectedIndexChanged += new System.EventHandler(this.cOgretmenListesi_SelectedIndexChanged);
			// 
			// MudurAnaMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1010, 514);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.treeView1);
			this.Controls.Add(this.lblAnlikSaat);
			this.Controls.Add(this.lblOgrenciSinif);
			this.Controls.Add(this.lblGirisYapanMudurKullaniciAdi);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btn_Cikis);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.gOgretmenSil);
			this.Controls.Add(this.gOgretmenGuncelle);
			this.MainMenuStrip = this.menuStrip1;
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "MudurAnaMenu";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "BÇAL Yönetim Bilgi Sistemi ";
			this.Load += new System.EventHandler(this.MudurAnaMenu_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.gOgretmenGuncelle.ResumeLayout(false);
			this.gOgretmenGuncelle.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.gOgretmenSil)).EndInit();
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
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.GroupBox gOgretmenGuncelle;
		private System.Windows.Forms.Button btnGuncelle;
		private System.Windows.Forms.DateTimePicker txtOgretmenDogumTarihi;
		private System.Windows.Forms.TextBox txtOgretmenTCNo;
		private System.Windows.Forms.TextBox txtOgretmenSoyad;
		private System.Windows.Forms.TextBox txtOgretmenAd;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cOgretmenBrans;
		private System.Windows.Forms.ComboBox cOgretmenListesi;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private System.Windows.Forms.DataGridView gOgretmenSil;
	}
}