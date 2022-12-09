namespace butak
{
    partial class frmYilSecim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmYilSecim));
            this.btnRaporHazirla = new DevExpress.XtraEditors.SimpleButton();
            this.cboxYil = new System.Windows.Forms.ComboBox();
            this.lblAciklama1 = new DevExpress.XtraEditors.LabelControl();
            this.SuspendLayout();
            // 
            // btnRaporHazirla
            // 
            this.btnRaporHazirla.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRaporHazirla.ImageOptions.Image")));
            this.btnRaporHazirla.Location = new System.Drawing.Point(55, 91);
            this.btnRaporHazirla.Name = "btnRaporHazirla";
            this.btnRaporHazirla.Size = new System.Drawing.Size(119, 49);
            this.btnRaporHazirla.TabIndex = 9;
            this.btnRaporHazirla.Text = "Raporu Hazırla";
            this.btnRaporHazirla.Click += new System.EventHandler(this.btnRaporHazirla_Click);
            // 
            // cboxYil
            // 
            this.cboxYil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxYil.FormattingEnabled = true;
            this.cboxYil.Location = new System.Drawing.Point(53, 36);
            this.cboxYil.Name = "cboxYil";
            this.cboxYil.Size = new System.Drawing.Size(121, 21);
            this.cboxYil.TabIndex = 7;
            // 
            // lblAciklama1
            // 
            this.lblAciklama1.Location = new System.Drawing.Point(30, 39);
            this.lblAciklama1.Name = "lblAciklama1";
            this.lblAciklama1.Size = new System.Drawing.Size(17, 13);
            this.lblAciklama1.TabIndex = 5;
            this.lblAciklama1.Text = "Yıl :";
            // 
            // frmYilSecim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(198, 166);
            this.Controls.Add(this.btnRaporHazirla);
            this.Controls.Add(this.cboxYil);
            this.Controls.Add(this.lblAciklama1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmYilSecim";
            this.Text = "Yıl Seçimi";
            this.Load += new System.EventHandler(this.frmYilSecim_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnRaporHazirla;
        private System.Windows.Forms.ComboBox cboxYil;
        private DevExpress.XtraEditors.LabelControl lblAciklama1;
    }
}