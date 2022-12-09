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
    public partial class frmRehber : DevExpress.XtraEditors.XtraForm
    {
        public frmRehber()
        {
            InitializeComponent();
        }

        public static string GrupID;
        public static string KisiID;

        void gruplar()
        {
            clsSelect cls = new clsSelect();
            cls.gruplar();

            cboxGrup.DisplayMember = "grupAd";
            cboxGrup.ValueMember = "ID";
            cboxGrup.DataSource = cls.dt;

            cboxGrup.SelectedValueChanged += CboxGrup_SelectedValueChanged;
            if (cls.dt.Rows.Count > 0)
            {
                kisiler();
                etkin();
            }
            else
            {
                devredisi();
            }
        }

        void kisiler()
        {
            clsSelect cls = new clsSelect();
            cls.ID1 = cboxGrup.SelectedValue.ToString();
            cls.grupKisiler();
            gridControl1.DataSource = cls.dt;

            gridView1.Columns["ID"].Visible = false;
            gridView1.Columns["grupID"].Visible = false;
        }

        void devredisi()
        {
            nbıKisiEkle.Enabled = false;
            nbıKisiSil.Enabled = false;
            nbıKisiyiGuncelle.Enabled = false;
            nbıKisiGrupUp.Enabled = false;
        }

        void etkin()
        {
            nbıKisiEkle.Enabled = true;
            nbıKisiSil.Enabled = true;
            nbıKisiyiGuncelle.Enabled = true;
            nbıKisiGrupUp.Enabled = true;
        }

        private void frmRehber_Load(object sender, EventArgs e)
        {
            gruplar();
        }

        private void CboxGrup_SelectedValueChanged(object sender, EventArgs e)
        {
            kisiler();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            clsSelect cls = new clsSelect();
            cls.Arama = txtAra.Text;
            cls.kisiArama();
            gridControl1.DataSource = cls.dt;
        }

        private void nbıKisiEkle_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmKisiEkle frm = new frmKisiEkle();
            frm.ShowDialog();

            kisiler();
        }

        private void nbıGrupEkle_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmGrupEkle frm = new frmGrupEkle();
            frm.ShowDialog();

            gruplar();
        }

        private void nbıGrupSil_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (cboxGrup.Items.Count > 1)
            {
                GrupID = cboxGrup.SelectedValue.ToString();

                frmGrupSilme frm = new frmGrupSilme();
                frm.ShowDialog();

                gruplar();
            }
            else XtraMessageBox.Show("Lütfen Daha Fazla Grup Ekleyin");
        }

        private void nbıGrupGuncelle_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            GrupID = cboxGrup.SelectedValue.ToString();

            frmGrupGuncelle frm = new frmGrupGuncelle();
            frm.ShowDialog();

            gruplar();
        }

        private void nbıKisiSil_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (gridView1.RowCount <= 0)
            {
                XtraMessageBox.Show("Şu Anda Bu Grupta Hiç Kimse Yok");
            }
            else if (XtraMessageBox.Show("Seçilen Kişi Silinsin mi ?", "Bilgilendirmi", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                clsDelete cls = new clsDelete();
                cls.ID1 = gridView1.GetFocusedRowCellValue("ID").ToString();
                cls.kisiSilme();

                XtraMessageBox.Show("Kişi Başarılı Bir Şekilde Silindi");

                kisiler();
            }
        }

        private void nbıKisiyiGuncelle_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (gridView1.RowCount > 0)
            {
                KisiID = gridView1.GetFocusedRowCellValue("ID").ToString();

                frmKisiGuncelle frm = new frmKisiGuncelle();
                frm.ShowDialog();

                kisiler();
            }
            else
            {
                XtraMessageBox.Show("Şu Anda Bu Grupta Hiç Kimse Yok");
            }
        }

        private void nbıKisiGrupUp_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (gridView1.RowCount > 0)
            {
                GrupID = gridView1.GetFocusedRowCellValue("grupID").ToString();
                KisiID = gridView1.GetFocusedRowCellValue("ID").ToString();

                frmKisiGrupGuncelle frm = new frmKisiGrupGuncelle();
                frm.ShowDialog();

                kisiler();
            }
            else
            {
                XtraMessageBox.Show("Şu Anda Bu Grupta Hiç Kimse Yok");
            }

        }

    }
}