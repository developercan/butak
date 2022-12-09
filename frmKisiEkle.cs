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
    public partial class frmKisiEkle : DevExpress.XtraEditors.XtraForm
    {
        public frmKisiEkle()
        {
            InitializeComponent();
        }


        private void frmKisiEkle_Load(object sender, EventArgs e)
        {
            clsSelect cls = new clsSelect();
            cls.gruplar();

            cboxGrup.DisplayMember = "grupAd";
            cboxGrup.ValueMember = "ID";
            cboxGrup.DataSource = cls.dt;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            clsInsert cls = new clsInsert();
            cls.GrupID = cboxGrup.SelectedValue.ToString();
            cls.Ad = txtAd.Text;
            cls.Soyad = txtSoyad.Text;
            cls.TelNo = txtTel.Text;
            cls.Email = txtEposta.Text;
            cls.kisiEkle();
        }
    }
}