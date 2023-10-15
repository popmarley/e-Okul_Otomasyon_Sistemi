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
			System.Windows.Forms.TreeNode treeNode43 = new System.Windows.Forms.TreeNode("Öğretmen Listesi");
			System.Windows.Forms.TreeNode treeNode44 = new System.Windows.Forms.TreeNode("Öğretmen Bilgi Güncelle");
			System.Windows.Forms.TreeNode treeNode45 = new System.Windows.Forms.TreeNode("Öğretmen Sil");
			System.Windows.Forms.TreeNode treeNode46 = new System.Windows.Forms.TreeNode("Öğretmen İşlemleri", new System.Windows.Forms.TreeNode[] {
            treeNode43,
            treeNode44,
            treeNode45});
			System.Windows.Forms.TreeNode treeNode47 = new System.Windows.Forms.TreeNode("Öğrenci Listesi");
			System.Windows.Forms.TreeNode treeNode48 = new System.Windows.Forms.TreeNode("Öğrenci Bilgi Güncelle");
			System.Windows.Forms.TreeNode treeNode49 = new System.Windows.Forms.TreeNode("Öğrenci Sil");
			System.Windows.Forms.TreeNode treeNode50 = new System.Windows.Forms.TreeNode("Veli Bilgileri");
			System.Windows.Forms.TreeNode treeNode51 = new System.Windows.Forms.TreeNode("Öğrenci Not Düzenle");
			System.Windows.Forms.TreeNode treeNode52 = new System.Windows.Forms.TreeNode("Öğrenci İşlemleri", new System.Windows.Forms.TreeNode[] {
            treeNode47,
            treeNode48,
            treeNode49,
            treeNode50,
            treeNode51});
			System.Windows.Forms.TreeNode treeNode53 = new System.Windows.Forms.TreeNode("Haftalık Ders Programı");
			System.Windows.Forms.TreeNode treeNode54 = new System.Windows.Forms.TreeNode("Ders ve Sınıf İşlemleri", new System.Windows.Forms.TreeNode[] {
            treeNode53});
			System.Windows.Forms.TreeNode treeNode55 = new System.Windows.Forms.TreeNode("Genel Rapor");
			System.Windows.Forms.TreeNode treeNode56 = new System.Windows.Forms.TreeNode("Raporlama", new System.Windows.Forms.TreeNode[] {
            treeNode55});
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MudurAnaMenu));
			this.btn_Cikis = new System.Windows.Forms.Button();
			this.lblAnlikSaat = new System.Windows.Forms.Label();
			this.lblGirisYapanMudurKullaniciAdi = new System.Windows.Forms.Label();
			this.treeView1 = new System.Windows.Forms.TreeView();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.gOgretmenGuncelle = new System.Windows.Forms.GroupBox();
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
			this.gOgretmenSil = new System.Windows.Forms.DataGridView();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.gOgrenciGuncelle = new System.Windows.Forms.GroupBox();
			this.btnOgrenciGuncelle = new System.Windows.Forms.Button();
			this.dOgrenciDogumTarihi = new System.Windows.Forms.DateTimePicker();
			this.txtOgrenciAdresi = new System.Windows.Forms.TextBox();
			this.txtOgrenciNo = new System.Windows.Forms.TextBox();
			this.txtOgrenciTC = new System.Windows.Forms.TextBox();
			this.txtOgrenciSoyadi = new System.Windows.Forms.TextBox();
			this.txtOgrenciAdi = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.cOgrenciGuncelleme = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.gOgretmenGuncelle.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gOgretmenSil)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.gOgrenciGuncelle.SuspendLayout();
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
			// lblAnlikSaat
			// 
			this.lblAnlikSaat.AutoSize = true;
			this.lblAnlikSaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblAnlikSaat.ForeColor = System.Drawing.Color.IndianRed;
			this.lblAnlikSaat.Location = new System.Drawing.Point(1230, 22);
			this.lblAnlikSaat.Name = "lblAnlikSaat";
			this.lblAnlikSaat.Size = new System.Drawing.Size(188, 20);
			this.lblAnlikSaat.TabIndex = 8;
			this.lblAnlikSaat.Text = "anlık saat gösterecek";
			// 
			// lblGirisYapanMudurKullaniciAdi
			// 
			this.lblGirisYapanMudurKullaniciAdi.AutoSize = true;
			this.lblGirisYapanMudurKullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblGirisYapanMudurKullaniciAdi.ForeColor = System.Drawing.Color.SkyBlue;
			this.lblGirisYapanMudurKullaniciAdi.Location = new System.Drawing.Point(45, 165);
			this.lblGirisYapanMudurKullaniciAdi.Name = "lblGirisYapanMudurKullaniciAdi";
			this.lblGirisYapanMudurKullaniciAdi.Size = new System.Drawing.Size(108, 20);
			this.lblGirisYapanMudurKullaniciAdi.TabIndex = 10;
			this.lblGirisYapanMudurKullaniciAdi.Text = "adı yazacak";
			this.lblGirisYapanMudurKullaniciAdi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// treeView1
			// 
			this.treeView1.Location = new System.Drawing.Point(0, 234);
			this.treeView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.treeView1.Name = "treeView1";
			treeNode43.Name = "ogretmenListesi";
			treeNode43.Text = "Öğretmen Listesi";
			treeNode44.Name = "ogretmenBilgiGuncelle";
			treeNode44.Text = "Öğretmen Bilgi Güncelle";
			treeNode45.Name = "OgretmenSil";
			treeNode45.Text = "Öğretmen Sil";
			treeNode46.Name = "Node0";
			treeNode46.Text = "Öğretmen İşlemleri";
			treeNode47.Name = "ogrenciListesi";
			treeNode47.Text = "Öğrenci Listesi";
			treeNode48.Name = "ogrenciBilgiGuncelle";
			treeNode48.Text = "Öğrenci Bilgi Güncelle";
			treeNode49.Name = "Node8";
			treeNode49.Text = "Öğrenci Sil";
			treeNode50.Name = "Node13";
			treeNode50.Text = "Veli Bilgileri";
			treeNode51.Name = "Node17";
			treeNode51.Text = "Öğrenci Not Düzenle";
			treeNode52.Name = "Node1";
			treeNode52.Text = "Öğrenci İşlemleri";
			treeNode53.Name = "Node16";
			treeNode53.Text = "Haftalık Ders Programı";
			treeNode54.Name = "Node15";
			treeNode54.Text = "Ders ve Sınıf İşlemleri";
			treeNode55.Name = "Node14";
			treeNode55.Text = "Genel Rapor";
			treeNode56.Name = "Node3";
			treeNode56.Text = "Raporlama";
			this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode46,
            treeNode52,
            treeNode54,
            treeNode56});
			this.treeView1.Size = new System.Drawing.Size(209, 387);
			this.treeView1.TabIndex = 11;
			this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(216, 234);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(969, 385);
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
			this.gOgretmenGuncelle.Location = new System.Drawing.Point(216, 234);
			this.gOgretmenGuncelle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.gOgretmenGuncelle.Name = "gOgretmenGuncelle";
			this.gOgretmenGuncelle.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.gOgretmenGuncelle.Size = new System.Drawing.Size(523, 386);
			this.gOgretmenGuncelle.TabIndex = 13;
			this.gOgretmenGuncelle.TabStop = false;
			this.gOgretmenGuncelle.Visible = false;
			// 
			// btnGuncelle
			// 
			this.btnGuncelle.Location = new System.Drawing.Point(247, 290);
			this.btnGuncelle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnGuncelle.Name = "btnGuncelle";
			this.btnGuncelle.Size = new System.Drawing.Size(89, 34);
			this.btnGuncelle.TabIndex = 4;
			this.btnGuncelle.Text = "Güncelle";
			this.btnGuncelle.UseVisualStyleBackColor = true;
			this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
			// 
			// txtOgretmenDogumTarihi
			// 
			this.txtOgretmenDogumTarihi.Location = new System.Drawing.Point(211, 194);
			this.txtOgretmenDogumTarihi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtOgretmenDogumTarihi.Name = "txtOgretmenDogumTarihi";
			this.txtOgretmenDogumTarihi.Size = new System.Drawing.Size(176, 22);
			this.txtOgretmenDogumTarihi.TabIndex = 3;
			// 
			// txtOgretmenTCNo
			// 
			this.txtOgretmenTCNo.Location = new System.Drawing.Point(211, 149);
			this.txtOgretmenTCNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtOgretmenTCNo.Name = "txtOgretmenTCNo";
			this.txtOgretmenTCNo.Size = new System.Drawing.Size(176, 22);
			this.txtOgretmenTCNo.TabIndex = 2;
			// 
			// txtOgretmenSoyad
			// 
			this.txtOgretmenSoyad.Location = new System.Drawing.Point(211, 108);
			this.txtOgretmenSoyad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtOgretmenSoyad.Name = "txtOgretmenSoyad";
			this.txtOgretmenSoyad.Size = new System.Drawing.Size(176, 22);
			this.txtOgretmenSoyad.TabIndex = 2;
			// 
			// txtOgretmenAd
			// 
			this.txtOgretmenAd.Location = new System.Drawing.Point(211, 69);
			this.txtOgretmenAd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtOgretmenAd.Name = "txtOgretmenAd";
			this.txtOgretmenAd.Size = new System.Drawing.Size(176, 22);
			this.txtOgretmenAd.TabIndex = 2;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(145, 241);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(48, 16);
			this.label6.TabIndex = 1;
			this.label6.Text = "Branşı:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(101, 199);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(91, 16);
			this.label5.TabIndex = 1;
			this.label5.Text = "Doğum Tarihi:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(139, 153);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(55, 16);
			this.label4.TabIndex = 1;
			this.label4.Text = "T.C. No:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(140, 114);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(53, 16);
			this.label3.TabIndex = 1;
			this.label3.Text = "Soyadı:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(163, 75);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(30, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = "Adı:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(91, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(103, 32);
			this.label1.TabIndex = 1;
			this.label1.Text = "İşlem Yapılacak\r\nÖğretmen:\r\n";
			// 
			// cOgretmenBrans
			// 
			this.cOgretmenBrans.FormattingEnabled = true;
			this.cOgretmenBrans.Location = new System.Drawing.Point(211, 233);
			this.cOgretmenBrans.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cOgretmenBrans.Name = "cOgretmenBrans";
			this.cOgretmenBrans.Size = new System.Drawing.Size(176, 24);
			this.cOgretmenBrans.TabIndex = 0;
			// 
			// cOgretmenListesi
			// 
			this.cOgretmenListesi.FormattingEnabled = true;
			this.cOgretmenListesi.Location = new System.Drawing.Point(211, 30);
			this.cOgretmenListesi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cOgretmenListesi.Name = "cOgretmenListesi";
			this.cOgretmenListesi.Size = new System.Drawing.Size(176, 24);
			this.cOgretmenListesi.TabIndex = 0;
			this.cOgretmenListesi.SelectedIndexChanged += new System.EventHandler(this.cOgretmenListesi_SelectedIndexChanged);
			// 
			// gOgretmenSil
			// 
			this.gOgretmenSil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gOgretmenSil.Location = new System.Drawing.Point(216, 234);
			this.gOgretmenSil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.gOgretmenSil.Name = "gOgretmenSil";
			this.gOgretmenSil.RowHeadersWidth = 51;
			this.gOgretmenSil.RowTemplate.Height = 24;
			this.gOgretmenSil.Size = new System.Drawing.Size(969, 382);
			this.gOgretmenSil.TabIndex = 14;
			this.gOgretmenSil.Visible = false;
			this.gOgretmenSil.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(1347, 640);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 7;
			this.pictureBox1.TabStop = false;
			// 
			// gOgrenciGuncelle
			// 
			this.gOgrenciGuncelle.Controls.Add(this.btnOgrenciGuncelle);
			this.gOgrenciGuncelle.Controls.Add(this.dOgrenciDogumTarihi);
			this.gOgrenciGuncelle.Controls.Add(this.txtOgrenciAdresi);
			this.gOgrenciGuncelle.Controls.Add(this.txtOgrenciNo);
			this.gOgrenciGuncelle.Controls.Add(this.txtOgrenciTC);
			this.gOgrenciGuncelle.Controls.Add(this.txtOgrenciSoyadi);
			this.gOgrenciGuncelle.Controls.Add(this.txtOgrenciAdi);
			this.gOgrenciGuncelle.Controls.Add(this.label13);
			this.gOgrenciGuncelle.Controls.Add(this.label7);
			this.gOgrenciGuncelle.Controls.Add(this.label8);
			this.gOgrenciGuncelle.Controls.Add(this.label9);
			this.gOgrenciGuncelle.Controls.Add(this.label10);
			this.gOgrenciGuncelle.Controls.Add(this.label11);
			this.gOgrenciGuncelle.Controls.Add(this.label12);
			this.gOgrenciGuncelle.Controls.Add(this.cOgrenciGuncelleme);
			this.gOgrenciGuncelle.Location = new System.Drawing.Point(215, 234);
			this.gOgrenciGuncelle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.gOgrenciGuncelle.Name = "gOgrenciGuncelle";
			this.gOgrenciGuncelle.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.gOgrenciGuncelle.Size = new System.Drawing.Size(523, 386);
			this.gOgrenciGuncelle.TabIndex = 14;
			this.gOgrenciGuncelle.TabStop = false;
			this.gOgrenciGuncelle.Visible = false;
			// 
			// btnOgrenciGuncelle
			// 
			this.btnOgrenciGuncelle.Location = new System.Drawing.Point(248, 339);
			this.btnOgrenciGuncelle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnOgrenciGuncelle.Name = "btnOgrenciGuncelle";
			this.btnOgrenciGuncelle.Size = new System.Drawing.Size(89, 34);
			this.btnOgrenciGuncelle.TabIndex = 4;
			this.btnOgrenciGuncelle.Text = "Güncelle";
			this.btnOgrenciGuncelle.UseVisualStyleBackColor = true;
			this.btnOgrenciGuncelle.Click += new System.EventHandler(this.btnOgrenciGuncelle_Click);
			// 
			// dOgrenciDogumTarihi
			// 
			this.dOgrenciDogumTarihi.Location = new System.Drawing.Point(211, 194);
			this.dOgrenciDogumTarihi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dOgrenciDogumTarihi.Name = "dOgrenciDogumTarihi";
			this.dOgrenciDogumTarihi.Size = new System.Drawing.Size(176, 22);
			this.dOgrenciDogumTarihi.TabIndex = 3;
			// 
			// txtOgrenciAdresi
			// 
			this.txtOgrenciAdresi.Location = new System.Drawing.Point(211, 281);
			this.txtOgrenciAdresi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtOgrenciAdresi.Name = "txtOgrenciAdresi";
			this.txtOgrenciAdresi.Size = new System.Drawing.Size(176, 22);
			this.txtOgrenciAdresi.TabIndex = 2;
			// 
			// txtOgrenciNo
			// 
			this.txtOgrenciNo.Location = new System.Drawing.Point(211, 238);
			this.txtOgrenciNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtOgrenciNo.Name = "txtOgrenciNo";
			this.txtOgrenciNo.Size = new System.Drawing.Size(176, 22);
			this.txtOgrenciNo.TabIndex = 2;
			// 
			// txtOgrenciTC
			// 
			this.txtOgrenciTC.Location = new System.Drawing.Point(211, 149);
			this.txtOgrenciTC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtOgrenciTC.Name = "txtOgrenciTC";
			this.txtOgrenciTC.Size = new System.Drawing.Size(176, 22);
			this.txtOgrenciTC.TabIndex = 2;
			// 
			// txtOgrenciSoyadi
			// 
			this.txtOgrenciSoyadi.Location = new System.Drawing.Point(211, 108);
			this.txtOgrenciSoyadi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtOgrenciSoyadi.Name = "txtOgrenciSoyadi";
			this.txtOgrenciSoyadi.Size = new System.Drawing.Size(176, 22);
			this.txtOgrenciSoyadi.TabIndex = 2;
			// 
			// txtOgrenciAdi
			// 
			this.txtOgrenciAdi.Location = new System.Drawing.Point(211, 69);
			this.txtOgrenciAdi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtOgrenciAdi.Name = "txtOgrenciAdi";
			this.txtOgrenciAdi.Size = new System.Drawing.Size(176, 22);
			this.txtOgrenciAdi.TabIndex = 2;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(146, 284);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(49, 16);
			this.label13.TabIndex = 1;
			this.label13.Text = "Adresi:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(117, 241);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(78, 16);
			this.label7.TabIndex = 1;
			this.label7.Text = "Öğrenci No:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(101, 199);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(91, 16);
			this.label8.TabIndex = 1;
			this.label8.Text = "Doğum Tarihi:";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(139, 153);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(55, 16);
			this.label9.TabIndex = 1;
			this.label9.Text = "T.C. No:";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(140, 114);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(53, 16);
			this.label10.TabIndex = 1;
			this.label10.Text = "Soyadı:";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(163, 75);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(30, 16);
			this.label11.TabIndex = 1;
			this.label11.Text = "Adı:";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(91, 30);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(103, 32);
			this.label12.TabIndex = 1;
			this.label12.Text = "İşlem Yapılacak\r\nÖğrenci:\r\n";
			// 
			// cOgrenciGuncelleme
			// 
			this.cOgrenciGuncelleme.FormattingEnabled = true;
			this.cOgrenciGuncelleme.Location = new System.Drawing.Point(211, 30);
			this.cOgrenciGuncelleme.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cOgrenciGuncelleme.Name = "cOgrenciGuncelleme";
			this.cOgrenciGuncelleme.Size = new System.Drawing.Size(176, 24);
			this.cOgrenciGuncelleme.TabIndex = 0;
			this.cOgrenciGuncelleme.SelectedIndexChanged += new System.EventHandler(this.cOgrenciGuncelleme_SelectedIndexChanged);
			// 
			// MudurAnaMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1347, 633);
			this.Controls.Add(this.gOgrenciGuncelle);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.treeView1);
			this.Controls.Add(this.lblAnlikSaat);
			this.Controls.Add(this.lblGirisYapanMudurKullaniciAdi);
			this.Controls.Add(this.btn_Cikis);
			this.Controls.Add(this.gOgretmenSil);
			this.Controls.Add(this.gOgretmenGuncelle);
			this.Controls.Add(this.pictureBox1);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "MudurAnaMenu";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "BÇAL Yönetim Bilgi Sistemi ";
			this.Load += new System.EventHandler(this.MudurAnaMenu_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.gOgretmenGuncelle.ResumeLayout(false);
			this.gOgretmenGuncelle.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.gOgretmenSil)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.gOgrenciGuncelle.ResumeLayout(false);
			this.gOgrenciGuncelle.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btn_Cikis;
		private System.Windows.Forms.Label lblAnlikSaat;
		private System.Windows.Forms.Label lblGirisYapanMudurKullaniciAdi;
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
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.GroupBox gOgrenciGuncelle;
		private System.Windows.Forms.Button btnOgrenciGuncelle;
		private System.Windows.Forms.DateTimePicker dOgrenciDogumTarihi;
		private System.Windows.Forms.TextBox txtOgrenciNo;
		private System.Windows.Forms.TextBox txtOgrenciTC;
		private System.Windows.Forms.TextBox txtOgrenciSoyadi;
		private System.Windows.Forms.TextBox txtOgrenciAdi;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.ComboBox cOgrenciGuncelleme;
		private System.Windows.Forms.TextBox txtOgrenciAdresi;
		private System.Windows.Forms.Label label13;
	}
}