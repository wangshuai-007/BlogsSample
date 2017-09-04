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
using Reports.Models;

namespace Reports
{
    /// <summary>
    /// 修改model属性界面
    /// </summary>
    public partial class EditProperties : DevExpress.XtraEditors.XtraForm
    {
        /// <summary>
        /// 要修改的数据对象
        /// </summary>
        public object PModel { get; set; }
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="pModel"></param>
        public EditProperties(object pModel)
        {
            InitializeComponent();
            PModel = pModel;
        }
        /// <summary>
        /// 界面加载时的事件处理方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditProperties_Load(object sender, EventArgs e)
        {
            propertyGridControl.SelectedObject = PModel;
        }

        private void propertyGridControl_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode & Keys.Enter) == Keys.Enter)
            {
                DialogResult = DialogResult.OK;
                Close();
            }

        }
    }
}