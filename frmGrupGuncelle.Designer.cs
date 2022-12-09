namespace butak
{
    partial class frmGrupGuncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGrupGuncelle));
            this.lblAciklama1 = new DevExpress.XtraEditors.LabelControl();
            this.txtGrupAd = new DevExpress.XtraEditors.TextEdit();
            this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtGrupAd.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAciklama1
            // 
            this.lblAciklama1.Location = new System.Drawing.Point(12, 21);
            this.lblAciklama1.Name = "lblAciklama1";
            this.lblAciklama1.Size = new System.Drawing.Size(60, 13);
            this.lblAciklama1.TabIndex = 0;
            this.lblAciklama1.Text = "Grubun Adı :";
            // 
            // txtGrupAd
            // 
            this.txtGrupAd.Location = new System.Drawing.Point(78, 18);
            this.txtGrupAd.Name = "txtGrupAd";
            this.txtGrupAd.Size = new System.Drawing.Size(176, 20);
            this.txtGrupAd.TabIndex = 1;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGuncelle.ImageOptions.Image")));
            this.btnGuncelle.Location = new System.Drawing.Point(108, 44);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(118, 42);
            this.btnGuncelle.TabIndex = 2;
            this.btnGuncelle.Text = "Grubu Güncelle";
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // frmGrupGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 106);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.txtGrupAd);
            this.Controls.Add(this.lblAciklama1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmGrupGuncelle";
            this.Text = "Grup Güncelleme";
            this.Load += new System.EventHandler(this.frmGrupGuncelle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtGrupAd.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblAciklama1;
        private DevExpress.XtraEditors.TextEdit txtGrupAd;
        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
    }
}