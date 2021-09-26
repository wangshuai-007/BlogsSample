using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpandCollection
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            propertyGridControl1.SelectedObject=GetTestStudent();
            propertyGridControl1.OptionsBehavior.PropertySort = DevExpress.XtraVerticalGrid.PropertySort.NoSort;
        }
        private Student GetTestStudent()
        {
            return new Student()
            {
                Id = 1,
                Name = "张三",
                ListCourses = new CourseCollection()
                {
                    GetTestCourses(1),
                    GetTestCourses(2),
                    GetTestCourses(3),
                    GetTestCourses(4)
                }
            };
        }
        private Course GetTestCourses(int id)
        {
            return new Course()
            {
                Id = id,
                Name ="course"+id,
                DicClassRoomId_Name =new Dictionary<string, string>()
                {
                    {"601","Room601" },
                    {"602","Room602" },
                    {"603","Room603" },
                    {"604","Room604" }
                }
            };
        }
    }
}
