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

namespace butak
{
    public partial class frmGrupGuncelle : DevExpress.XtraEditors.XtraForm
    {
        public frmGrupGuncelle()
        {
            InitializeComponent();
        }

        private void frmGrupGuncelle_Load(object sender, EventArgs e)
        {
            clsSelect cls = new clsSelect();
            cls.ID1 = frmRehber.GrupID;
            cls.grupAdı();
            txtGrupAd.Text = cls.GrupAd;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            clsUpdate cls = new clsUpdate();
            cls.GrupID = frmRehber.GrupID;
            cls.GrupAd = txtGrupAd.Text;
            cls.grupGuncelle();

            XtraMessageBox.Show("Grup Başarılı Bir Şekilde Güncellendi");
        }
    }
}