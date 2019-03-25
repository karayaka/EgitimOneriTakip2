using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace EgitimOneriTakip
{
	public partial class frmKullaniciGiris : DevExpress.XtraEditors.XtraForm
	{
		public frmKullaniciGiris()
		{
			InitializeComponent();
		}

		private void frmKullaniciGiris_Load(object sender, EventArgs e)
		{
            //9666666
		}

		private void btnGiris_Click(object sender, EventArgs e)
		{
			try
			{

			}
			catch (Exception hata)
			{
				MessageBox.Show(hata.Message);
			}
		}

		private void btnIptal_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}