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
    public partial class frmKisiGuncelle : DevExpress.XtraEditors.XtraForm
    {
        public frmKisiGuncelle()
        {
            InitializeComponent();
        }

        private void frmKisiGuncelle_Load(object sender, EventArgs e)
        {
            clsSelect cls = new clsSelect();
            cls.kisiBilgileri();
            if (cls.dr.Read())
            {
                txtAd.Text = cls.dr["ad"].ToString();
                txtSoyad.Text = cls.dr["soyad"].ToString();
                txtTelno.Text = cls.dr["tel"].ToString();
                txtEposta.Text = cls.dr["eposta"].ToString();
            }

            cls.conn.Close();
        }

        private void btnKisiGuncelle_Click(object sender, EventArgs e)
        {
            clsUpdate cls = new clsUpdate();
            cls.Ad = txtAd.Text;
            cls.Soyad = txtSoyad.Text;
            cls.Tel = txtTelno.Text;
            cls.Eposta = txtEposta.Text;
            cls.kisiGuncelle();

            XtraMessageBox.Show("Kişi Başarılı Bir Şekilde Güncellendi");
        }
    }
}