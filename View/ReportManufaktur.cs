using ApotekPub.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Shapes;

namespace ApotekPub.View
{
    public partial class ReportManufaktur : Form
    {
        MedicineController medicine = new MedicineController();
        public ReportManufaktur()
        {
            InitializeComponent();
        }

        private void ReportMedicine_Load(object sender, EventArgs e)
        {
            showReportMedicine();
        }

        public void showReportMedicine()
        {
            dataGridReportMedicine.DataSource = medicine.selectDrug();
            dataGridReportMedicine.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void printDocumentMedicine_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap btm = new Bitmap(this.dataGridReportMedicine.Width, this.dataGridReportMedicine.Height);
            dataGridReportMedicine.DrawToBitmap(btm, new System.Drawing.Rectangle(0, 0, this.dataGridReportMedicine.Width, this.dataGridReportMedicine.Height));
            e.Graphics.DrawImage(btm, 170, 120);
            e.Graphics.DrawString(labelTittleReportMedicine.Text, new Font("concolas", 13, FontStyle.Bold), Brushes.Black, new Point(310, 50));
            

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printPreviewDialogMedicine.Document = printDocumentMedicine;
            printPreviewDialogMedicine.ShowDialog();
        }

        private void btnBackToReport_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
