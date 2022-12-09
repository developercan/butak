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
    public partial class frmParcaSilmeDetay : DevExpress.XtraEditors.XtraForm
    {
        public frmParcaSilmeDetay()
        {
            InitializeComponent();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            clsDelete cls = new clsDelete();
            cls.ID1 = frmParcaSilme.ıd;
            cls.parcaSilme();
        }

        private void frmParcaDetay_Load(object sender, EventArgs e)
        {
            clsSelect cls = new clsSelect();
            cls.ID1 = frmParcaSilme.ıd;
            cls.ıdParcaCekme();

            txtAciklama.Text = cls.dr["aciklama"].ToString();
            txtAdet.Text = cls.dr["adet"].ToString();
            txtMaliyet.Text = cls.dr["maliyet"].ToString();
            txtMarka.Text = cls.dr["marka"].ToString();
            txtModel.Text = cls.dr["model"].ToString();
            txtOemNo.Text = cls.dr["oemNo"].ToString();
            txtPrcNo.Text = cls.dr["parcaNo"].ToString();
            txtrafno.Text = cls.dr["rafNo"].ToString();
            txtLok.Text = cls.dr["depoAd"].ToString();
            txtSatisFiyati.Text = cls.dr["satisFiyat"].ToString();
            txtTedarikci.Text = cls.dr["tedarikci"].ToString();
            txtYil.Text = cls.dr["yil"].ToString();
            txtparcaAd.Text = cls.dr["parcaAd"].ToString();
            txtkadet.Text = cls.dr["kadet"].ToString();
            deEklenmeTarihi.Text = cls.dr["eklenmeTarih"].ToString();

            cls.dr.Close();
            cls.conn.Close();
        }
    }
}