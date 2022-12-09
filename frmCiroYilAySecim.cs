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
using DevExpress.XtraCharts;
using DevExpress.XtraReports.UI;

namespace butak
{
    public partial class frmCiroYilAySecim : DevExpress.XtraEditors.XtraForm
    {
        public frmCiroYilAySecim()
        {
            InitializeComponent();
        }

        rprAyCiro rpr = new rprAyCiro();

        void satilanFiyatGunlerCiro()
        {
            clsSelect cls = new clsSelect();
            cls.Yil = cboxYil.Text;
            cls.Ay = cboxAy.SelectedValue.ToString();
            cls.satilanFiyatCiroAy();

            Series series = new Series("Satılan Fiyat", ViewType.Line);
            rpr.crtAyGunler.Series.Add(series);

            series.DataSource = cls.dt;

            series.ArgumentScaleType = ScaleType.DateTime;
            series.ArgumentDataMember = "satisTarih";
            series.ValueScaleType = ScaleType.Numerical;
            series.ValueDataMembers.AddRange(new string[] { "satilanFiyat" });

            rpr.crtAyGunler.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True;
        }

        void satisFiyatGunlerCiro()
        {
            clsSelect cls = new clsSelect();
            cls.Yil = cboxYil.Text;
            cls.Ay = cboxAy.SelectedValue.ToString();
            cls.satisFiyatCiroAy();

            Series series = new Series("Satış Fiyat", ViewType.Line);
            rpr.crtAyGunler.Series.Add(series);

            series.DataSource = cls.dt;

            series.ArgumentScaleType = ScaleType.DateTime;
            series.ArgumentDataMember = "satisTarih";
            series.ValueScaleType = ScaleType.Numerical;
            series.ValueDataMembers.AddRange(new string[] { "satisFiyat" });

            rpr.crtAyGunler.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True;
        }

        void istatistik()
        {
            clsSelect cls = new clsSelect();
            cls.Yil = cboxYil.Text;
            cls.Ay = cboxAy.SelectedValue.ToString();
            cls.ciroAyIstatistik();

            if (cls.dr.Read())
            {
                rpr.lblTopKDV.Text = cls.dr["kdv"].ToString() + " tl";
                rpr.lblTopSatisFiyat.Text = cls.dr["toplamSatis"].ToString() + " tl";
                rpr.lblTopSatilanFiyat.Text = cls.dr["toplamSatilan"].ToString() + " tl";
                rpr.lblTopKar.Text = cls.dr["kar"].ToString() + " tl";
                rpr.lblTopSatilanAdet.Text = cls.dr["topAdet"].ToString();
            }

            cls.dr.Close();
            cls.conn.Close();
        }

        private void frmCiroYilAySecim_Load(object sender, EventArgs e)
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

        private void btnHazirla_Click(object sender, EventArgs e)
        {
            satilanFiyatGunlerCiro();
            satisFiyatGunlerCiro();
            istatistik();

            ReportPrintTool printTool = new ReportPrintTool(rpr);
            printTool.ShowRibbonPreviewDialog();
            printTool.Dispose();
        }
    }
}