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
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;

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
        /// <summary>
        /// 打印选项设置
        /// </summary>
        private PrintingSystem printingSystem { get; set; }                  

        public PrintePreview()
        {
            InitializeComponent();
            ListReport=new List<ReportBase>();
            printingSystem = new PrintingSystem();
            documentViewerBarManager1.PrintControl.PrintingSystem = printingSystem;
        }

        private void PrintePreview_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            //加载打印内容
            if (ListReport != null)
            {
                documentViewerBarManager1.PrintControl.PrintingSystem.Pages.Clear();
                documentViewerBarManager1.PrintControl.PrintingSystem.Document.Pages.Clear();

                foreach (var xr in ListReport)
                {
                    xr.CreateDocument();

                    foreach (var pg in xr.Pages)
                    {
                        documentViewerBarManager1.PrintControl.PrintingSystem.Pages.Add((Page)pg);
                    }
                }
            }
            //documentViewer1.PrintingSystem = ListReport.First().PrintingSystem;
            //ListReport.First().CreateDocument();
        }

        private void printPreviewBarItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //preview
        }

        private void documentViewer1_BrickDoubleClick(object sender, DevExpress.XtraPrinting.Control.BrickEventArgs e)
        {
            var studentId = string.Empty;
            var iterator = new DevExpress.XtraPrinting.Native.NestedBrickIterator(e.Page.InnerBricks);
            while (iterator.MoveNext())
            {
                VisualBrick visualBrick = null;
                try
                {
                    visualBrick = iterator.CurrentBrick as VisualBrick;
                }
                catch (ArgumentOutOfRangeException)
                {
                    //对弹出的窗口点击确认后会报此异常,因为超出了report的范围
                    //对这种异常不做处理
                }
                if (visualBrick != null)
                    //PutStateToBrick(visualBrick, PrintingSystem);
                    //读取打印模板界面保存的report主键数据
                {
                    if (visualBrick.ID == "StudentId")
                    {
                        studentId = visualBrick.AnchorName;
                    }
                }

                //Do some actions based on your requirements
            }

            if(string.IsNullOrEmpty(studentId))return;
            else
            {
                //MessageBox.Show($"点击的学生主键为{studentId}");
                var newForm = new EditProperties(ListReport.First().PModel.ListStudents
                    .SingleOrDefault(c => c.StudentId == Convert.ToInt32(studentId)));
                var dlg= newForm.ShowDialog();
                if (dlg == DialogResult.OK)
                {
                    var newReport=ListReport.First();
                    newReport.SetDataSource(); 
                    LoadData();
                }
            }
        }
    }
}