namespace butak
{
    partial class frmKisiGrupGuncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKisiGrupGuncelle));
            this.lblAciklama1 = new DevExpress.XtraEditors.LabelControl();
            this.cboxGrup = new System.Windows.Forms.ComboBox();
            this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // lblAciklama1
            // 
            this.lblAciklama1.Location = new System.Drawing.Point(12, 12);
            this.lblAciklama1.Name = "lblAciklama1";
            this.lblAciklama1.Size = new System.Drawing.Size(30, 13);
            this.lblAciklama1.TabIndex = 0;
            this.lblAciklama1.Text = "Grup :";
            // 
            // cboxGrup
            // 
            this.cboxGrup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxGrup.FormattingEnabled = true;
            this.cboxGrup.Location = new System.Drawing.Point(48, 9);
            this.cboxGrup.Name = "cboxGrup";
            this.cboxGrup.Size = new System.Drawing.Size(156, 21);
            this.cboxGrup.TabIndex = 1;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGuncelle.ImageOptions.Image")));
            this.btnGuncelle.Location = new System.Drawing.Point(70, 36);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(119, 42);
            this.btnGuncelle.TabIndex = 2;
            this.btnGuncelle.Text = "Grubu Güncelle";
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // frmKisiGrupGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(215, 93);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.cboxGrup);
            this.Controls.Add(this.lblAciklama1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmKisiGrupGuncelle";
            this.Text = "Kişinin Grubunu Güncelleme";
            this.Load += new System.EventHandler(this.frmKisiGrupGuncelle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblAciklama1;
        private System.Windows.Forms.ComboBox cboxGrup;
        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
    }
}