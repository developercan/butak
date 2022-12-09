namespace butak
{
    partial class frmKisiEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKisiEkle));
            this.lblAciklama1 = new DevExpress.XtraEditors.LabelControl();
            this.lblAciklama2 = new DevExpress.XtraEditors.LabelControl();
            this.lblAciklama3 = new DevExpress.XtraEditors.LabelControl();
            this.lblAciklama4 = new DevExpress.XtraEditors.LabelControl();
            this.lblAciklama5 = new DevExpress.XtraEditors.LabelControl();
            this.cboxGrup = new System.Windows.Forms.ComboBox();
            this.txtAd = new DevExpress.XtraEditors.TextEdit();
            this.txtSoyad = new DevExpress.XtraEditors.TextEdit();
            this.txtTel = new DevExpress.XtraEditors.TextEdit();
            this.txtEposta = new DevExpress.XtraEditors.TextEdit();
            this.btnEkle = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoyad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEposta.Properties)).BeginInit();
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
            // lblAciklama2
            // 
            this.lblAciklama2.Location = new System.Drawing.Point(12, 48);
            this.lblAciklama2.Name = "lblAciklama2";
            this.lblAciklama2.Size = new System.Drawing.Size(20, 13);
            this.lblAciklama2.TabIndex = 1;
            this.lblAciklama2.Text = "Ad :";
            // 
            // lblAciklama3
            // 
            this.lblAciklama3.Location = new System.Drawing.Point(12, 83);
            this.lblAciklama3.Name = "lblAciklama3";
            this.lblAciklama3.Size = new System.Drawing.Size(37, 13);
            this.lblAciklama3.TabIndex = 2;
            this.lblAciklama3.Text = "Soyad :";
            // 
            // lblAciklama4
            // 
            this.lblAciklama4.Location = new System.Drawing.Point(12, 119);
            this.lblAciklama4.Name = "lblAciklama4";
            this.lblAciklama4.Size = new System.Drawing.Size(37, 13);
            this.lblAciklama4.TabIndex = 3;
            this.lblAciklama4.Text = "Tel No :";
            // 
            // lblAciklama5
            // 
            this.lblAciklama5.Location = new System.Drawing.Point(12, 154);
            this.lblAciklama5.Name = "lblAciklama5";
            this.lblAciklama5.Size = new System.Drawing.Size(44, 13);
            this.lblAciklama5.TabIndex = 4;
            this.lblAciklama5.Text = "E-posta :";
            // 
            // cboxGrup
            // 
            this.cboxGrup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxGrup.FormattingEnabled = true;
            this.cboxGrup.Location = new System.Drawing.Point(78, 8);
            this.cboxGrup.Name = "cboxGrup";
            this.cboxGrup.Size = new System.Drawing.Size(181, 21);
            this.cboxGrup.TabIndex = 5;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(78, 45);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(181, 20);
            this.txtAd.TabIndex = 6;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(78, 80);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(181, 20);
            this.txtSoyad.TabIndex = 7;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(78, 116);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(181, 20);
            this.txtTel.TabIndex = 8;
            // 
            // txtEposta
            // 
            this.txtEposta.Location = new System.Drawing.Point(78, 151);
            this.txtEposta.Name = "txtEposta";
            this.txtEposta.Size = new System.Drawing.Size(181, 20);
            this.txtEposta.TabIndex = 9;
            // 
            // btnEkle
            // 
            this.btnEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEkle.ImageOptions.Image")));
            this.btnEkle.Location = new System.Drawing.Point(114, 177);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(94, 47);
            this.btnEkle.TabIndex = 10;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // frmKisiEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 236);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtEposta);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.cboxGrup);
            this.Controls.Add(this.lblAciklama5);
            this.Controls.Add(this.lblAciklama4);
            this.Controls.Add(this.lblAciklama3);
            this.Controls.Add(this.lblAciklama2);
            this.Controls.Add(this.lblAciklama1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmKisiEkle";
            this.Text = "Kişi Ekleme";
            this.Load += new System.EventHandler(this.frmKisiEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoyad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEposta.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblAciklama1;
        private DevExpress.XtraEditors.LabelControl lblAciklama2;
        private DevExpress.XtraEditors.LabelControl lblAciklama3;
        private DevExpress.XtraEditors.LabelControl lblAciklama4;
        private DevExpress.XtraEditors.LabelControl lblAciklama5;
        private System.Windows.Forms.ComboBox cboxGrup;
        private DevExpress.XtraEditors.TextEdit txtAd;
        private DevExpress.XtraEditors.TextEdit txtSoyad;
        private DevExpress.XtraEditors.TextEdit txtTel;
        private DevExpress.XtraEditors.TextEdit txtEposta;
        private DevExpress.XtraEditors.SimpleButton btnEkle;
    }
}