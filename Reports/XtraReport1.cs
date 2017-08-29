using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Data;
using DevExpress.XtraReports.UI;
using Reports.Models;

namespace Reports
{
    public partial class XtraReport1 :ReportBase
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public XtraReport1()
        {
           this.InitializeComponent();
            PModel=new PrinteModel();
        }
        /// <summary>
        /// 设置打印数据
        /// </summary>
        public override void SetDataSource()
        {
            base.SetDataSource();

            //设置报表样式
            this.PaperKind = System.Drawing.Printing.PaperKind.Custom;
            this.ReportUnit = DevExpress.XtraReports.UI.ReportUnit.TenthsOfAMillimeter;
            this.PageWidth = 1000;
            this.PageHeight = 1000;

            var dtTabel=new DataTable("Detail");
            dtTabel.Columns.Add(tcStudentName.Name, typeof(string));
            dtTabel.Columns.Add(tcStudentSex.Name, typeof(string));
            dtTabel.Columns.Add(tcStudentAge.Name, typeof(string));
            dtTabel.Columns.Add(tcStudentNation.Name, typeof(string));
            dtTabel.Columns.Add(tcStudentNative.Name, typeof(string));
            dtTabel.Columns.Add(tcStudentSpecialist.Name, typeof(string));

            foreach (var student in PModel.ListStudents)
            {
                var newRow = dtTabel.NewRow();
                newRow[tcStudentName.Name] = student.Name;
                newRow[tcStudentSex.Name] = student.Sex;
                newRow[tcStudentAge.Name] = student.Age;
                newRow[tcStudentNation.Name] = student.Nation;
                newRow[tcStudentNative.Name] = student.Native;
                newRow[tcStudentSpecialist.Name] = student.Specialist;
                dtTabel.Rows.Add(newRow);
            }
            var dtSet=new DataSet("Source");
            dtSet.Tables.Add(dtTabel);
            DetailReport.DataSource = dtSet;
            //DataSource = dtSet;
            //Detail.DataBindings.Add("DataSet",dtSet,"Source");
            tcStudentName.DataBindings.Add("Text", dtSet.Tables[0], tcStudentName.Name);
            tcStudentSex.DataBindings.Add("Text", dtSet.Tables[0], tcStudentSex.Name);
            tcStudentAge.DataBindings.Add("Text", dtSet.Tables[0], tcStudentAge.Name);
            tcStudentNation.DataBindings.Add("Text", dtSet.Tables[0], tcStudentNation.Name);
            tcStudentNative.DataBindings.Add("Text", dtSet.Tables[0], tcStudentNative.Name);
            tcStudentSpecialist.DataBindings.Add("Text", dtSet.Tables[0], tcStudentSpecialist.Name);
        }
    }
}
