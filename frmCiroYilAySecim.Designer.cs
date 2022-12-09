namespace butak
{
    partial class frmCiroYilAySecim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCiroYilAySecim));
            this.cboxAy = new System.Windows.Forms.ComboBox();
            this.cboxYil = new System.Windows.Forms.ComboBox();
            this.lblAciklama2 = new DevExpress.XtraEditors.LabelControl();
            this.lblAciklama1 = new DevExpress.XtraEditors.LabelControl();
            this.btnHazirla = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // cboxAy
            // 
            this.cboxAy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxAy.FormattingEnabled = true;
            this.cboxAy.Location = new System.Drawing.Point(33, 63);
            this.cboxAy.Name = "cboxAy";
            this.cboxAy.Size = new System.Drawing.Size(121, 21);
            this.cboxAy.TabIndex = 7;
            // 
            // cboxYil
            // 
            this.cboxYil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxYil.FormattingEnabled = true;
            this.cboxYil.Location = new System.Drawing.Point(35, 9);
            this.cboxYil.Name = "cboxYil";
            this.cboxYil.Size = new System.Drawing.Size(121, 21);
            this.cboxYil.TabIndex = 6;
            this.cboxYil.SelectedValueChanged += new System.EventHandler(this.cboxYil_SelectedValueChanged);
            // 
            // lblAciklama2
            // 
            this.lblAciklama2.Location = new System.Drawing.Point(7, 66);
            this.lblAciklama2.Name = "lblAciklama2";
            this.lblAciklama2.Size = new System.Drawing.Size(20, 13);
            this.lblAciklama2.TabIndex = 5;
            this.lblAciklama2.Text = "Ay :";
            // 
            // lblAciklama1
            // 
            this.lblAciklama1.Location = new System.Drawing.Point(12, 12);
            this.lblAciklama1.Name = "lblAciklama1";
            this.lblAciklama1.Size = new System.Drawing.Size(17, 13);
            this.lblAciklama1.TabIndex = 4;
            this.lblAciklama1.Text = "Yıl :";
            // 
            // btnHazirla
            // 
            this.btnHazirla.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHazirla.ImageOptions.Image")));
            this.btnHazirla.Location = new System.Drawing.Point(28, 101);
            this.btnHazirla.Name = "btnHazirla";
            this.btnHazirla.Size = new System.Drawing.Size(126, 48);
            this.btnHazirla.TabIndex = 8;
            this.btnHazirla.Text = "Raporu Hazırla";
            this.btnHazirla.Click += new System.EventHandler(this.btnHazirla_Click);
            // 
            // frmCiroYilAySecim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(171, 165);
            this.Controls.Add(this.btnHazirla);
            this.Controls.Add(this.cboxAy);
            this.Controls.Add(this.cboxYil);
            this.Controls.Add(this.lblAciklama2);
            this.Controls.Add(this.lblAciklama1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmCiroYilAySecim";
            this.Text = "frmCiroYilAySecim";
            this.Load += new System.EventHandler(this.frmCiroYilAySecim_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboxAy;
        private System.Windows.Forms.ComboBox cboxYil;
        private DevExpress.XtraEditors.LabelControl lblAciklama2;
        private DevExpress.XtraEditors.LabelControl lblAciklama1;
        private DevExpress.XtraEditors.SimpleButton btnHazirla;
    }
}