namespace EgitimOneriTakip
{
	partial class frmKullaniciGiris
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
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.txtKullaniciKodu = new DevExpress.XtraEditors.TextEdit();
			this.txtKullaniciSifre = new DevExpress.XtraEditors.TextEdit();
			this.btnIptal = new DevExpress.XtraEditors.SimpleButton();
			this.btnGiris = new DevExpress.XtraEditors.SimpleButton();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtKullaniciKodu.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtKullaniciSifre.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// labelControl1
			// 
			this.labelControl1.Location = new System.Drawing.Point(4, 109);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(71, 13);
			this.labelControl1.TabIndex = 0;
			this.labelControl1.Text = "Kullanıcı Kodu :";
			// 
			// labelControl2
			// 
			this.labelControl2.Location = new System.Drawing.Point(4, 135);
			this.labelControl2.Name = "labelControl2";
			this.labelControl2.Size = new System.Drawing.Size(69, 13);
			this.labelControl2.TabIndex = 1;
			this.labelControl2.Text = "Kullanıcı Şifre :";
			// 
			// defaultLookAndFeel1
			// 
			this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2010 Silver";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(242, 99);
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			// 
			// txtKullaniciKodu
			// 
			this.txtKullaniciKodu.Location = new System.Drawing.Point(81, 106);
			this.txtKullaniciKodu.Name = "txtKullaniciKodu";
			this.txtKullaniciKodu.Size = new System.Drawing.Size(156, 20);
			this.txtKullaniciKodu.TabIndex = 3;
			// 
			// txtKullaniciSifre
			// 
			this.txtKullaniciSifre.Location = new System.Drawing.Point(81, 132);
			this.txtKullaniciSifre.Name = "txtKullaniciSifre";
			this.txtKullaniciSifre.Size = new System.Drawing.Size(156, 20);
			this.txtKullaniciSifre.TabIndex = 4;
			// 
			// btnIptal
			// 
			this.btnIptal.Location = new System.Drawing.Point(81, 158);
			this.btnIptal.Name = "btnIptal";
			this.btnIptal.Size = new System.Drawing.Size(75, 23);
			this.btnIptal.TabIndex = 5;
			this.btnIptal.Text = "İptal";
			// 
			// btnGiris
			// 
			this.btnGiris.Location = new System.Drawing.Point(162, 158);
			this.btnGiris.Name = "btnGiris";
			this.btnGiris.Size = new System.Drawing.Size(75, 23);
			this.btnGiris.TabIndex = 6;
			this.btnGiris.Text = "Giriş";
			// 
			// frmKullaniciGiris
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(242, 190);
			this.Controls.Add(this.btnGiris);
			this.Controls.Add(this.btnIptal);
			this.Controls.Add(this.txtKullaniciSifre);
			this.Controls.Add(this.txtKullaniciKodu);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.labelControl2);
			this.Controls.Add(this.labelControl1);
			this.Name = "frmKullaniciGiris";
			this.Text = "Kullanıcı Giriş";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtKullaniciKodu.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtKullaniciSifre.Properties)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevExpress.XtraEditors.LabelControl labelControl1;
		private DevExpress.XtraEditors.LabelControl labelControl2;
		private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private DevExpress.XtraEditors.TextEdit txtKullaniciKodu;
		private DevExpress.XtraEditors.TextEdit txtKullaniciSifre;
		private DevExpress.XtraEditors.SimpleButton btnIptal;
		private DevExpress.XtraEditors.SimpleButton btnGiris;
	}
}