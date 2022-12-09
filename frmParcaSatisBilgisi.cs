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
    public partial class frmParcaSatisBilgisi : DevExpress.XtraEditors.XtraForm
    {
        public frmParcaSatisBilgisi()
        {
            InitializeComponent();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            clsSelect cls = new clsSelect();

            clsKarakterTemizleme cls2 = new clsKarakterTemizleme();
            cls2.KirliVeri = txtArama.Text;
            cls2.karakterTemizle();

            cls.TemizArama = cls2.TemizVeri;
            cls.Arama = txtArama.Text;
            cls.satilanParcaArama();

            gridControl1.DataSource = cls.dt;
            gridView1.Columns["ID"].Visible = false;
        }

        private void btnParcaGor_Click(object sender, EventArgs e)
        {
            frmParcaSatisBilgiDetay.ID = gridView1.GetFocusedRowCellValue("ID").ToString();
            frmParcaSatisBilgiDetay frm = new frmParcaSatisBilgiDetay();
            frm.ShowDialog();
        }
    }
}