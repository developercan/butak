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
    public partial class frmKritikParcalar : DevExpress.XtraEditors.XtraForm
    {
        public frmKritikParcalar()
        {
            InitializeComponent();
        }

        private void frmKritikParcalar_Load(object sender, EventArgs e)
        {
            clsSelect cls = new clsSelect();
            cls.kritikParcalar();
            gridControl1.DataSource = cls.dt;
            gridView1.Columns["ID"].Visible = false;
        }

        private void btnParcaGor_Click(object sender, EventArgs e)
        {
            frmParcaGunclleDetay.ıd = gridView1.GetFocusedRowCellValue("ID").ToString();
            frmParcaGunclleDetay frm = new frmParcaGunclleDetay();
            frm.ShowDialog();
        }
    }
}