namespace butak
{
    partial class frmYilAyGunSecim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmYilAyGunSecim));
            this.dateNavigator1 = new DevExpress.XtraScheduler.DateNavigator();
            this.btnRaporHazirla = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dateNavigator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNavigator1.CalendarTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // dateNavigator1
            // 
            this.dateNavigator1.CalendarAppearance.DayCellSpecial.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.dateNavigator1.CalendarAppearance.DayCellSpecial.Options.UseFont = true;
            this.dateNavigator1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNavigator1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dateNavigator1.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.dateNavigator1.Location = new System.Drawing.Point(13, 6);
            this.dateNavigator1.Name = "dateNavigator1";
            this.dateNavigator1.Size = new System.Drawing.Size(213, 243);
            this.dateNavigator1.TabIndex = 0;
            // 
            // btnRaporHazirla
            // 
            this.btnRaporHazirla.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRaporHazirla.ImageOptions.Image")));
            this.btnRaporHazirla.Location = new System.Drawing.Point(59, 255);
            this.btnRaporHazirla.Name = "btnRaporHazirla";
            this.btnRaporHazirla.Size = new System.Drawing.Size(119, 49);
            this.btnRaporHazirla.TabIndex = 10;
            this.btnRaporHazirla.Text = "Raporu Hazırla";
            this.btnRaporHazirla.Click += new System.EventHandler(this.btnRaporHazirla_Click);
            // 
            // frmYilAyGunSecim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 310);
            this.Controls.Add(this.btnRaporHazirla);
            this.Controls.Add(this.dateNavigator1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmYilAyGunSecim";
            this.Text = "Tarih Seçimi";
            ((System.ComponentModel.ISupportInitialize)(this.dateNavigator1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNavigator1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraScheduler.DateNavigator dateNavigator1;
        private DevExpress.XtraEditors.SimpleButton btnRaporHazirla;
    }
}