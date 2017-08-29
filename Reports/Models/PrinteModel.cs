using System;
using System.Collections.Generic;
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
        /// 姓名
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 性别
        /// </summary>
        public string Sex { get; set; }
        /// <summary>
        /// 年龄
        /// </summary>
        public string Age { get; set; }
        /// <summary>
        /// 民族
        /// </summary>
        public string Nation { get; set; }
        /// <summary>
        /// 籍贯
        /// </summary>
        public string Native { get; set; }
        /// <summary>
        /// 特长
        /// </summary>
        public string Specialist { get; set; }
    }
}
