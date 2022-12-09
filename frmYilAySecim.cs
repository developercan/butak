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
    public partial class frmYilAySecim : DevExpress.XtraEditors.XtraForm
    {
        public frmYilAySecim()
        {
            InitializeComponent();
        }

        private void frmYilSecim_Load(object sender, EventArgs e)
        {
            clsSelect cls = new clsSelect();
            cls.satisYillar();

            cboxYil.DisplayMember = "yil";
            cboxYil.DataSource = cls.dt;
        }

        private void cboxYil_SelectedValueChanged(object sender, EventArgs e)
        {
            clsSelect cls = new clsSelect();
            cls.Yil = cboxYil.Text;
            cls.satisAyYil();

            cboxAy.DisplayMember = "ay";
            cboxAy.ValueMember = "AyNo";
            cboxAy.DataSource = cls.dt;
        }

        private void btnRaporHazirla_Click(object sender, EventArgs e)
        {
            clsSelect cls = new clsSelect();
            cls.Ay = cboxAy.SelectedValue.ToString();
            cls.Yil = cboxYil.Text;
            cls.rprAylikSatis();

            rprTarihSatis rpr = new rprTarihSatis();
            rpr.lblparcaNo.DataBindings.Add("Text", cls.dt, "parcaNo");
            rpr.lblparcaAd.DataBindings.Add("Text", cls.dt, "parcaAd");
            rpr.lbladet.DataBindings.Add("Text", cls.dt, "adet");
            rpr.lblsatısFiyat.DataBindings.Add("Text", cls.dt, "satisFiyat");
            rpr.lblsatilanFiyat.DataBindings.Add("Text", cls.dt, "satilanFiyat");

            rpr.lblTarihBilgisi.Text = cboxAy.Text + " Ayı " + cboxYil.Text + " Yılı Satış Raporu";

            rpr.DataSource = cls.dt;
            rpr.DataAdapter = cls.ad;

            cls = new clsSelect();
            cls.Ay = cboxAy.SelectedValue.ToString();
            cls.Yil = cboxYil.Text;
            cls.rprAyToplamlari();

            if (cls.dr.Read())
            {
                rpr.lblTopAdet.Text = cls.dr["topAdet"].ToString();
                rpr.lblTopSatisFiyat.Text = cls.dr["topSatisFiyat"].ToString();
                rpr.lblTopSatilanFiyat.Text = cls.dr["topSatilanFiyat"].ToString();
            }

            cls.dr.Close();
            cls.conn.Close();

            ReportPrintTool printTool = new ReportPrintTool(rpr);
            printTool.ShowRibbonPreviewDialog();
            printTool.Dispose();
        }
    }
}