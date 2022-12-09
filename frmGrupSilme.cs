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
    public partial class frmGrupSilme : DevExpress.XtraEditors.XtraForm
    {
        public frmGrupSilme()
        {
            InitializeComponent();
        }

        private void frmGrupSilme_Load(object sender, EventArgs e)
        {
            clsSelect cls = new clsSelect();
            cls.grupGoruntuleme();

            cboxAktarmaGrp.DisplayMember = "grupAd";
            cboxAktarmaGrp.ValueMember = "ID";

            cboxAktarmaGrp.DataSource = cls.dt;
        }

        private void btnGrupSilme_Click(object sender, EventArgs e)
        {
            clsUpdate cls = new clsUpdate();
            cls.GrupID = frmRehber.GrupID;
            cls.AkGrupID = cboxAktarmaGrp.SelectedValue.ToString();
            cls.kisiAktarma();

            clsDelete cls2 = new clsDelete();
            cls2.ID1 = frmRehber.GrupID;
            cls2.grupSilme();

            XtraMessageBox.Show("Grup Başarılı Bir Şekilde Silindi");

            this.Close();
        }
    }
}