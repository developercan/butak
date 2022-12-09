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
    public partial class frmParcaSilme : DevExpress.XtraEditors.XtraForm
    {
        public frmParcaSilme()
        {
            InitializeComponent();
        }

        public static string ıd;

        private void btnParcaGor_Click(object sender, EventArgs e)
        {
            ıd = gridView1.GetFocusedRowCellValue("ID").ToString();
            frmParcaSilmeDetay frm = new frmParcaSilmeDetay();
            frm.ShowDialog();
        }

        private void frmParcaSilme_Load(object sender, EventArgs e)
        {
            clsSelect cls = new clsSelect();
            cls.tumParcalar();
            gridControl1.DataSource = cls.dt;
            gridView1.Columns["ID"].Visible = false;
        }

        private void btnAra_Click(object sender, EventArgs e)
        {

            clsKarakterTemizleme cls2 = new clsKarakterTemizleme();
            cls2.KirliVeri = txtArama.Text;
            cls2.karakterTemizle();

            clsSelect cls = new clsSelect();
            cls.Arama = txtArama.Text;
            cls.TemizArama = cls2.TemizVeri;
            cls.ParcaArama();

            if (cls.dt.Rows.Count < 1)
            {
                cls = new clsSelect();
                cls.aranan = txtArama.Text.Split(' ');
                cls.parcaAramaGelismis();
            }

            gridControl1.DataSource = cls.dt;
        }
    }
}