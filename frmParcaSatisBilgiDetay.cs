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
    public partial class frmParcaSatisBilgiDetay : DevExpress.XtraEditors.XtraForm
    {
        public frmParcaSatisBilgiDetay()
        {
            InitializeComponent();
        }

        public static string ID;
        private void frmParcaSatisBilgiDetay_Load(object sender, EventArgs e)
        {
            clsSelect cls = new clsSelect();
            cls.ID1 = ID;
            cls.satilanParcaDetay();
            cls.dr.Read();

            rtxtmusteriAd.Text = cls.dr["musteriAd"].ToString();
            txtSeriASıraNo.Text = cls.dr["seriASıraNo"].ToString();
            txtMusteriVD.Text = cls.dr["musteriVD"].ToString();
            txtVergiNo.Text = cls.dr["vergiNo"].ToString();
            txtDuTarih.Text = cls.dr["duTarih"].ToString();
            txtDuSaat.Text = cls.dr["duSaat"].ToString();
            txtSevkTarih.Text = cls.dr["sevkTarih"].ToString();
            txtParcaNo.Text = cls.dr["parcaNo"].ToString();
            txtParcaAd.Text = cls.dr["parcaAd"].ToString();
            txtAdet.Text = cls.dr["adet"].ToString();
            txtSatisFiyat.Text = cls.dr["satisFiyat"].ToString();
            txtSatilanFiyat.Text = cls.dr["satilanFiyat"].ToString();
        }
    }
}