using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Data;
using DevExpress.XtraReports.UI;

namespace Reports
{
    public partial class XtraReport1 :ReportBase
    {
        public XtraReport1()
        {
           this.InitializeComponent();
        }

        public override void SetDataSource()
        {
            base.SetDataSource();

            var dtTabel=new DataTable("Detail");
            dtTabel.Columns.Add(tcStudentName.Name, typeof(string));
            dtTabel.Columns.Add(tcStudentSex.Name, typeof(string));
            dtTabel.Columns.Add(tcStudentAge.Name, typeof(string));
            dtTabel.Columns.Add(tcStudentNation.Name, typeof(string));
            dtTabel.Columns.Add(tcStudentNative.Name, typeof(string));
            dtTabel.Columns.Add(tcStudentSpecialist.Name, typeof(string));

            foreach (var student in PModel.ListStudents)
            {
                
            }

        }
    }
}
