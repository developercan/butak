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
    public partial class frmSepet : DevExpress.XtraEditors.XtraForm
    {
        public frmSepet()
        {
            InitializeComponent();
        }

        clsSelect cls = new clsSelect();

        int i = 0;
        int grpx = 12, grpy = 12;

        LabelControl lbltop;

        void dynamicObject()
        {
            GroupControl grp = new GroupControl();
            grp.Name = "grp" + i.ToString();
            grp.Size = new Size(737, 111);
            grp.Location = new Point(grpx, grpy);
            grp.Text = cls.dr["parcaAd"].ToString();
            xtraScrollableControl1.Controls.Add(grp);

            LabelControl lbl = new LabelControl();
            lbl.Name = "lbl" + i.ToString();
            lbl.Location = new Point(16, 57);
            lbl.Text = "Parça No :";
            grp.Controls.Add(lbl);

            LabelControl lblparcNo = new LabelControl();
            lblparcNo.Name = "lblparcaNo" + i.ToString();
            lblparcNo.Location = new Point(72, 57);
            lblparcNo.Text = cls.dr["parcaNo"].ToString();
            grp.Controls.Add(lblparcNo);

            LabelControl lbl2 = new LabelControl();
            lbl2.Name = "lbl2" + i.ToString();
            lbl2.Location = new Point(231, 57);
            lbl2.Text = "Adet :";
            grp.Controls.Add(lbl2);

            LabelControl lblAdet = new LabelControl();
            lblAdet.Name = "lblAdet" + i.ToString();
            lblAdet.Location = new Point(267, 57);
            lblAdet.Text = cls.dr["adet"].ToString();
            grp.Controls.Add(lblAdet);

            LabelControl lbl3 = new LabelControl();
            lbl3.Name = "lbl3" + i.ToString();
            lbl3.Location = new Point(429, 57);
            lbl3.Text = "Fiyat :";
            grp.Controls.Add(lbl3);

            TextEdit txtfiyat = new TextEdit();
            txtfiyat.Name = "lblfiyat" + i.ToString();
            txtfiyat.Location = new Point(466, 57);
            txtfiyat.Size = new Size(63, 20);
            txtfiyat.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            txtfiyat.Properties.Mask.EditMask = "f";
            txtfiyat.Properties.Mask.UseMaskAsDisplayFormat = true;
            txtfiyat.Text = (double.Parse(cls.dr["fiyat"].ToString()) * int.Parse(lblAdet.Text)).ToString();
            txtfiyat.Tag = cls.dr["ID"].ToString();
            txtfiyat.KeyDown += Txtfiyat_KeyDown;
            grp.Controls.Add(txtfiyat);

            SimpleButton btn = new SimpleButton();
            btn.Name = "btn" + i.ToString();
            btn.Location = new Point(603, 43);
            btn.Size = new Size(84, 42);
            btn.Text = "Ürünü Kaldır";
            btn.Click += BtnUrunKaldir;
            btn.Tag = cls.dr["ID"].ToString();
            grp.Controls.Add(btn);

            i++;
            grpy += 117;
        }

        void dynamicObject2()
        {
            clsSelect cls2 = new clsSelect();

            SimpleButton btn = new SimpleButton();
            btn.Name = "btnkaldir";
            btn.Location = new Point(661, grpy);
            btn.Size = new Size(84, 42);
            btn.Text = "Ürünleri Kaldır";
            btn.Click += BtnUrunleriKaldir;
            xtraScrollableControl1.Controls.Add(btn);

            SimpleButton btnsatis = new SimpleButton();
            btnsatis.Name = "btnsatis";
            btnsatis.Location = new Point(565, grpy);
            btnsatis.Size = new Size(84, 42);
            btnsatis.Text = "Ürünleri Sat";
            btnsatis.Click += Btnsatis_Click;
            xtraScrollableControl1.Controls.Add(btnsatis);

            LabelControl lbl = new LabelControl();
            lbl.Name = "lbl4" + i.ToString();
            lbl.Location = new Point(16, grpy);
            lbl.Text = "Toplam Fiyat :";
            xtraScrollableControl1.Controls.Add(lbl);


            cls2.sepetToplam();
            lbltop = new LabelControl();
            lbltop.Name = "lbltop";
            lbltop.Location = new Point(90, grpy);
            lbltop.Text = cls2.ToplamFiyat;
            xtraScrollableControl1.Controls.Add(lbltop);
        }

        private void frmSepet_Load(object sender, EventArgs e)
        {

            cls.sepetVeri();
            while (cls.dr.Read())
            {
                dynamicObject();
            }
            cls.dr.Close();
            cls.conn.Close();

            dynamicObject2();
        }

        private void Txtfiyat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TextEdit txt = sender as TextEdit;

                clsUpdate cls2 = new clsUpdate();
                cls2.ID1 = txt.Tag.ToString();
                cls2.Fiyat = txt.Text;
                cls2.sepetFiyatGuncelleme();

                clsSelect cls3 = new clsSelect();
                cls3.sepetToplam();
                lbltop.Text = cls3.ToplamFiyat;
            }
        }

        private void BtnUrunKaldir(object sender, EventArgs e)
        {
            SimpleButton btn = sender as SimpleButton;

            int uzunluk = btn.Name.Length - 3;
            string name = btn.Name.Substring(3, uzunluk);

            foreach (Control item in xtraScrollableControl1.Controls)
            {
                if (item is GroupControl && item.Name == "grp" + name)
                {
                    xtraScrollableControl1.Controls.Remove(item);
                }
            }

            clsDelete cls2 = new clsDelete();
            cls2.ID1 = btn.Tag.ToString();
            cls2.sepetParcaSilme();

            clsSelect cls3 = new clsSelect();
            cls3.sepetToplam();
            lbltop.Text = cls3.ToplamFiyat;
        }

        private void BtnUrunleriKaldir(object sender, EventArgs e)
        {
            SimpleButton btn = sender as SimpleButton;

            xtraScrollableControl1.Controls.Clear();
            clsDelete cls2 = new clsDelete();
            cls2.sepetBosaltma();

        }

        private void Btnsatis_Click(object sender, EventArgs e)
        {
            frmUrunSatis frm = new frmUrunSatis();
            frm.ShowDialog();

            if (frmUrunSatis.satildi == true)
            {
                frmUrunSatis.satildi = false;
                this.Close();
            }
        }
    }
}