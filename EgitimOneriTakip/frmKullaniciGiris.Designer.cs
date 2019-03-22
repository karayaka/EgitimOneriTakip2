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
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtKullaniciadi = new DevExpress.XtraEditors.TextEdit();
            this.txtsifre = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btngiris = new DevExpress.XtraEditors.SimpleButton();
            this.btniptal = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullaniciadi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsifre.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(8, 23);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(59, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Kullanıcı Adı:";
            // 
            // txtKullaniciadi
            // 
            this.txtKullaniciadi.Location = new System.Drawing.Point(86, 20);
            this.txtKullaniciadi.Name = "txtKullaniciadi";
            this.txtKullaniciadi.Size = new System.Drawing.Size(186, 20);
            this.txtKullaniciadi.TabIndex = 2;
            // 
            // txtsifre
            // 
            this.txtsifre.Location = new System.Drawing.Point(86, 46);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.Size = new System.Drawing.Size(186, 20);
            this.txtsifre.TabIndex = 4;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(41, 49);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(26, 13);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Şifre:";
            // 
            // btngiris
            // 
            this.btngiris.Location = new System.Drawing.Point(86, 72);
            this.btngiris.Name = "btngiris";
            this.btngiris.Size = new System.Drawing.Size(186, 23);
            this.btngiris.TabIndex = 5;
            this.btngiris.Text = "Giriş";
            this.btngiris.Click += new System.EventHandler(this.btngiris_Click);
            // 
            // btniptal
            // 
            this.btniptal.Location = new System.Drawing.Point(86, 101);
            this.btniptal.Name = "btniptal";
            this.btniptal.Size = new System.Drawing.Size(186, 23);
            this.btniptal.TabIndex = 6;
            this.btniptal.Text = "İptal";
            this.btniptal.Click += new System.EventHandler(this.btniptal_Click);
            // 
            // frmKullaniciGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 159);
            this.Controls.Add(this.btniptal);
            this.Controls.Add(this.btngiris);
            this.Controls.Add(this.txtsifre);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtKullaniciadi);
            this.Controls.Add(this.labelControl2);
            this.Name = "frmKullaniciGiris";
            this.Text = "frmKullaniciGiris";
            ((System.ComponentModel.ISupportInitialize)(this.txtKullaniciadi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsifre.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtKullaniciadi;
        private DevExpress.XtraEditors.TextEdit txtsifre;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btngiris;
        private DevExpress.XtraEditors.SimpleButton btniptal;
    }
}