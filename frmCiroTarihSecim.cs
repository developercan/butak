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
    public partial class frmCiroTarihSecim : DevExpress.XtraEditors.XtraForm
    {
        public frmCiroTarihSecim()
        {
            InitializeComponent();
        }

        rprGunCiro rpr = new rprGunCiro();

        void satisFiyatGoruntuleme()
        {
            clsSelect cls = new clsSelect();
            cls.Tarih = dateNavigator1.DateTime;
            cls.satisFiyatCiroGun();

            Series series = new Series("Series1", ViewType.Doughnut);
            rpr.crtSatisFiyat.Series.Add(series);

            series.ArgumentDataMember = "parcaAd";
            series.ValueScaleType = ScaleType.Numerical;
            series.ValueDataMembers.AddRange(new string[] { "satisFiyat" });
            series.Label.TextPattern = "{A}: {V} tl";
            rpr.crtSatisFiyat.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
            series.Label.LineVisibility = DevExpress.Utils.DefaultBoolean.True;
            series.DataSource = cls.dt;

            ChartTitle crtit = new ChartTitle();
            crtit.Text = dateNavigator1.DateTime.ToShortDateString() + " Tarihi Satılan Ürünlerin Satış Fiyatı";
            rpr.crtSatisFiyat.Titles.Add(crtit);
        }

        void satilanFiyatGoruntuleme()
        {
            clsSelect cls = new clsSelect();
            cls.Tarih = dateNavigator1.DateTime;
            cls.satilanFiyatCiroGun();

            Series series = new Series("Series1", ViewType.Doughnut);
            rpr.crtSatilanFiyat.Series.Add(series);

            series.ArgumentDataMember = "parcaAd";
            series.ValueScaleType = ScaleType.Numerical;
            series.ValueDataMembers.AddRange(new string[] { "satilanFiyat" });
            series.Label.TextPattern = "{A}: {V} tl";
            rpr.crtSatilanFiyat.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
            series.Label.LineVisibility = DevExpress.Utils.DefaultBoolean.True;
            series.DataSource = cls.dt;

            ChartTitle crtit = new ChartTitle();
            crtit.Text = dateNavigator1.DateTime.ToShortDateString() + " Tarihi Satılan Ürünlerin Satıldığı Fiyatı";
            rpr.crtSatilanFiyat.Titles.Add(crtit);
        }

        void istatistik()
        {
            clsSelect cls = new clsSelect();
            cls.Tarih = dateNavigator1.DateTime;
            cls.ciroGunIstatistik();

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

        private void btnHazirla_Click(object sender, EventArgs e)
        {
            satisFiyatGoruntuleme();
            satilanFiyatGoruntuleme();
            istatistik();

            ReportPrintTool printTool = new ReportPrintTool(rpr);
            printTool.ShowRibbonPreviewDialog();
            printTool.Dispose();
        }
    }
}