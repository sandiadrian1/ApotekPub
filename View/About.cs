using ApotekPub.Controller;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApotekPub.View
{
    public partial class About : Form
    {
        private AboutController about = new AboutController();
        public About()
        {
            InitializeComponent();
         

        }
        private void About_Load(object sender, EventArgs e)
        {
            showTableAbout();
        }
         
         private void showTableAbout()
        {
            dataGridViewAbout.DataSource = about.selectPerson();
            dataGridViewAbout.RowTemplate.Height = 80;
        }


        private void btnUploadPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "select Photo(*.jpg, *;png ; * .gif) | *.jpg; *.png ; *.gif;";

            if(of.ShowDialog() == DialogResult.OK)
            {
                pictureBoxPhotoAdm.Image = Image.FromFile(of.FileName);
            }
        }

        private void dataGridViewAbout_Click(object sender, EventArgs e)
        {
            textBoxIdAboutAdm.Text = dataGridViewAbout.CurrentRow.Cells[0].Value.ToString();
            textBoxNameAboutAdm.Text = dataGridViewAbout.CurrentRow.Cells[1].Value.ToString();
            textBoxAgeAdm.Text = dataGridViewAbout.CurrentRow.Cells[2].Value.ToString();
            comboBoxPosition.Text = dataGridViewAbout.CurrentRow.Cells[3].Value.ToString();
            byte[] img = (byte[])dataGridViewAbout.CurrentRow.Cells[4].Value;
            MemoryStream image = new MemoryStream(img);
            pictureBoxPhotoAdm.Image = Image.FromStream(image);
        }


        private void gunaBtnAddAbout_Click(object sender, EventArgs e)
        {

            try
            {
                MemoryStream memory = new MemoryStream();
                pictureBoxPhotoAdm.Image.Save(memory, pictureBoxPhotoAdm.Image.RawFormat);
                byte[] img = memory.ToArray();
                about.addPerson(textBoxIdAboutAdm.Text, textBoxNameAboutAdm.Text, textBoxAgeAdm.Text, comboBoxPosition.Text, img);
                MessageBox.Show("success add data", "add data",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                showTableAbout();
                textBoxIdAboutAdm.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gunaBtnUpdateAbout_Click(object sender, EventArgs e)
        {
            try
            {


                MemoryStream memory = new MemoryStream();
                pictureBoxPhotoAdm.Image.Save(memory, pictureBoxPhotoAdm.Image.RawFormat);
                byte[] img = memory.ToArray();
                about.updatePerson(textBoxIdAboutAdm.Text, textBoxNameAboutAdm.Text, textBoxAgeAdm.Text, comboBoxPosition.Text, img);
                textBoxIdAboutAdm.Focus();
                showTableAbout();
                MessageBox.Show("success update data");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Error", MessageBoxButtons.OK , MessageBoxIcon.Error);
            }
        }

        private void gunaBtnClearAbout_Click(object sender, EventArgs e)
        {
            textBoxIdAboutAdm.Clear();
            textBoxNameAboutAdm.Clear();
            textBoxAgeAdm.Clear();
            pictureBoxPhotoAdm.Image = null;
        }
        private void gunaBtnDelAbout_Click(object sender, EventArgs e)
        {
            try
            {
                about.deletePerson(textBoxIdAboutAdm.Text);
                showTableAbout();
                gunaBtnClearAbout.PerformClick();
                MessageBox.Show("Delete Person Successfully", "Delete Person",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxIdAboutAdm.Focus();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }         
        }

        private void btnSaveAbout_Click(object sender, EventArgs e)
        {
        
        }

        
    }
}
