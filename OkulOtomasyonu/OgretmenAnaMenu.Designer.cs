namespace OkulOtomasyonu
{
	partial class OgretmenAnaMenu
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OgretmenAnaMenu));
			System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Öğrenci Listesi");
			System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Veli Bilgileri");
			System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Öğrenci Not Düzenle");
			System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Öğrenci İşlemleri", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
			System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Haftalık Ders Programı");
			System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Ders ve Sınıf İşlemleri", new System.Windows.Forms.TreeNode[] {
            treeNode5});
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.lblAnlikSaat = new System.Windows.Forms.Label();
			this.lblGirisYapanOgretmenKullaniciAdi = new System.Windows.Forms.Label();
			this.btn_Cikis = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.treeView1 = new System.Windows.Forms.TreeView();
			this.lblOgretmenBrans = new System.Windows.Forms.Label();
			this.dgOgrenciListele = new System.Windows.Forms.DataGridView();
			this.dgOgrenciVeliListele = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgOgrenciListele)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgOgrenciVeliListele)).BeginInit();
			this.SuspendLayout();
			// 
			// lblAnlikSaat
			// 
			this.lblAnlikSaat.AutoSize = true;
			this.lblAnlikSaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblAnlikSaat.ForeColor = System.Drawing.Color.IndianRed;
			this.lblAnlikSaat.Location = new System.Drawing.Point(1232, 20);
			this.lblAnlikSaat.Name = "lblAnlikSaat";
			this.lblAnlikSaat.Size = new System.Drawing.Size(188, 20);
			this.lblAnlikSaat.TabIndex = 13;
			this.lblAnlikSaat.Text = "anlık saat gösterecek";
			// 
			// lblGirisYapanOgretmenKullaniciAdi
			// 
			this.lblGirisYapanOgretmenKullaniciAdi.AutoSize = true;
			this.lblGirisYapanOgretmenKullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblGirisYapanOgretmenKullaniciAdi.ForeColor = System.Drawing.Color.SkyBlue;
			this.lblGirisYapanOgretmenKullaniciAdi.Location = new System.Drawing.Point(34, 143);
			this.lblGirisYapanOgretmenKullaniciAdi.Name = "lblGirisYapanOgretmenKullaniciAdi";
			this.lblGirisYapanOgretmenKullaniciAdi.Size = new System.Drawing.Size(108, 20);
			this.lblGirisYapanOgretmenKullaniciAdi.TabIndex = 14;
			this.lblGirisYapanOgretmenKullaniciAdi.Text = "adı yazacak";
			this.lblGirisYapanOgretmenKullaniciAdi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btn_Cikis
			// 
			this.btn_Cikis.Location = new System.Drawing.Point(51, 190);
			this.btn_Cikis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btn_Cikis.Name = "btn_Cikis";
			this.btn_Cikis.Size = new System.Drawing.Size(75, 38);
			this.btn_Cikis.TabIndex = 11;
			this.btn_Cikis.Text = "Çıkış Yap";
			this.btn_Cikis.UseVisualStyleBackColor = true;
			this.btn_Cikis.Click += new System.EventHandler(this.btn_Cikis_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(2, -2);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(1347, 640);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 12;
			this.pictureBox1.TabStop = false;
			// 
			// treeView1
			// 
			this.treeView1.Location = new System.Drawing.Point(2, 235);
			this.treeView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.treeView1.Name = "treeView1";
			treeNode1.Name = "ogrenciListesi";
			treeNode1.Text = "Öğrenci Listesi";
			treeNode2.Name = "ogrenciVeliBilgi";
			treeNode2.Text = "Veli Bilgileri";
			treeNode3.Name = "Node17";
			treeNode3.Text = "Öğrenci Not Düzenle";
			treeNode4.Name = "Node1";
			treeNode4.Text = "Öğrenci İşlemleri";
			treeNode5.Name = "Node16";
			treeNode5.Text = "Haftalık Ders Programı";
			treeNode6.Name = "Node15";
			treeNode6.Text = "Ders ve Sınıf İşlemleri";
			this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode6});
			this.treeView1.Size = new System.Drawing.Size(209, 387);
			this.treeView1.TabIndex = 15;
			this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
			// 
			// lblOgretmenBrans
			// 
			this.lblOgretmenBrans.AutoSize = true;
			this.lblOgretmenBrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblOgretmenBrans.ForeColor = System.Drawing.Color.Turquoise;
			this.lblOgretmenBrans.Location = new System.Drawing.Point(35, 170);
			this.lblOgretmenBrans.Name = "lblOgretmenBrans";
			this.lblOgretmenBrans.Size = new System.Drawing.Size(121, 18);
			this.lblOgretmenBrans.TabIndex = 16;
			this.lblOgretmenBrans.Text = "bransı yazacak";
			// 
			// dgOgrenciListele
			// 
			this.dgOgrenciListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgOgrenciListele.Location = new System.Drawing.Point(217, 235);
			this.dgOgrenciListele.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dgOgrenciListele.Name = "dgOgrenciListele";
			this.dgOgrenciListele.RowHeadersWidth = 51;
			this.dgOgrenciListele.RowTemplate.Height = 24;
			this.dgOgrenciListele.Size = new System.Drawing.Size(1132, 387);
			this.dgOgrenciListele.TabIndex = 17;
			this.dgOgrenciListele.Visible = false;
			// 
			// dgOgrenciVeliListele
			// 
			this.dgOgrenciVeliListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgOgrenciVeliListele.Location = new System.Drawing.Point(217, 235);
			this.dgOgrenciVeliListele.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dgOgrenciVeliListele.Name = "dgOgrenciVeliListele";
			this.dgOgrenciVeliListele.RowHeadersWidth = 51;
			this.dgOgrenciVeliListele.RowTemplate.Height = 24;
			this.dgOgrenciVeliListele.Size = new System.Drawing.Size(1132, 387);
			this.dgOgrenciVeliListele.TabIndex = 18;
			this.dgOgrenciVeliListele.Visible = false;
			// 
			// OgretmenAnaMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1347, 633);
			this.Controls.Add(this.dgOgrenciVeliListele);
			this.Controls.Add(this.dgOgrenciListele);
			this.Controls.Add(this.lblOgretmenBrans);
			this.Controls.Add(this.treeView1);
			this.Controls.Add(this.lblAnlikSaat);
			this.Controls.Add(this.lblGirisYapanOgretmenKullaniciAdi);
			this.Controls.Add(this.btn_Cikis);
			this.Controls.Add(this.pictureBox1);
			this.Name = "OgretmenAnaMenu";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "BÇAL Yönetim Bilgi Sistemi ";
			this.Load += new System.EventHandler(this.OgretmenAnaMenu_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgOgrenciListele)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgOgrenciVeliListele)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Label lblAnlikSaat;
		private System.Windows.Forms.Label lblGirisYapanOgretmenKullaniciAdi;
		private System.Windows.Forms.Button btn_Cikis;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TreeView treeView1;
		private System.Windows.Forms.Label lblOgretmenBrans;
		private System.Windows.Forms.DataGridView dgOgrenciListele;
		private System.Windows.Forms.DataGridView dgOgrenciVeliListele;
	}
}