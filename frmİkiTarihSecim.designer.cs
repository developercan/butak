namespace butak
{
    partial class frmİkiTarihSecim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmİkiTarihSecim));
            this.dnIlkTarih = new DevExpress.XtraScheduler.DateNavigator();
            this.dnSonTarih = new DevExpress.XtraScheduler.DateNavigator();
            this.btnRaporHazirla = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dnIlkTarih)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dnIlkTarih.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dnSonTarih)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dnSonTarih.CalendarTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // dnIlkTarih
            // 
            this.dnIlkTarih.CalendarAppearance.DayCellSpecial.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.dnIlkTarih.CalendarAppearance.DayCellSpecial.Options.UseFont = true;
            this.dnIlkTarih.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dnIlkTarih.Cursor = System.Windows.Forms.Cursors.Default;
            this.dnIlkTarih.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.dnIlkTarih.Location = new System.Drawing.Point(12, 12);
            this.dnIlkTarih.Name = "dnIlkTarih";
            this.dnIlkTarih.Size = new System.Drawing.Size(213, 243);
            this.dnIlkTarih.TabIndex = 0;
            // 
            // dnSonTarih
            // 
            this.dnSonTarih.CalendarAppearance.DayCellSpecial.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.dnSonTarih.CalendarAppearance.DayCellSpecial.Options.UseFont = true;
            this.dnSonTarih.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dnSonTarih.Cursor = System.Windows.Forms.Cursors.Default;
            this.dnSonTarih.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.dnSonTarih.Location = new System.Drawing.Point(231, 12);
            this.dnSonTarih.Name = "dnSonTarih";
            this.dnSonTarih.Size = new System.Drawing.Size(213, 243);
            this.dnSonTarih.TabIndex = 1;
            // 
            // btnRaporHazirla
            // 
            this.btnRaporHazirla.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRaporHazirla.ImageOptions.Image")));
            this.btnRaporHazirla.Location = new System.Drawing.Point(172, 265);
            this.btnRaporHazirla.Name = "btnRaporHazirla";
            this.btnRaporHazirla.Size = new System.Drawing.Size(119, 49);
            this.btnRaporHazirla.TabIndex = 5;
            this.btnRaporHazirla.Text = "Raporu Hazırla";
            this.btnRaporHazirla.Click += new System.EventHandler(this.btnRaporHazirla_Click);
            // 
            // frmİkiTarihSecim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 326);
            this.Controls.Add(this.btnRaporHazirla);
            this.Controls.Add(this.dnSonTarih);
            this.Controls.Add(this.dnIlkTarih);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmİkiTarihSecim";
            this.Text = "Tarih Seçimi";
            ((System.ComponentModel.ISupportInitialize)(this.dnIlkTarih.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dnIlkTarih)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dnSonTarih.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dnSonTarih)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraScheduler.DateNavigator dnIlkTarih;
        private DevExpress.XtraScheduler.DateNavigator dnSonTarih;
        private DevExpress.XtraEditors.SimpleButton btnRaporHazirla;
    }
}