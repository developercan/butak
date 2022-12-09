using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;

namespace butak
{
    public partial class frmExcelVeriCek : DevExpress.XtraEditors.XtraForm
    {
        public frmExcelVeriCek()
        {
            InitializeComponent();
        }
        string tsql;
        private void frmExcelVeriCek_Load(object sender, EventArgs e)
        {
            Excel.Application app = new Excel.Application();
            Excel.Workbook work = app.Workbooks.Open(clsExcelSelect.excelYol);

            foreach (Excel.Worksheet item in work.Sheets)
            {
                cboxSayfa.Items.Add(item.Name);
            }

            work.Close();
            cboxSayfa.SelectedIndex = 0;

            Marshal.ReleaseComObject(work);
        }

        private void btnVerileriCek_Click(object sender, EventArgs e)
        {
            tsql = "";
            foreach (Control item in this.Controls)
            {
                if (item is ComboBox && item.Name != "cboxSayfa" && item.Text != "Kolon Yok" && item.Text != "")
                {
                    tsql = tsql + "[" + ((ComboBox)item).Text + "],";
                }
            }
            tsql = "Select " + tsql.Substring(0, tsql.Length - 1) + " from [" + cboxSayfa.Text + "$]";

            clsExcelSelect cls = new clsExcelSelect();
            cls.Tsql = tsql;
            cls.SecilenKolonVeri();

            clsInsert cls2 = new clsInsert();
            while (cls.dr.Read())
            {
                if (cbox1.Text != "Kolon Yok" && cbox1.Text != "")
                {
                    clsKarakterTemizleme cls3 = new clsKarakterTemizleme();
                    cls3.KirliVeri = cls.dr[cbox1.Text].ToString();
                    cls3.karakterTemizle();
                    cls2.ParcaNo = cls3.TemizVeri;
                }
                else cls2.ParcaNo = "-";
                if (cbox2.Text != "Kolon Yok" && cbox2.Text != "") cls2.MarkaNo = cls.dr[cbox2.Text].ToString(); else cls2.MarkaNo = "-";
                if (cbox3.Text != "Kolon Yok" && cbox3.Text != "") cls2.OemNo = cls.dr[cbox3.Text].ToString(); else cls2.OemNo = "-";
                if (cbox4.Text != "Kolon Yok" && cbox4.Text != "") cls2.ParcaAd = cls.dr[cbox4.Text].ToString(); else cls2.ParcaAd = "-";
                if (cbox5.Text != "Kolon Yok" && cbox5.Text != "") cls2.Model = cls.dr[cbox5.Text].ToString(); else cls2.Model = "-";
                if (cbox6.Text != "Kolon Yok" && cbox6.Text != "") cls2.Marka = cls.dr[cbox6.Text].ToString(); else cls2.Marka = "-";
                if (cbox7.Text != "Kolon Yok" && cbox7.Text != "") cls2.Yil = cls.dr[cbox7.Text].ToString(); else cls2.Yil = "-";
                if (cbox8.Text != "Kolon Yok" && cbox8.Text != "") cls2.Tedarikci = cls.dr[cbox8.Text].ToString(); else cls2.Tedarikci = "-";
                if (cbox9.Text != "Kolon Yok" && cbox9.Text != "")
                {
                    if (cls.dr[cbox9.Text].ToString() != "") cls2.Maliyet = cls.dr[cbox9.Text].ToString(); else cls2.Maliyet = "0";
                }
                if (cbox10.Text != "Kolon Yok" && cbox10.Text != "")
                {
                    if (cls.dr[cbox10.Text].ToString() != "") cls2.SatisFiyat = cls.dr[cbox10.Text].ToString(); else cls2.SatisFiyat = "0";
                }
                if (cbox11.Text != "Kolon Yok" && cbox11.Text != "") cls2.EklenmeTarih = cls.dr[cbox11.Text].ToString(); else cls2.EklenmeTarih = DateTime.Now.ToString();
                if (cbox12.Text != "Kolon Yok" && cbox12.Text != "") cls2.Aciklama = cls.dr[cbox12.Text].ToString(); else cls2.Aciklama = "";
                if (cbox13.Text != "Kolon Yok" && cbox13.Text != "")
                {
                    if (cls.dr[cbox10.Text].ToString() != "") cls2.Adet = cls.dr[cbox13.Text].ToString(); else cls2.Adet = "0";
                }
                if (cbox14.Text != "Kolon Yok" && cbox14.Text != "") cls2.RafNo = cls.dr[cbox14.Text].ToString(); else cls2.RafNo = "-";
                if (cbox15.Text != "Kolon Yok" && cbox15.Text != "") cls2.DepoAd = cls.dr[cbox15.Text].ToString(); else cls2.DepoAd = "-";
                if (cbox16.Text != "Kolon Yok" && cbox16.Text != "")
                {
                    if (cls.dr[cbox16.Text].ToString() != "") cls2.Kadet = cls.dr[cbox16.Text].ToString(); else cls2.Kadet = "0";
                }
                cls2.parcaEkle();
            }

            cls.dr.Close();
            cls.conn.Close();

            cls2.conn.Close();
        }

        private void cboxSayfa_SelectedIndexChanged(object sender, EventArgs e)
        {
            clsExcelSelect cls = new clsExcelSelect();
            cls.SecilenSayfa = cboxSayfa.Text;
            cls.Kolonlar();

            foreach (Control item in this.Controls)
            {
                if (item is ComboBox && item.Name != "cboxSayfa")
                {
                    ((ComboBox)item).Items.Clear();
                    ((ComboBox)item).Items.Add("Kolon Yok");

                    foreach (DataColumn clmn in cls.dt.Columns)
                    {
                        ((ComboBox)item).Items.Add(clmn.ColumnName);
                    }
                }
            }
        }
    }
}