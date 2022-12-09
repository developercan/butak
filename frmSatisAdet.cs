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
    public partial class frmSatisAdet : DevExpress.XtraEditors.XtraForm
    {
        public frmSatisAdet()
        {
            InitializeComponent();
        }

        private void btnSepteEkle_Click(object sender, EventArgs e)
        {
            int adet = int.Parse(txtAdet.Text);

            clsSelect cls = new clsSelect();
            cls.ID1 = frmParcaAra.ıd;
            cls.stokSorgulama();

            if (adet > cls.Stok)
            {
                XtraMessageBox.Show("Stokta Bu Kadar Ürün Yok", "Bilgilendirme");
            }
            else
            {
                cls = new clsSelect();
                cls.ID1 = frmParcaAra.ıd;
                cls.satisFiyat();
                string fiyat = cls.Satisfiyat;

                clsInsert cls2 = new clsInsert();
                cls2.Adet = txtAdet.Text;
                cls2.SatisFiyat = fiyat;
                cls2.ID1 = frmParcaAra.ıd;
                cls2.sepeteUrunEkle();

                this.Close();
            }
        }
    }
}