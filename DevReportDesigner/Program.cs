using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace DevReportDesigner
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            System.Console.WriteLine("Number of command line parameters = {0}", args.Length);
            //File.AppendAllLines("log.txt", args);

            foreach (string s in args)
            {
                System.Console.WriteLine(s);
                //MessageBox.Show($"参数为：{s}");
            }

            var filePath = string.Empty;
            if (args.Any())
                filePath = args[0];
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(filePath));
        }
    }
}
