namespace butak
{
    partial class frmRehber
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRehber));
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.nbgGrupIslem = new DevExpress.XtraNavBar.NavBarGroup();
            this.nbıGrupEkle = new DevExpress.XtraNavBar.NavBarItem();
            this.nbıGrupSil = new DevExpress.XtraNavBar.NavBarItem();
            this.nbıGrupGuncelle = new DevExpress.XtraNavBar.NavBarItem();
            this.nbgKisiIslemleri = new DevExpress.XtraNavBar.NavBarGroup();
            this.nbıKisiEkle = new DevExpress.XtraNavBar.NavBarItem();
            this.nbıKisiSil = new DevExpress.XtraNavBar.NavBarItem();
            this.nbıKisiyiGuncelle = new DevExpress.XtraNavBar.NavBarItem();
            this.nbıKisiGrupUp = new DevExpress.XtraNavBar.NavBarItem();
            this.lblAciklama1 = new DevExpress.XtraEditors.LabelControl();
            this.txtAra = new DevExpress.XtraEditors.TextEdit();
            this.lblAciklama2 = new DevExpress.XtraEditors.LabelControl();
            this.cboxGrup = new System.Windows.Forms.ComboBox();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnAra = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAra.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.nbgGrupIslem;
            this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.nbgGrupIslem,
            this.nbgKisiIslemleri});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.nbıGrupEkle,
            this.nbıGrupSil,
            this.nbıGrupGuncelle,
            this.nbıKisiEkle,
            this.nbıKisiSil,
            this.nbıKisiyiGuncelle,
            this.nbıKisiGrupUp});
            this.navBarControl1.Location = new System.Drawing.Point(0, 0);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 220;
            this.navBarControl1.Size = new System.Drawing.Size(220, 580);
            this.navBarControl1.TabIndex = 0;
            this.navBarControl1.Text = "navBarControl1";
            // 
            // nbgGrupIslem
            // 
            this.nbgGrupIslem.Caption = "Grup İşlemleri";
            this.nbgGrupIslem.Expanded = true;
            this.nbgGrupIslem.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbıGrupEkle),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbıGrupSil),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbıGrupGuncelle)});
            this.nbgGrupIslem.LargeImage = ((System.Drawing.Image)(resources.GetObject("nbgGrupIslem.LargeImage")));
            this.nbgGrupIslem.Name = "nbgGrupIslem";
            // 
            // nbıGrupEkle
            // 
            this.nbıGrupEkle.Caption = "Grup Ekle";
            this.nbıGrupEkle.Name = "nbıGrupEkle";
            this.nbıGrupEkle.SmallImage = ((System.Drawing.Image)(resources.GetObject("nbıGrupEkle.SmallImage")));
            this.nbıGrupEkle.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbıGrupEkle_LinkClicked);
            // 
            // nbıGrupSil
            // 
            this.nbıGrupSil.Caption = "Seçilen Grubu Silme";
            this.nbıGrupSil.Name = "nbıGrupSil";
            this.nbıGrupSil.SmallImage = ((System.Drawing.Image)(resources.GetObject("nbıGrupSil.SmallImage")));
            this.nbıGrupSil.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbıGrupSil_LinkClicked);
            // 
            // nbıGrupGuncelle
            // 
            this.nbıGrupGuncelle.Caption = "Seçilen Grubu Güncelle";
            this.nbıGrupGuncelle.Name = "nbıGrupGuncelle";
            this.nbıGrupGuncelle.SmallImage = ((System.Drawing.Image)(resources.GetObject("nbıGrupGuncelle.SmallImage")));
            this.nbıGrupGuncelle.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbıGrupGuncelle_LinkClicked);
            // 
            // nbgKisiIslemleri
            // 
            this.nbgKisiIslemleri.Caption = "Kişi İşlemleri";
            this.nbgKisiIslemleri.Expanded = true;
            this.nbgKisiIslemleri.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbıKisiEkle),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbıKisiSil),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbıKisiyiGuncelle),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbıKisiGrupUp)});
            this.nbgKisiIslemleri.LargeImage = ((System.Drawing.Image)(resources.GetObject("nbgKisiIslemleri.LargeImage")));
            this.nbgKisiIslemleri.Name = "nbgKisiIslemleri";
            // 
            // nbıKisiEkle
            // 
            this.nbıKisiEkle.Caption = "Kişi Ekle";
            this.nbıKisiEkle.Name = "nbıKisiEkle";
            this.nbıKisiEkle.SmallImage = ((System.Drawing.Image)(resources.GetObject("nbıKisiEkle.SmallImage")));
            this.nbıKisiEkle.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbıKisiEkle_LinkClicked);
            // 
            // nbıKisiSil
            // 
            this.nbıKisiSil.Caption = "Seçilen Kişiyi Sil";
            this.nbıKisiSil.Name = "nbıKisiSil";
            this.nbıKisiSil.SmallImage = ((System.Drawing.Image)(resources.GetObject("nbıKisiSil.SmallImage")));
            this.nbıKisiSil.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbıKisiSil_LinkClicked);
            // 
            // nbıKisiyiGuncelle
            // 
            this.nbıKisiyiGuncelle.Caption = "Seçilen Kişiyi Güncelle";
            this.nbıKisiyiGuncelle.Name = "nbıKisiyiGuncelle";
            this.nbıKisiyiGuncelle.SmallImage = ((System.Drawing.Image)(resources.GetObject("nbıKisiyiGuncelle.SmallImage")));
            this.nbıKisiyiGuncelle.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbıKisiyiGuncelle_LinkClicked);
            // 
            // nbıKisiGrupUp
            // 
            this.nbıKisiGrupUp.Caption = "Seçilen Kişinin Grubunu Güncelle";
            this.nbıKisiGrupUp.Name = "nbıKisiGrupUp";
            this.nbıKisiGrupUp.SmallImage = ((System.Drawing.Image)(resources.GetObject("nbıKisiGrupUp.SmallImage")));
            this.nbıKisiGrupUp.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbıKisiGrupUp_LinkClicked);
            // 
            // lblAciklama1
            // 
            this.lblAciklama1.Location = new System.Drawing.Point(226, 15);
            this.lblAciklama1.Name = "lblAciklama1";
            this.lblAciklama1.Size = new System.Drawing.Size(24, 13);
            this.lblAciklama1.TabIndex = 1;
            this.lblAciklama1.Text = "Ara :";
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(256, 12);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(199, 20);
            this.txtAra.TabIndex = 2;
            // 
            // lblAciklama2
            // 
            this.lblAciklama2.Location = new System.Drawing.Point(560, 15);
            this.lblAciklama2.Name = "lblAciklama2";
            this.lblAciklama2.Size = new System.Drawing.Size(86, 13);
            this.lblAciklama2.TabIndex = 3;
            this.lblAciklama2.Text = "Grubu Görüntüle :";
            // 
            // cboxGrup
            // 
            this.cboxGrup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxGrup.FormattingEnabled = true;
            this.cboxGrup.Location = new System.Drawing.Point(652, 12);
            this.cboxGrup.Name = "cboxGrup";
            this.cboxGrup.Size = new System.Drawing.Size(199, 21);
            this.cboxGrup.TabIndex = 4;
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(229, 49);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(625, 519);
            this.gridControl1.TabIndex = 5;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // btnAra
            // 
            this.btnAra.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAra.ImageOptions.Image")));
            this.btnAra.Location = new System.Drawing.Point(461, 1);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(93, 42);
            this.btnAra.TabIndex = 6;
            this.btnAra.Text = "Ara";
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // frmRehber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 580);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.cboxGrup);
            this.Controls.Add(this.lblAciklama2);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.lblAciklama1);
            this.Controls.Add(this.navBarControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRehber";
            this.Text = "Rehber";
            this.Load += new System.EventHandler(this.frmRehber_Load);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAra.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup nbgGrupIslem;
        private DevExpress.XtraNavBar.NavBarItem nbıGrupEkle;
        private DevExpress.XtraNavBar.NavBarItem nbıGrupSil;
        private DevExpress.XtraNavBar.NavBarItem nbıGrupGuncelle;
        private DevExpress.XtraNavBar.NavBarGroup nbgKisiIslemleri;
        private DevExpress.XtraNavBar.NavBarItem nbıKisiEkle;
        private DevExpress.XtraNavBar.NavBarItem nbıKisiSil;
        private DevExpress.XtraNavBar.NavBarItem nbıKisiyiGuncelle;
        private DevExpress.XtraNavBar.NavBarItem nbıKisiGrupUp;
        private DevExpress.XtraEditors.LabelControl lblAciklama1;
        private DevExpress.XtraEditors.TextEdit txtAra;
        private DevExpress.XtraEditors.LabelControl lblAciklama2;
        private System.Windows.Forms.ComboBox cboxGrup;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btnAra;
    }
}