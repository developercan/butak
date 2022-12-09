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
    public partial class frmİkiTarihSecim : DevExpress.XtraEditors.XtraForm
    {
        public frmİkiTarihSecim()
        {
            InitializeComponent();
        }

        private void btnRaporHazirla_Click(object sender, EventArgs e)
        {
            clsSelect cls = new clsSelect();

            DateTime ilktarih = new DateTime();
            DateTime sontarih = new DateTime();

            ilktarih = DateTime.Parse(dnIlkTarih.DateTime.ToString());
            sontarih = DateTime.Parse(dnSonTarih.DateTime.ToString());

            cls.Ilktarih = ilktarih.ToString("yyyy-MM-dd");
            cls.SonTarih = sontarih.ToString("yyyy-MM-dd");
            cls.rprBetweenSatis();


            rprTarihSatis rpr = new rprTarihSatis();
            rpr.lblparcaNo.DataBindings.Add("Text", cls.dt, "parcaNo");
            rpr.lblparcaAd.DataBindings.Add("Text", cls.dt, "parcaAd");
            rpr.lbladet.DataBindings.Add("Text", cls.dt, "adet");
            rpr.lblsatısFiyat.DataBindings.Add("Text", cls.dt, "satisFiyat");
            rpr.lblsatilanFiyat.DataBindings.Add("Text", cls.dt, "satilanFiyat");

            rpr.lblTarihBilgisi.Text = dnIlkTarih.DateTime.ToShortDateString() + " İle " + dnSonTarih.DateTime.ToShortDateString() + "Arası Satış";

            rpr.DataSource = cls.dt;
            rpr.DataAdapter = cls.ad;

            cls = new clsSelect();
            cls.Ilktarih = ilktarih.ToString("yyyy-MM-dd");
            cls.SonTarih = sontarih.ToString("yyyy-MM-dd");
            cls.rprBetweenToplamlari();

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