using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reports.Models
{
    /// <summary>
    /// 打印数据源实体类
    /// </summary>
    public class PrinteModel
    {
        /// <summary>
        /// 学生信息列表
        /// </summary>
       public List<Student> ListStudents { get; set; }
        /// <summary>
        /// 构造函数
        /// </summary>
        public PrinteModel()
        {
            ListStudents=new List<Student>();
        }
        
    }

    /// <summary>
    /// 学生实体类
    /// </summary>
    public class Student
    {
        /// <summary>
        /// 学生编号
        /// </summary>
        [Browsable(false)]
        public int StudentId { get; set; }
        /// <summary>
        /// 姓名
        /// </summary>
        [Category("学生信息")]
        [DisplayName("姓名")]
        public string Name { get; set; }
        /// <summary>
        /// 性别
        /// </summary>
        [Category("学生信息")]
        [DisplayName("性别")]
        public Sex Sex { get; set; }
        /// <summary>
        /// 年龄
        /// </summary>
        [Category("学生信息")]
        [DisplayName("年龄")]
        public int Age { get; set; }
        /// <summary>
        /// 民族
        /// </summary>
        [Category("学生信息")]
        [DisplayName("民族")]
        public string Nation { get; set; }
        /// <summary>
        /// 籍贯
        /// </summary>
        [Category("学生信息")]
        [DisplayName("籍贯")]
        public string Native { get; set; }
        /// <summary>
        /// 特长
        /// </summary>
        [Category("学生信息")]
        [DisplayName("特长")]
        public string Specialist { get; set; }
    }
}
