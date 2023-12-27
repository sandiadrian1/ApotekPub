using ApotekPub.Controller;
using MySqlConnector;
using RestSharp.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using ApotekPub.Validation;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApotekPub.View
{
    public partial class ManufakturAdmin : Form
    {
       
        private MedicineController medicine = new MedicineController();
        private ValidationPharmacy validation = new ValidationPharmacy();
        public ManufakturAdmin()
        {
            InitializeComponent();
           
        }

     
        private void DrugAdmin_Load(object sender, EventArgs e)
        {
            textBoxIdAdmin.MaxLength = 30;
            textBoxDrugNameAdm.MaxLength = 40;
            comboBoxDrugTypeAdm.SelectedIndex = 0;
            textBoxDrugStockAdm.MaxLength = 3;
            textBoxDrugPricesAdm.MaxLength = 6;
            showDrugs();  
                       
        }

        public void showDrugs()
        {
            dataGridViewDrug.DataSource = medicine.selectDrug();
            dataGridViewDrug.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void gunaBtnAdd_Click(object sender, EventArgs e)
        {
                int check = 0;
              
            if (textBoxDrugNameAdm.Text == "" || textBoxDrugPricesAdm.Text == "" || comboBoxDrugTypeAdm.Text == "" ||   textBoxDrugStockAdm.Text == "" )
            {
                MessageBox.Show("incomplete data!!!");
                check = 1;
            }
            if (textBoxDrugNameAdm.Text == "")
            {
                MessageBox.Show("Nama Must Be fill ");
                textBoxDrugNameAdm.Focus();
                check = 1;
            }
            if (textBoxDrugNameAdm.Text != "")
            {
                if (textBoxDrugNameAdm.Text.Length < 3)
                {
                    MessageBox.Show("Name min 3 digits");
                    textBoxDrugNameAdm.Text = "";
                    textBoxDrugNameAdm.Focus();
                    check = 1;
                }
                if (validation.valString(textBoxDrugNameAdm.Text) == 1)
                {
                    MessageBox.Show("Nama not correct!");
                    textBoxDrugNameAdm.Text = "";
                    textBoxDrugNameAdm.Focus();
                    check = 1;
                }

                if(textBoxDrugStockAdm.Text == "0")
                {
                    MessageBox.Show("input not correct");
                    textBoxDrugStockAdm.Text = "";
                    textBoxDrugStockAdm.Focus();
                    check = 1;
                }

                if(validation.valPrice(textBoxDrugPricesAdm.Text)==1)
                {
                    MessageBox.Show("Input not correct");
                    textBoxDrugPricesAdm.Text = "";
                    textBoxDrugPricesAdm.Focus();
                }

               if (check != 1)
                    {
                    try
                    {
                        medicine.addDrug(textBoxIdAdmin.Text, textBoxDrugNameAdm.Text, comboBoxDrugTypeAdm.Text, textBoxDrugStockAdm.Text, textBoxDrugPricesAdm.Text, dateTimePickerExpAdm.Value);
                        MessageBox.Show("success add data", "add data",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        showDrugs();
                        textBoxIdAdmin.Focus();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }
        private void gunaBtnUpdate_Click(object sender, EventArgs e)
        {
           

            int check = 0;

            if (textBoxDrugNameAdm.Text == "" || textBoxDrugPricesAdm.Text == "" || comboBoxDrugTypeAdm.Text == "" || textBoxDrugStockAdm.Text == "")
            {
                MessageBox.Show("incomplete data!!!");
                check = 1;
            }
            if (textBoxDrugNameAdm.Text == "")
            {
                MessageBox.Show("Nama Must Be fill ");
                textBoxDrugNameAdm.Focus();
                check = 1;
            }
            if (textBoxDrugNameAdm.Text != "")
            {
                if (textBoxDrugNameAdm.Text.Length < 3)
                {
                    MessageBox.Show("Name min 3 digits");
                    textBoxDrugNameAdm.Text = "";
                    textBoxDrugNameAdm.Focus();
                    check = 1;
                }
                if (validation.valString(textBoxDrugNameAdm.Text) == 1)
                {
                    MessageBox.Show("Nama not correct!");
                    textBoxDrugNameAdm.Text = "";
                    textBoxDrugNameAdm.Focus();
                    check = 1;
                }

                if (textBoxDrugStockAdm.Text == "0")
                {
                    MessageBox.Show("input not correct");
                    textBoxDrugStockAdm.Text = "";
                    textBoxDrugStockAdm.Focus();
                    check = 1;
                }

                if (validation.valPrice(textBoxDrugPricesAdm.Text) == 1 )
                {
                    MessageBox.Show("Input not correct");
                    textBoxDrugPricesAdm.Text = "";
                    textBoxDrugPricesAdm.Focus();
                }


                if (validation.valStock(textBoxDrugStockAdm.Text) == 1)
                {
                    MessageBox.Show("Input not correct");
                    textBoxDrugPricesAdm.Text = "";
                    textBoxDrugPricesAdm.Focus();
                }

                if (validation.valStock(textBoxDrugStockAdm.Text) == 1)
                {
                    MessageBox.Show("Input not correct");
                    textBoxDrugPricesAdm.Text = "";
                    textBoxDrugPricesAdm.Focus();
                }


                if (check != 1)
                {
                    try
                    {
                        medicine.updateDrug(textBoxIdAdmin.Text, textBoxDrugNameAdm.Text, comboBoxDrugTypeAdm.Text, textBoxDrugStockAdm.Text, textBoxDrugPricesAdm.Text, dateTimePickerExpAdm.Value);
                        textBoxIdAdmin.Focus();
                        showDrugs();
                        MessageBox.Show("success update data");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }



        }


        private void gunaBtnClear_Click(object sender, EventArgs e)
        {
            textBoxIdAdmin.Clear();
            textBoxDrugNameAdm.Clear();
            textBoxDrugStockAdm.Clear();
            textBoxDrugPricesAdm.Clear();
            dateTimePickerExpAdm.Value = DateTime.Now;
        }

        private void gunaBtnDel_Click(object sender, EventArgs e)
        {
            try
            {
                medicine.deleteDrug(textBoxIdAdmin.Text);
                showDrugs();
                gunaBtnClear.PerformClick();
                MessageBox.Show("Delete Drug Successfully", "Delete Drug",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxIdAdmin.Focus();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }


        
        private void dataGridViewDrug_Click_1(object sender, EventArgs e)
        {
            textBoxIdAdmin.Text = dataGridViewDrug.CurrentRow.Cells[0].Value.ToString();
            textBoxDrugNameAdm.Text = dataGridViewDrug.CurrentRow.Cells[1].Value.ToString();
            comboBoxDrugTypeAdm.Text = dataGridViewDrug.CurrentRow.Cells[2].Value.ToString();
            textBoxDrugStockAdm.Text = dataGridViewDrug.CurrentRow.Cells[3].Value.ToString();
            textBoxDrugPricesAdm.Text = dataGridViewDrug.CurrentRow.Cells[4].Value.ToString();
            dateTimePickerExpAdm.Value = (DateTime)dataGridViewDrug.CurrentRow.Cells[5].Value;
        }

    }
} 
