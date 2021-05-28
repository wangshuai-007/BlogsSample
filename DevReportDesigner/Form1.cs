using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.UserDesigner;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DevReportDesigner
{
    public partial class Form1 : Form
    {
        private string repxPath = "";
        public Form1(string _repxPath="")
        {
            InitializeComponent();
            repxPath = _repxPath;
            this.Load += Form1_Load;
        }
        /// <summary>
        /// https://stackoverflow.com/questions/3769337/hiding-forms-on-startup-why-doesnt-this-hide-hide-my-form
        /// </summary>
        /// <param name="e"></param>
        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);
            this.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Hide();

            var rpt = new XtraReport();
            if (File.Exists(repxPath))
                rpt.LoadLayout(repxPath);
            ReportDesignTool designTool = new ReportDesignTool(rpt);

            // Access the standard or ribbon-based Designer form and its MDI Controller.
            // IDesignForm designForm = designTool.DesignForm;
            XRDesignRibbonForm designForm = designTool.DesignRibbonForm as XRDesignRibbonForm;
            if (designForm != null)
            {
                designForm.OpenReport(rpt);
                if (File.Exists(repxPath))
                {
                    var fileInfo = new FileInfo(repxPath);
                    designForm.RibbonControl.AutoSaveLayoutToXmlPath = repxPath;
                    //designForm.RibbonControl.t = repxPath;
                    designForm.Text = fileInfo.Name;
                }
                //designTool.Report.SaveComponents += (s, ee) =>
                //{

                //}

                designForm.ShowDialog();
            }

            this.Close();
        }
    }
}
