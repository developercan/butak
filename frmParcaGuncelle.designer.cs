namespace butak
{
    partial class frmParcaGuncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmParcaGuncelle));
            this.btnParcaGor = new DevExpress.XtraEditors.SimpleButton();
            this.txtArama = new DevExpress.XtraEditors.TextEdit();
            this.lblAciklama1 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnAra = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtArama.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnParcaGor
            // 
            this.btnParcaGor.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnParcaGor.ImageOptions.Image")));
            this.btnParcaGor.Location = new System.Drawing.Point(612, 5);
            this.btnParcaGor.Name = "btnParcaGor";
            this.btnParcaGor.Size = new System.Drawing.Size(184, 46);
            this.btnParcaGor.TabIndex = 7;
            this.btnParcaGor.Text = "Seçilen Parçayı Görüntüle";
            this.btnParcaGor.Click += new System.EventHandler(this.btnParcaGor_Click);
            // 
            // txtArama
            // 
            this.txtArama.Location = new System.Drawing.Point(42, 18);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(246, 20);
            this.txtArama.TabIndex = 6;
            // 
            // lblAciklama1
            // 
            this.lblAciklama1.Location = new System.Drawing.Point(12, 21);
            this.lblAciklama1.Name = "lblAciklama1";
            this.lblAciklama1.Size = new System.Drawing.Size(24, 13);
            this.lblAciklama1.TabIndex = 5;
            this.lblAciklama1.Text = "Ara :";
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(0, 57);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(796, 473);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // btnAra
            // 
            this.btnAra.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAra.ImageOptions.Image")));
            this.btnAra.Location = new System.Drawing.Point(294, 7);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(121, 42);
            this.btnAra.TabIndex = 11;
            this.btnAra.Text = "Parçayı Ara";
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // frmParcaGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 532);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.btnParcaGor);
            this.Controls.Add(this.txtArama);
            this.Controls.Add(this.lblAciklama1);
            this.Controls.Add(this.gridControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmParcaGuncelle";
            this.Text = "Parça Güncelleme";
            this.Load += new System.EventHandler(this.frmParcaGuncelle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtArama.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnParcaGor;
        private DevExpress.XtraEditors.TextEdit txtArama;
        private DevExpress.XtraEditors.LabelControl lblAciklama1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btnAra;
    }
}