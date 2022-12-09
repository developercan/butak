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
    public partial class frmGrupEkle : DevExpress.XtraEditors.XtraForm
    {
        public frmGrupEkle()
        {
            InitializeComponent();
        }

        private void btnGrpEkle_Click(object sender, EventArgs e)
        {
            clsInsert cls = new clsInsert();
            cls.GrupAd = txtGrup.Text;
            cls.grupEkle();
        }
    }
}