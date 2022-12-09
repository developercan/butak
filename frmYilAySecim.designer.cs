namespace butak
{
    partial class frmYilAySecim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmYilAySecim));
            this.lblAciklama1 = new DevExpress.XtraEditors.LabelControl();
            this.lblAciklama2 = new DevExpress.XtraEditors.LabelControl();
            this.cboxYil = new System.Windows.Forms.ComboBox();
            this.cboxAy = new System.Windows.Forms.ComboBox();
            this.btnRaporHazirla = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // lblAciklama1
            // 
            this.lblAciklama1.Location = new System.Drawing.Point(36, 23);
            this.lblAciklama1.Name = "lblAciklama1";
            this.lblAciklama1.Size = new System.Drawing.Size(17, 13);
            this.lblAciklama1.TabIndex = 0;
            this.lblAciklama1.Text = "Yıl :";
            // 
            // lblAciklama2
            // 
            this.lblAciklama2.Location = new System.Drawing.Point(31, 77);
            this.lblAciklama2.Name = "lblAciklama2";
            this.lblAciklama2.Size = new System.Drawing.Size(20, 13);
            this.lblAciklama2.TabIndex = 1;
            this.lblAciklama2.Text = "Ay :";
            // 
            // cboxYil
            // 
            this.cboxYil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxYil.FormattingEnabled = true;
            this.cboxYil.Location = new System.Drawing.Point(59, 20);
            this.cboxYil.Name = "cboxYil";
            this.cboxYil.Size = new System.Drawing.Size(121, 21);
            this.cboxYil.TabIndex = 2;
            this.cboxYil.SelectedValueChanged += new System.EventHandler(this.cboxYil_SelectedValueChanged);
            // 
            // cboxAy
            // 
            this.cboxAy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxAy.FormattingEnabled = true;
            this.cboxAy.Location = new System.Drawing.Point(57, 74);
            this.cboxAy.Name = "cboxAy";
            this.cboxAy.Size = new System.Drawing.Size(121, 21);
            this.cboxAy.TabIndex = 3;
            // 
            // btnRaporHazirla
            // 
            this.btnRaporHazirla.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRaporHazirla.ImageOptions.Image")));
            this.btnRaporHazirla.Location = new System.Drawing.Point(59, 119);
            this.btnRaporHazirla.Name = "btnRaporHazirla";
            this.btnRaporHazirla.Size = new System.Drawing.Size(119, 49);
            this.btnRaporHazirla.TabIndex = 4;
            this.btnRaporHazirla.Text = "Raporu Hazırla";
            this.btnRaporHazirla.Click += new System.EventHandler(this.btnRaporHazirla_Click);
            // 
            // frmYilAySecim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(215, 182);
            this.Controls.Add(this.btnRaporHazirla);
            this.Controls.Add(this.cboxAy);
            this.Controls.Add(this.cboxYil);
            this.Controls.Add(this.lblAciklama2);
            this.Controls.Add(this.lblAciklama1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmYilAySecim";
            this.Text = "Yıl Ve Ay Seçimi";
            this.Load += new System.EventHandler(this.frmYilSecim_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblAciklama1;
        private DevExpress.XtraEditors.LabelControl lblAciklama2;
        private System.Windows.Forms.ComboBox cboxYil;
        private System.Windows.Forms.ComboBox cboxAy;
        private DevExpress.XtraEditors.SimpleButton btnRaporHazirla;
    }
}