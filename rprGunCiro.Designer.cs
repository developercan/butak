namespace butak
{
    partial class rprGunCiro
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

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.DataAccess.Sql.SelectQuery selectQuery1 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column1 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression1 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table1 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column2 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression2 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.SelectQuery selectQuery2 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column3 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression3 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table2 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column4 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression4 = new DevExpress.DataAccess.Sql.ColumnExpression();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.crtSatilanFiyat = new DevExpress.XtraReports.UI.XRChart();
            this.crtSatisFiyat = new DevExpress.XtraReports.UI.XRChart();
            this.lblAciklama1 = new DevExpress.XtraReports.UI.XRLabel();
            this.lblTopSatilanFiyat = new DevExpress.XtraReports.UI.XRLabel();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.sqlDataSource2 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.lblAciklama2 = new DevExpress.XtraReports.UI.XRLabel();
            this.lblTopSatisFiyat = new DevExpress.XtraReports.UI.XRLabel();
            this.lblAciklama3 = new DevExpress.XtraReports.UI.XRLabel();
            this.lblBazKDV = new DevExpress.XtraReports.UI.XRLabel();
            this.lblAciklama4 = new DevExpress.XtraReports.UI.XRLabel();
            this.lblTopKDV = new DevExpress.XtraReports.UI.XRLabel();
            this.lblAciklama5 = new DevExpress.XtraReports.UI.XRLabel();
            this.lblTopKar = new DevExpress.XtraReports.UI.XRLabel();
            this.lblAciklama6 = new DevExpress.XtraReports.UI.XRLabel();
            this.lblTopSatilanAdet = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this.crtSatilanFiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crtSatisFiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.crtSatilanFiyat,
            this.crtSatisFiyat,
            this.lblAciklama1,
            this.lblTopSatilanFiyat,
            this.lblAciklama2,
            this.lblTopSatisFiyat,
            this.lblAciklama3,
            this.lblBazKDV,
            this.lblAciklama4,
            this.lblTopKDV,
            this.lblAciklama5,
            this.lblTopKar,
            this.lblAciklama6,
            this.lblTopSatilanAdet});
            this.Detail.HeightF = 729.2915F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // crtSatilanFiyat
            // 
            this.crtSatilanFiyat.BorderColor = System.Drawing.Color.Black;
            this.crtSatilanFiyat.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.crtSatilanFiyat.Legend.Name = "Default Legend";
            this.crtSatilanFiyat.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 367.2917F);
            this.crtSatilanFiyat.Name = "crtSatilanFiyat";
            this.crtSatilanFiyat.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.crtSatilanFiyat.SizeF = new System.Drawing.SizeF(613.2501F, 344.7918F);
            // 
            // crtSatisFiyat
            // 
            this.crtSatisFiyat.BorderColor = System.Drawing.Color.Black;
            this.crtSatisFiyat.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.crtSatisFiyat.Legend.Name = "Default Legend";
            this.crtSatisFiyat.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 9.999998F);
            this.crtSatisFiyat.Name = "crtSatisFiyat";
            this.crtSatisFiyat.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.crtSatisFiyat.SizeF = new System.Drawing.SizeF(613.2501F, 344.7917F);
            // 
            // lblAciklama1
            // 
            this.lblAciklama1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAciklama1.LocationFloat = new DevExpress.Utils.PointFloat(635.4169F, 106.125F);
            this.lblAciklama1.Name = "lblAciklama1";
            this.lblAciklama1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblAciklama1.SizeF = new System.Drawing.SizeF(158.3333F, 26.12499F);
            this.lblAciklama1.StylePriority.UseFont = false;
            this.lblAciklama1.Text = "Toplam Satılan Fiyat :";
            // 
            // lblTopSatilanFiyat
            // 
            this.lblTopSatilanFiyat.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.lblTopSatilanFiyat.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblTopSatilanFiyat.LocationFloat = new DevExpress.Utils.PointFloat(635.4172F, 143.7083F);
            this.lblTopSatilanFiyat.Name = "lblTopSatilanFiyat";
            this.lblTopSatilanFiyat.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblTopSatilanFiyat.SizeF = new System.Drawing.SizeF(158.3333F, 32.375F);
            this.lblTopSatilanFiyat.StylePriority.UseFont = false;
            this.lblTopSatilanFiyat.StylePriority.UseForeColor = false;
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "localhost_butak_Connection 2";
            this.sqlDataSource1.Name = "sqlDataSource1";
            columnExpression1.ColumnName = "parcaAd";
            table1.Name = "Satis";
            columnExpression1.Table = table1;
            column1.Expression = columnExpression1;
            columnExpression2.ColumnName = "satilanFiyat";
            columnExpression2.Table = table1;
            column2.Expression = columnExpression2;
            selectQuery1.Columns.Add(column1);
            selectQuery1.Columns.Add(column2);
            selectQuery1.Name = "Satis";
            selectQuery1.Tables.Add(table1);
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = "PERhdGFTZXQgTmFtZT0ic3FsRGF0YVNvdXJjZTEiPjxWaWV3IE5hbWU9IlNhdGlzIj48RmllbGQgTmFtZ" +
    "T0icGFyY2FBZCIgVHlwZT0iU3RyaW5nIiAvPjxGaWVsZCBOYW1lPSJzYXRpbGFuRml5YXQiIFR5cGU9I" +
    "kRlY2ltYWwiIC8+PC9WaWV3PjwvRGF0YVNldD4=";
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 0F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 0.1248678F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // sqlDataSource2
            // 
            this.sqlDataSource2.ConnectionName = "localhost_butak_Connection";
            this.sqlDataSource2.Name = "sqlDataSource2";
            columnExpression3.ColumnName = "parcaAd";
            table2.Name = "Satis";
            columnExpression3.Table = table2;
            column3.Expression = columnExpression3;
            columnExpression4.ColumnName = "satisFiyat";
            columnExpression4.Table = table2;
            column4.Expression = columnExpression4;
            selectQuery2.Columns.Add(column3);
            selectQuery2.Columns.Add(column4);
            selectQuery2.Name = "Satis";
            selectQuery2.Tables.Add(table2);
            this.sqlDataSource2.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery2});
            this.sqlDataSource2.ResultSchemaSerializable = "PERhdGFTZXQgTmFtZT0ic3FsRGF0YVNvdXJjZTIiPjxWaWV3IE5hbWU9IlNhdGlzIj48RmllbGQgTmFtZ" +
    "T0icGFyY2FBZCIgVHlwZT0iU3RyaW5nIiAvPjxGaWVsZCBOYW1lPSJzYXRpc0ZpeWF0IiBUeXBlPSJEZ" +
    "WNpbWFsIiAvPjwvVmlldz48L0RhdGFTZXQ+";
            // 
            // lblAciklama2
            // 
            this.lblAciklama2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblAciklama2.LocationFloat = new DevExpress.Utils.PointFloat(635.4167F, 9.999998F);
            this.lblAciklama2.Name = "lblAciklama2";
            this.lblAciklama2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblAciklama2.SizeF = new System.Drawing.SizeF(158.3333F, 25.08332F);
            this.lblAciklama2.StylePriority.UseFont = false;
            this.lblAciklama2.Text = "Toplam Satış Fiyat :";
            // 
            // lblTopSatisFiyat
            // 
            this.lblTopSatisFiyat.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.lblTopSatisFiyat.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblTopSatisFiyat.LocationFloat = new DevExpress.Utils.PointFloat(635.4167F, 45.41667F);
            this.lblTopSatisFiyat.Name = "lblTopSatisFiyat";
            this.lblTopSatisFiyat.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblTopSatisFiyat.SizeF = new System.Drawing.SizeF(158.3333F, 33.41669F);
            this.lblTopSatisFiyat.StylePriority.UseFont = false;
            this.lblTopSatisFiyat.StylePriority.UseForeColor = false;
            // 
            // lblAciklama3
            // 
            this.lblAciklama3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblAciklama3.LocationFloat = new DevExpress.Utils.PointFloat(635.4169F, 201.6667F);
            this.lblAciklama3.Name = "lblAciklama3";
            this.lblAciklama3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblAciklama3.SizeF = new System.Drawing.SizeF(158.3333F, 52.16666F);
            this.lblAciklama3.StylePriority.UseFont = false;
            this.lblAciklama3.Text = "Baz Alınan KDV Oranı :";
            // 
            // lblBazKDV
            // 
            this.lblBazKDV.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.lblBazKDV.ForeColor = System.Drawing.Color.Crimson;
            this.lblBazKDV.LocationFloat = new DevExpress.Utils.PointFloat(635.4167F, 266.25F);
            this.lblBazKDV.Name = "lblBazKDV";
            this.lblBazKDV.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblBazKDV.SizeF = new System.Drawing.SizeF(158.3331F, 32.375F);
            this.lblBazKDV.StylePriority.UseFont = false;
            this.lblBazKDV.StylePriority.UseForeColor = false;
            this.lblBazKDV.Text = "% 18";
            // 
            // lblAciklama4
            // 
            this.lblAciklama4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblAciklama4.LocationFloat = new DevExpress.Utils.PointFloat(635.4205F, 328.6717F);
            this.lblAciklama4.Name = "lblAciklama4";
            this.lblAciklama4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblAciklama4.SizeF = new System.Drawing.SizeF(158.33F, 26.12F);
            this.lblAciklama4.StylePriority.UseFont = false;
            this.lblAciklama4.Text = "Toplam KDV :";
            // 
            // lblTopKDV
            // 
            this.lblTopKDV.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.lblTopKDV.ForeColor = System.Drawing.Color.Crimson;
            this.lblTopKDV.LocationFloat = new DevExpress.Utils.PointFloat(635.4166F, 367.2917F);
            this.lblTopKDV.Name = "lblTopKDV";
            this.lblTopKDV.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblTopKDV.SizeF = new System.Drawing.SizeF(158.3333F, 32.375F);
            this.lblTopKDV.StylePriority.UseFont = false;
            this.lblTopKDV.StylePriority.UseForeColor = false;
            // 
            // lblAciklama5
            // 
            this.lblAciklama5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblAciklama5.LocationFloat = new DevExpress.Utils.PointFloat(635.4205F, 430.755F);
            this.lblAciklama5.Name = "lblAciklama5";
            this.lblAciklama5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblAciklama5.SizeF = new System.Drawing.SizeF(158.3293F, 26.12003F);
            this.lblAciklama5.StylePriority.UseFont = false;
            this.lblAciklama5.Text = "Toplam Kar :";
            // 
            // lblTopKar
            // 
            this.lblTopKar.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.lblTopKar.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblTopKar.LocationFloat = new DevExpress.Utils.PointFloat(635.4166F, 467.2917F);
            this.lblTopKar.Name = "lblTopKar";
            this.lblTopKar.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblTopKar.SizeF = new System.Drawing.SizeF(158.3333F, 32.375F);
            this.lblTopKar.StylePriority.UseFont = false;
            this.lblTopKar.StylePriority.UseForeColor = false;
            // 
            // lblAciklama6
            // 
            this.lblAciklama6.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblAciklama6.LocationFloat = new DevExpress.Utils.PointFloat(635.4205F, 529.1249F);
            this.lblAciklama6.Name = "lblAciklama6";
            this.lblAciklama6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblAciklama6.SizeF = new System.Drawing.SizeF(160.33F, 24.04F);
            this.lblAciklama6.StylePriority.UseFont = false;
            this.lblAciklama6.Text = "Toplam Satılan Adet :";
            // 
            // lblTopSatilanAdet
            // 
            this.lblTopSatilanAdet.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.lblTopSatilanAdet.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblTopSatilanAdet.LocationFloat = new DevExpress.Utils.PointFloat(635.4205F, 567.6667F);
            this.lblTopSatilanAdet.Name = "lblTopSatilanAdet";
            this.lblTopSatilanAdet.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.lblTopSatilanAdet.SizeF = new System.Drawing.SizeF(158.33F, 32.38F);
            this.lblTopSatilanAdet.StylePriority.UseFont = false;
            this.lblTopSatilanAdet.StylePriority.UseForeColor = false;
            // 
            // rprGunCiro
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlDataSource1,
            this.sqlDataSource2});
            this.Margins = new System.Drawing.Printing.Margins(0, 0, 0, 0);
            this.PageHeight = 1169;
            this.PageWidth = 827;
            this.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.Version = "17.1";
            ((System.ComponentModel.ISupportInitialize)(this.crtSatilanFiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crtSatisFiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        public DevExpress.XtraReports.UI.XRChart crtSatisFiyat;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource2;
        public DevExpress.XtraReports.UI.XRChart crtSatilanFiyat;
        private DevExpress.XtraReports.UI.XRLabel lblAciklama1;
        public DevExpress.XtraReports.UI.XRLabel lblTopSatilanFiyat;
        private DevExpress.XtraReports.UI.XRLabel lblAciklama2;
        public DevExpress.XtraReports.UI.XRLabel lblTopSatisFiyat;
        private DevExpress.XtraReports.UI.XRLabel lblAciklama3;
        private DevExpress.XtraReports.UI.XRLabel lblBazKDV;
        private DevExpress.XtraReports.UI.XRLabel lblAciklama4;
        public DevExpress.XtraReports.UI.XRLabel lblTopKDV;
        private DevExpress.XtraReports.UI.XRLabel lblAciklama5;
        public DevExpress.XtraReports.UI.XRLabel lblTopKar;
        private DevExpress.XtraReports.UI.XRLabel lblAciklama6;
        public DevExpress.XtraReports.UI.XRLabel lblTopSatilanAdet;
    }
}
