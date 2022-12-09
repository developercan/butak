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
using DevExpress.XtraReports.UI;

namespace butak
{
    public partial class frmUrunSatis : DevExpress.XtraEditors.XtraForm
    {
        public frmUrunSatis()
        {
            InitializeComponent();
        }

        public static bool satildi;

        private void btnFaturaKes_Click(object sender, EventArgs e)
        {
            satildi = true;

            rprSatis rpr = new rprSatis();
            rpr.lblmusteriAd.Text = txtAd.Text;
            rpr.lblSeriNo.Text = txtSıraNo.Text;
            rpr.lblMusteriVD.Text = txtMusVD.Text;
            rpr.lblVergiNo.Text = txtVeriNo.Text;
            rpr.lblDuTarih.Text = dteDuzenlemeTarih.Text;
            rpr.lblDuSaat.Text = txtduzenlemesaat.Text;
            rpr.lblSevkTarih.Text = dteSevkTarihi.Text;

            clsSelect cls2 = new clsSelect();
            cls2.rprSatis();

            rpr.lblParcaNo.DataBindings.Add("Text", cls2.dt, "parcaNo");
            rpr.lblAciklama.DataBindings.Add("Text", cls2.dt, "Aciklama");
            rpr.lblFiyat.DataBindings.Add("Text", cls2.dt, "fiyat");
            rpr.lblAdet.DataBindings.Add("Text", cls2.dt, "adet");
            rpr.lblTutar.DataBindings.Add("Text", cls2.dt, "tutar");

            rpr.DataSource = cls2.dt;
            rpr.DataAdapter = cls2.ad;

            cls2 = new clsSelect();
            cls2.sepetToplam();
            rpr.lblTopFiyat.Text = cls2.ToplamFiyat;

            clsInsert cls = new clsInsert();
            cls.MusteriAd = txtAd.Text;
            cls.SeriASıraNo = txtSıraNo.Text;
            cls.MusteriVD = txtMusVD.Text;
            cls.VergiNo = txtVeriNo.Text;
            cls.DuTarih = dteDuzenlemeTarih.Text;
            cls.DuSaat = txtduzenlemesaat.Text;
            cls.SevkTarih = dteSevkTarihi.Text;
            cls.urunSatis();

            ReportPrintTool printTool = new ReportPrintTool(rpr);
            printTool.ShowRibbonPreviewDialog();
            printTool.Dispose();
        }
    }
}