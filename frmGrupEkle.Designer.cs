namespace butak
{
    partial class frmGrupEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGrupEkle));
            this.lblAciklama1 = new DevExpress.XtraEditors.LabelControl();
            this.txtGrup = new DevExpress.XtraEditors.TextEdit();
            this.btnGrpEkle = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtGrup.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAciklama1
            // 
            this.lblAciklama1.Location = new System.Drawing.Point(12, 32);
            this.lblAciklama1.Name = "lblAciklama1";
            this.lblAciklama1.Size = new System.Drawing.Size(48, 13);
            this.lblAciklama1.TabIndex = 0;
            this.lblAciklama1.Text = "Grup Adı :";
            // 
            // txtGrup
            // 
            this.txtGrup.Location = new System.Drawing.Point(66, 29);
            this.txtGrup.Name = "txtGrup";
            this.txtGrup.Size = new System.Drawing.Size(149, 20);
            this.txtGrup.TabIndex = 1;
            // 
            // btnGrpEkle
            // 
            this.btnGrpEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGrpEkle.ImageOptions.Image")));
            this.btnGrpEkle.Location = new System.Drawing.Point(97, 65);
            this.btnGrpEkle.Name = "btnGrpEkle";
            this.btnGrpEkle.Size = new System.Drawing.Size(100, 46);
            this.btnGrpEkle.TabIndex = 2;
            this.btnGrpEkle.Text = "Grup Ekle";
            this.btnGrpEkle.Click += new System.EventHandler(this.btnGrpEkle_Click);
            // 
            // frmGrupEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 127);
            this.Controls.Add(this.btnGrpEkle);
            this.Controls.Add(this.txtGrup);
            this.Controls.Add(this.lblAciklama1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmGrupEkle";
            this.Text = "Grup Ekleme";
            ((System.ComponentModel.ISupportInitialize)(this.txtGrup.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblAciklama1;
        private DevExpress.XtraEditors.TextEdit txtGrup;
        private DevExpress.XtraEditors.SimpleButton btnGrpEkle;
    }
}