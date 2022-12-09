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
    public partial class frmKisiGrupGuncelle : DevExpress.XtraEditors.XtraForm
    {
        public frmKisiGrupGuncelle()
        {
            InitializeComponent();
        }

        private void frmKisiGrupGuncelle_Load(object sender, EventArgs e)
        {
            clsSelect cls = new clsSelect();
            cls.grupGoruntuleme();

            cboxGrup.DisplayMember = "grupAd";
            cboxGrup.ValueMember = "ID";
            cboxGrup.DataSource = cls.dt;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            clsUpdate cls = new clsUpdate();
            cls.GrupID = cboxGrup.SelectedValue.ToString();
            cls.kisiGrupGuncelle();

            XtraMessageBox.Show("Grup Başarılı Bir Şekilde Güncellendi");
            this.Close();
        }      
    }
}