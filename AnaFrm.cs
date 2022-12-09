using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraCharts;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;

namespace butak
{
    public partial class AnaFrm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public AnaFrm()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }

        clsSelect cls;

        private void btnParcaEkle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmParcaEkle frm = new frmParcaEkle();
            frm.ShowDialog();
        }

        private void btnParcaSil_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmParcaSilme frm = new frmParcaSilme();
            frm.ShowDialog();
        }

        private void btnParcaGuncelle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmParcaGuncelle frm = new frmParcaGuncelle();
            frm.ShowDialog();
        }

        private void btnSepet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmSepet frm = new frmSepet();
            frm.ShowDialog();
        }

        private void btnParcaAra_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmParcaAra frm = new frmParcaAra();
            frm.ShowDialog();
        }

        private void btnAzalanParca_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmKritikParcalar frm = new frmKritikParcalar();
            frm.ShowDialog();
        }

        private void AnaFrm_Load(object sender, EventArgs e)
        {
            clsSelect cls = new clsSelect();
            cls.ayGunlerCiro();

            Series series = new Series("Series1", ViewType.Line);
            chartAyiciSatis.Series.Add(series);

            // Generate a data table and bind the series to it.
            series.DataSource = cls.dt;

            // Specify data members to bind the series.
            series.ArgumentScaleType = ScaleType.DateTime;
            series.ArgumentDataMember = "satisTarih";
            series.ValueScaleType = ScaleType.Numerical;
            series.ValueDataMembers.AddRange(new string[] { "satilanFiyat" });

            // Set some properties to get a nice-looking chart.
            chartAyiciSatis.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
        }

        private void btnYilsatis_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmYilSecim frm = new frmYilSecim();
            frm.ShowDialog();
        }

        private void btnAylikSatis_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmYilAySecim frm = new frmYilAySecim();
            frm.ShowDialog();
        }

        private void btnGünlükSatis_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmYilAyGunSecim frm = new frmYilAyGunSecim();
            frm.ShowDialog();
        }

        private void btnrehber_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmRehber frm = new frmRehber();
            frm.ShowDialog();
        }

        private void btnTarihArasıRpr_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmİkiTarihSecim frm = new frmİkiTarihSecim();
            frm.ShowDialog();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            bgworkParcaArama.RunWorkerAsync();
        }

        private void btnProgramCikis_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Application.Exit();
        }

        private void btnProgramKontrol_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmProgramKontrol frm = new frmProgramKontrol();
            frm.ShowDialog();
        }

        private void btnParcaGor_Click(object sender, EventArgs e)
        {
            frmParcaAra.ıd = gridView1.GetFocusedRowCellValue("ID").ToString();
            frmParcaAraDetay frm = new frmParcaAraDetay();
            frm.ShowDialog();
        }

        private void btnExcelVericek_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Excel Dosyası |*.xlsx";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                clsExcelSelect.excelYol = ofd.FileName;

                frmExcelVeriCek frm = new frmExcelVeriCek();
                frm.ShowDialog();
            }
        }

        private void btnDisaAktar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.FileName = "Butak Yedek.xlsx";
            sfd.Filter = "Excel Dosyası |*.xlsx";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Excel.Application app = new Excel.Application();
                Excel.Workbook workbook = app.Workbooks.Add(Type.Missing);
                Excel.Worksheet worksheet = null;
                worksheet = (Excel.Worksheet)workbook.ActiveSheet;
                worksheet.Name = "Veriler";

                clsSelect cls = new clsSelect();
                cls.disAktarmaVeri();

                if (cls.dt.Rows.Count > 0)
                {
                    for (int i = 0; i < cls.dt.Columns.Count; i++)
                    {
                        worksheet.Cells[1, i + 1] = cls.dt.Columns[i].ToString();
                    }

                    for (int i = 0; i < cls.dt.Rows.Count; i++)
                    {
                        for (int j = 0; j < cls.dt.Columns.Count; j++)
                        {
                            worksheet.Cells[i + 2, j + 1] = cls.dt.Rows[i][j].ToString();
                        }
                    }
                }
                else XtraMessageBox.Show("Yedeklenecek Veri Yok");

                workbook.SaveAs(sfd.FileName);
                workbook.Close();

                Marshal.ReleaseComObject(workbook);
            }
        }

        private void btnParcaSatisIstatistig_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmParcaSatisBilgisi frm = new frmParcaSatisBilgisi();
            frm.ShowDialog();
        }

        private void bgworkParcaArama_DoWork(object sender, DoWorkEventArgs e)
        {

            clsKarakterTemizleme cls2 = new clsKarakterTemizleme();
            cls2.KirliVeri = txtArama.Text;
            cls2.karakterTemizle();

            cls = new clsSelect();
            cls.Arama = txtArama.Text;
            cls.TemizArama = cls2.TemizVeri;
            cls.ParcaArama();

            if (cls.dt.Rows.Count < 1)
            {
                cls = new clsSelect();
                cls.aranan = txtArama.Text.Split(' ');
                cls.parcaAramaGelismis();
            }

        }

        private void bgworkParcaArama_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            gridControl1.DataSource = cls.dt;
            gridView1.Columns["ID"].Visible = false;
        }

        private void btnGunCiro_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmCiroTarihSecim frm = new frmCiroTarihSecim();
            frm.ShowDialog();
        }

        private void btnAyCiro_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmCiroYilAySecim frm = new frmCiroYilAySecim();
            frm.ShowDialog();
        }

        private void txtArama_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bgworkParcaArama.RunWorkerAsync();
            }
        }
    }
}
