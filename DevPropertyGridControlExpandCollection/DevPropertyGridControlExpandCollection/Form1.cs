using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraVerticalGrid;
using DevExpress.XtraVerticalGrid.Events;
using DevExpress.XtraVerticalGrid.Rows;

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
            var student = GetTestStudent();
            propertyGridControl1.SelectedObject = student;
            propertyGridControl1.OptionsBehavior.PropertySort = DevExpress.XtraVerticalGrid.PropertySort.NoSort;
            propertyGridControl1.ExpandAllRows();

            //set row Tag info
            student.ListCourses.ForEach(x =>
                        {
                            //IndexName set by CourseCollectionPropertyDescriptor constructor
                            var fieldName = nameof(Student.ListCourses) + "." + x.IndexName + "." +
                            nameof(Course.DicClassRoomId_Name);
                            var row = propertyGridControl1.GetRowByFieldName(fieldName);
                            row.Tag = x;
                        });

            propertyGridControl1.RowsIterator.DoOperation(new SetDicRowVisibleRowOperation());
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
    public class SetDicRowVisibleRowOperation : DevExpress.XtraVerticalGrid.Rows.RowOperation
    {
        public override void Execute(DevExpress.XtraVerticalGrid.Rows.BaseRow row)
        {
            Console.WriteLine(row.Properties.Caption);   
            if (row.Tag is Course course)
            {
                var fieldName = nameof(Student.ListCourses) + "." + course.IndexName + "." +
                                   nameof(Course.DicClassRoomId_Name);
                if (row.Properties.FieldName == fieldName)
                    row.Visible = course.Id == 2;
            }
        }
    }
}
