namespace butak
{
    partial class frmKisiGuncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKisiGuncelle));
            this.lblAciklama1 = new DevExpress.XtraEditors.LabelControl();
            this.txtAd = new DevExpress.XtraEditors.TextEdit();
            this.txtSoyad = new DevExpress.XtraEditors.TextEdit();
            this.lblAciklama2 = new DevExpress.XtraEditors.LabelControl();
            this.txtTelno = new DevExpress.XtraEditors.TextEdit();
            this.lblAciklama3 = new DevExpress.XtraEditors.LabelControl();
            this.txtEposta = new DevExpress.XtraEditors.TextEdit();
            this.lblAciklama4 = new DevExpress.XtraEditors.LabelControl();
            this.btnKisiGuncelle = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoyad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelno.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEposta.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAciklama1
            // 
            this.lblAciklama1.Location = new System.Drawing.Point(43, 21);
            this.lblAciklama1.Name = "lblAciklama1";
            this.lblAciklama1.Size = new System.Drawing.Size(22, 13);
            this.lblAciklama1.TabIndex = 0;
            this.lblAciklama1.Text = "Adı :";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(122, 18);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(140, 20);
            this.txtAd.TabIndex = 1;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(122, 49);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(140, 20);
            this.txtSoyad.TabIndex = 3;
            // 
            // lblAciklama2
            // 
            this.lblAciklama2.Location = new System.Drawing.Point(43, 52);
            this.lblAciklama2.Name = "lblAciklama2";
            this.lblAciklama2.Size = new System.Drawing.Size(39, 13);
            this.lblAciklama2.TabIndex = 2;
            this.lblAciklama2.Text = "Soyadı :";
            // 
            // txtTelno
            // 
            this.txtTelno.Location = new System.Drawing.Point(122, 81);
            this.txtTelno.Name = "txtTelno";
            this.txtTelno.Size = new System.Drawing.Size(140, 20);
            this.txtTelno.TabIndex = 5;
            // 
            // lblAciklama3
            // 
            this.lblAciklama3.Location = new System.Drawing.Point(43, 84);
            this.lblAciklama3.Name = "lblAciklama3";
            this.lblAciklama3.Size = new System.Drawing.Size(37, 13);
            this.lblAciklama3.TabIndex = 4;
            this.lblAciklama3.Text = "Tel No :";
            // 
            // txtEposta
            // 
            this.txtEposta.Location = new System.Drawing.Point(122, 112);
            this.txtEposta.Name = "txtEposta";
            this.txtEposta.Size = new System.Drawing.Size(140, 20);
            this.txtEposta.TabIndex = 7;
            // 
            // lblAciklama4
            // 
            this.lblAciklama4.Location = new System.Drawing.Point(43, 115);
            this.lblAciklama4.Name = "lblAciklama4";
            this.lblAciklama4.Size = new System.Drawing.Size(43, 13);
            this.lblAciklama4.TabIndex = 6;
            this.lblAciklama4.Text = "E posta :";
            // 
            // btnKisiGuncelle
            // 
            this.btnKisiGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKisiGuncelle.ImageOptions.Image")));
            this.btnKisiGuncelle.Location = new System.Drawing.Point(140, 138);
            this.btnKisiGuncelle.Name = "btnKisiGuncelle";
            this.btnKisiGuncelle.Size = new System.Drawing.Size(108, 51);
            this.btnKisiGuncelle.TabIndex = 8;
            this.btnKisiGuncelle.Text = "Kişi Güncelle";
            this.btnKisiGuncelle.Click += new System.EventHandler(this.btnKisiGuncelle_Click);
            // 
            // frmKisiGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 211);
            this.Controls.Add(this.btnKisiGuncelle);
            this.Controls.Add(this.txtEposta);
            this.Controls.Add(this.lblAciklama4);
            this.Controls.Add(this.txtTelno);
            this.Controls.Add(this.lblAciklama3);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.lblAciklama2);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.lblAciklama1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmKisiGuncelle";
            this.Text = "Kişi Güncelleme";
            this.Load += new System.EventHandler(this.frmKisiGuncelle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoyad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelno.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEposta.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblAciklama1;
        private DevExpress.XtraEditors.TextEdit txtAd;
        private DevExpress.XtraEditors.TextEdit txtSoyad;
        private DevExpress.XtraEditors.LabelControl lblAciklama2;
        private DevExpress.XtraEditors.TextEdit txtTelno;
        private DevExpress.XtraEditors.LabelControl lblAciklama3;
        private DevExpress.XtraEditors.TextEdit txtEposta;
        private DevExpress.XtraEditors.LabelControl lblAciklama4;
        private DevExpress.XtraEditors.SimpleButton btnKisiGuncelle;
    }
}