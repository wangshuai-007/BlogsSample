using System;
using System.Drawing;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Reports.Models;

namespace Reports
{
    /// <summary>
    /// 打印基类
    /// </summary>
    public partial class ReportBase : DevExpress.XtraReports.UI.XtraReport
    {          
        //InitializeComponent();
      
        /// <summary>
        /// 打印数据源
        /// </summary>
        public PrinteModel PModel { get; set; }
        /// <summary>
        /// 设置数据源，虚方法
        /// 子类必须实现
        /// </summary>
        public virtual void SetDataSource()
        {
            
        }
    }
}
