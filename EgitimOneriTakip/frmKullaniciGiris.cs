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

        private void btniptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btngiris_Click(object sender, EventArgs e)
        {
            cs.csBildirim.bildirim("Giriş Deneme", "Giriş işlemi deneme için yapıldı");
        }
    }
}