using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
            var rep1=new XtraReport1();
            rep1.SetDataSource();
            var report=new PrintePreview();
            report.ListReport.Add(rep1);
            report.ShowDialog();
        }
    }
}
