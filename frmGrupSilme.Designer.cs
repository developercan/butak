namespace butak
{
    partial class frmGrupSilme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGrupSilme));
            this.lblAciklama1 = new DevExpress.XtraEditors.LabelControl();
            this.cboxAktarmaGrp = new System.Windows.Forms.ComboBox();
            this.btnGrupSilme = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // lblAciklama1
            // 
            this.lblAciklama1.Location = new System.Drawing.Point(12, 12);
            this.lblAciklama1.Name = "lblAciklama1";
            this.lblAciklama1.Size = new System.Drawing.Size(126, 13);
            this.lblAciklama1.TabIndex = 0;
            this.lblAciklama1.Text = "Kişilerin Aktarılacağı Grup :";
            // 
            // cboxAktarmaGrp
            // 
            this.cboxAktarmaGrp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxAktarmaGrp.FormattingEnabled = true;
            this.cboxAktarmaGrp.Location = new System.Drawing.Point(155, 9);
            this.cboxAktarmaGrp.Name = "cboxAktarmaGrp";
            this.cboxAktarmaGrp.Size = new System.Drawing.Size(171, 21);
            this.cboxAktarmaGrp.TabIndex = 2;
            // 
            // btnGrupSilme
            // 
            this.btnGrupSilme.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGrupSilme.ImageOptions.Image")));
            this.btnGrupSilme.Location = new System.Drawing.Point(196, 36);
            this.btnGrupSilme.Name = "btnGrupSilme";
            this.btnGrupSilme.Size = new System.Drawing.Size(97, 46);
            this.btnGrupSilme.TabIndex = 3;
            this.btnGrupSilme.Text = "Grubu Sil";
            this.btnGrupSilme.Click += new System.EventHandler(this.btnGrupSilme_Click);
            // 
            // frmGrupSilme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 94);
            this.Controls.Add(this.btnGrupSilme);
            this.Controls.Add(this.cboxAktarmaGrp);
            this.Controls.Add(this.lblAciklama1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmGrupSilme";
            this.Text = "Grup Silme";
            this.Load += new System.EventHandler(this.frmGrupSilme_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblAciklama1;
        private System.Windows.Forms.ComboBox cboxAktarmaGrp;
        private DevExpress.XtraEditors.SimpleButton btnGrupSilme;
    }
}