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
    public partial class frmParcaGunclleDetay : DevExpress.XtraEditors.XtraForm
    {
        public frmParcaGunclleDetay()
        {
            InitializeComponent();
        }

        public static string ıd;

        private void frmParcaGunclleDetay_Load(object sender, EventArgs e)
        {
            clsSelect cls = new clsSelect();
            cls.ID1 = ıd;
            cls.ıdParcaCekme();

            txtmarkaNo.Text = cls.dr["markaNo"].ToString();
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

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            clsUpdate cls = new clsUpdate();

            cls.Aciklama = txtAciklama.Text;
            cls.Adet = txtAdet.Text;
            cls.Maliyet = txtMaliyet.Text;
            cls.Marka = txtMarka.Text;
            cls.Model = txtModel.Text;
            cls.OemNo = txtOemNo.Text;
            cls.ParcaNo = txtPrcNo.Text;
            cls.RafNo = txtrafno.Text;
            cls.DepoAd = txtLok.Text;
            cls.SatisFiyat = txtSatisFiyati.Text;
            cls.Tedarikci = txtTedarikci.Text;
            cls.Yil = txtYil.Text;
            cls.ParcaAd = txtparcaAd.Text;
            cls.Kadet = txtkadet.Text;
            cls.EklenmeTarih = deEklenmeTarihi.Text;
            cls.MarkaNo = txtmarkaNo.Text;

            cls.ID1 = ıd;
            cls.parcaGuncelleme();
        }
    }
}