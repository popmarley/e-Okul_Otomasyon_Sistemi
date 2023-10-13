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
			System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Sınav Bilgileri");
			this.btn_Cikis = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.label2 = new System.Windows.Forms.Label();
			this.treeView1 = new System.Windows.Forms.TreeView();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// btn_Cikis
			// 
			this.btn_Cikis.Location = new System.Drawing.Point(941, 166);
			this.btn_Cikis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btn_Cikis.Name = "btn_Cikis";
			this.btn_Cikis.Size = new System.Drawing.Size(75, 23);
			this.btn_Cikis.TabIndex = 1;
			this.btn_Cikis.Text = "Çıkış Yap";
			this.btn_Cikis.UseVisualStyleBackColor = true;
			this.btn_Cikis.Click += new System.EventHandler(this.btn_Cikis_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(923, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(109, 89);
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(954, 115);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(44, 16);
			this.label1.TabIndex = 3;
			this.label1.Text = "label1";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(954, 148);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(44, 16);
			this.label2.TabIndex = 3;
			this.label2.Text = "label1";
			// 
			// treeView1
			// 
			this.treeView1.Location = new System.Drawing.Point(12, 34);
			this.treeView1.Name = "treeView1";
			treeNode1.Name = "Node0";
			treeNode1.Text = "Sınav Bilgileri";
			this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
			this.treeView1.Size = new System.Drawing.Size(121, 97);
			this.treeView1.TabIndex = 4;
			// 
			// OgrenciAnaMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1044, 450);
			this.Controls.Add(this.treeView1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btn_Cikis);
			this.Name = "OgrenciAnaMenu";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "BÇAL Yönetim Bilgi Sistemi ";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btn_Cikis;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TreeView treeView1;
	}
}