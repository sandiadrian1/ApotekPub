using ApotekPub.Controller;
using MySqlConnector;
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
    public partial class ViewManufaktur : Form
    {
        private MedicineController medicine = new MedicineController();
        public ViewManufaktur()
        {
            InitializeComponent();
        }

        private void ViewDrug_Load(object sender, EventArgs e)
        {
            showDrugs();
        }

        public void showDrugs()
        {
            dataGridViewDrug.DataSource = medicine.selectDrug();
            dataGridViewDrug.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnSearchDrug_Click(object sender, EventArgs e)
        {
            dataGridViewDrug.DataSource = medicine.searchDrug(textBoxSearch.Text);
            dataGridViewDrug.RowTemplate.Height = 80;
        }

        private void radioButtonTablet_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewDrug.DataSource = medicine.searchTablet(radioButtonTablet.Text); 
        }

        private void radioButtonSyrup_CheckedChanged(object sender, EventArgs e)
        {

            dataGridViewDrug.DataSource = medicine.searchSyrup(radioButtonSyrup.Text);
            
        }

        private void radioButtonPowder_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewDrug.DataSource = medicine.searchPowder(radioButtonPowder.Text);
        }

        private void radioButtonBottle_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewDrug.DataSource = medicine.searchBottle(radioButtonBottle.Text);
        }
    }
}
