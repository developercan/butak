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
    public partial class frmParcaEkle : DevExpress.XtraEditors.XtraForm
    {
        public frmParcaEkle()
        {
            InitializeComponent();
        }

        clsMatIslem cls = new clsMatIslem();

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            clsInsert cls = new clsInsert();
            clsKarakterTemizleme cls2 = new clsKarakterTemizleme();


            cls2.KirliVeri = txtPrcNo.Text;
            cls2.karakterTemizle();


            cls.ParcaNo = cls2.TemizVeri;
            cls.MarkaNo = txtmarkaNo.Text;
            cls.OemNo = txtOemNo.Text;
            cls.ParcaAd = txtparcaAd.Text;
            cls.Kadet = txtkadet.Text;
            cls.Model = txtModel.Text;
            cls.Yil = txtYil.Text;
            cls.Tedarikci = txtTedarikci.Text;
            cls.Adet = txtAdet.Text;
            cls.RafNo = txtrafno.Text;
            cls.Marka = txtMarka.Text;
            cls.Maliyet = txtMaliyet.Text;
            cls.SatisFiyat = txtSatisFiyati.Text;
            cls.Tedarikci = txtTedarikci.Text;
            cls.DepoAd = txtLok.Text;
            cls.Aciklama = txtAciklama.Text;
            cls.EklenmeTarih = deEklenmeTarihi.Text;

            cls.parcaEkle();
            XtraMessageBox.Show("Parça Kayıt Etme İşlemi Başarılı");

            foreach (var item in this.Controls)
            {
                if (item is TextEdit)
                {
                    ((TextEdit)item).Text = String.Empty;
                }
                else if (item is RichTextBox)
                {
                    ((RichTextBox)item).Text = String.Empty;
                }
            }
        }

        private void txtAdet_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                double toplamkazanc = cls.topKazanc(txtAdet.Text);

                lblKazanc.Text = toplamkazanc.ToString() + " tl";

                if (toplamkazanc > 0) lblKazanc.ForeColor = Color.Green;
                else lblKazanc.ForeColor = Color.Red;
            }
            catch (Exception)
            {
                lblKazanc.Text = "Hatalı Giriş";
                lblKazanc.ForeColor = Color.Red;
            }
        }

        private void txtSatisFiyati_EditValueChanged(object sender, EventArgs e)
        {

            try
            {
                double kazanc = cls.kazanchesaplama(txtSatisFiyati.Text, txtMaliyet.Text);

                lblKazanc.Text = kazanc.ToString() + " tl";

                txtAdet.Enabled = true;

                if (kazanc > 0) lblKazanc.ForeColor = Color.Green;
                else lblKazanc.ForeColor = Color.Red;

            }
            catch (Exception)
            {
                lblKazanc.Text = "Hatalı Giriş";
                lblKazanc.ForeColor = Color.Red;

                txtAdet.Enabled = false;
                txtAdet.Text = null;
            }
        }

        private void txtMaliyet_EditValueChanged(object sender, EventArgs e)
        {

            try
            {
                double kazanc = cls.kazanchesaplama(txtSatisFiyati.Text, txtMaliyet.Text);
                lblKazanc.Text = kazanc.ToString() + " tl";


                txtAdet.Enabled = true;

                if (kazanc > 0) lblKazanc.ForeColor = Color.Green;
                else lblKazanc.ForeColor = Color.Red;

            }
            catch (Exception)
            {
                lblKazanc.Text = "Hatalı Giriş";
                lblKazanc.ForeColor = Color.Red;

                txtAdet.Enabled = false;
                txtAdet.Text = null;
            }
        }
    }
}