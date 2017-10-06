using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Reports.Models;

namespace Reports
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnPrinte_Click(object sender, EventArgs e)
        {
            var studentList=new List<Student>();
            for (int i = 0; i < 5; i++)
            {
                studentList.Add(new Student()
                {
                    StudentId = i,
                    Age = i,
                    Name = "张三" + i,
                    Nation = "汉",
                    Native = "杭州",
                    Sex = Sex.男,
                    Specialist = $"玩{i}种游戏"

                });
            }

            var rep1=new XtraReport1();
            rep1.PModel.ListStudents = studentList;
            rep1.SetDataSource();
            var report=new PrintePreview();
            report.ListReport.Add(rep1);
            report.ShowDialog();
        }
    }
}
