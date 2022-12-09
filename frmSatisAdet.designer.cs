namespace butak
{
    partial class frmSatisAdet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSatisAdet));
            this.lblAciklama1 = new DevExpress.XtraEditors.LabelControl();
            this.txtAdet = new DevExpress.XtraEditors.TextEdit();
            this.btnSepteEkle = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdet.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAciklama1
            // 
            this.lblAciklama1.Location = new System.Drawing.Point(27, 35);
            this.lblAciklama1.Name = "lblAciklama1";
            this.lblAciklama1.Size = new System.Drawing.Size(117, 13);
            this.lblAciklama1.TabIndex = 0;
            this.lblAciklama1.Text = "Sepete Eklenecek Adet :";
            // 
            // txtAdet
            // 
            this.txtAdet.Location = new System.Drawing.Point(150, 32);
            this.txtAdet.Name = "txtAdet";
            this.txtAdet.Properties.Mask.BeepOnError = true;
            this.txtAdet.Properties.Mask.EditMask = "d";
            this.txtAdet.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtAdet.Size = new System.Drawing.Size(100, 20);
            this.txtAdet.TabIndex = 1;
            // 
            // btnSepteEkle
            // 
            this.btnSepteEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSepteEkle.ImageOptions.Image")));
            this.btnSepteEkle.Location = new System.Drawing.Point(70, 69);
            this.btnSepteEkle.Name = "btnSepteEkle";
            this.btnSepteEkle.Size = new System.Drawing.Size(141, 45);
            this.btnSepteEkle.TabIndex = 2;
            this.btnSepteEkle.Text = "Sepete Ekle";
            this.btnSepteEkle.Click += new System.EventHandler(this.btnSepteEkle_Click);
            // 
            // frmSatisAdet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 131);
            this.Controls.Add(this.btnSepteEkle);
            this.Controls.Add(this.txtAdet);
            this.Controls.Add(this.lblAciklama1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSatisAdet";
            this.Text = "Sepete Eklenecek Adet";
            ((System.ComponentModel.ISupportInitialize)(this.txtAdet.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblAciklama1;
        private DevExpress.XtraEditors.TextEdit txtAdet;
        private DevExpress.XtraEditors.SimpleButton btnSepteEkle;
    }
}