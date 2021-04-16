namespace Reports
{
    partial class ReportBase
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
            this.BaseDetail = new DevExpress.XtraReports.UI.DetailBand();
            this.BaseTopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BaseBottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // BaseDetail
            // 
            this.BaseDetail.HeightF = 100F;
            this.BaseDetail.Name = "BaseDetail";
            this.BaseDetail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BaseDetail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BaseTopMargin
            // 
            this.BaseTopMargin.HeightF = 100F;
            this.BaseTopMargin.Name = "BaseTopMargin";
            this.BaseTopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BaseTopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BaseBottomMargin
            // 
            this.BaseBottomMargin.HeightF = 100F;
            this.BaseBottomMargin.Name = "BaseBottomMargin";
            this.BaseBottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BaseBottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // ReportBase
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.BaseDetail,
            this.BaseTopMargin,
            this.BaseBottomMargin});
            this.Version = "15.2";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand BaseDetail;
        private DevExpress.XtraReports.UI.TopMarginBand BaseTopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BaseBottomMargin;
    }
}
