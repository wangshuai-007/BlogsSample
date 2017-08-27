using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Reports
{
    /// <summary>
    /// 打印预览
    /// </summary>
    public partial class PrintePreview : DevExpress.XtraEditors.XtraForm
    {
        /// <summary>
        /// 所有打印的页面
        /// </summary>
        public List<ReportBase> ListReport { get; set; }
        public PrintePreview()
        {
            InitializeComponent();
            ListReport=new List<ReportBase>();
        }

        private void PrintePreview_Load(object sender, EventArgs e)
        {
            documentViewer1.PrintingSystem = ListReport.First().PrintingSystem;
            ListReport.First().CreateDocument();
        }

        private void printPreviewBarItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //preview
        }
    }
}