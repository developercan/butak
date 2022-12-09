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
    public partial class frmYilAyGunSecim : DevExpress.XtraEditors.XtraForm
    {
        public frmYilAyGunSecim()
        {
            InitializeComponent();
        }

        private void btnRaporHazirla_Click(object sender, EventArgs e)
        {
            DateTime dt = dateNavigator1.DateTime;

            clsSelect cls = new clsSelect();
            cls.Tarih = dt;
            cls.rprGunlukSatis();

            rprTarihSatis rpr = new rprTarihSatis();
            rpr.lblparcaNo.DataBindings.Add("Text", cls.dt, "parcaNo");
            rpr.lblparcaAd.DataBindings.Add("Text", cls.dt, "parcaAd");
            rpr.lbladet.DataBindings.Add("Text", cls.dt, "adet");
            rpr.lblsatısFiyat.DataBindings.Add("Text", cls.dt, "satisFiyat");
            rpr.lblsatilanFiyat.DataBindings.Add("Text", cls.dt, "satilanFiyat");

            rpr.lblTarihBilgisi.Text = dt.ToShortDateString() + " Tarihi Günlük Satış";

            rpr.DataSource = cls.dt;
            rpr.DataAdapter = cls.ad;

            cls = new clsSelect();
            cls.Tarih = dt;
            cls.rprGunToplamlari();

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