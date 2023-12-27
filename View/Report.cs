using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApotekPub.View
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private void btnReportMedicine_Click(object sender, EventArgs e)
        {
            ReportManufaktur report = new ReportManufaktur();
            report.Show();
        }


    }
}
