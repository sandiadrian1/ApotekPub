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
    public partial class MenuAdmin : Form
    {
        private Form activeForm;
        public MenuAdmin()
        {
            InitializeComponent();
            
        }

  
        public void OpenChildForm(Form childForm, object btnSender)
        {

            if (activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDekstopMenuAdmin.Controls.Add(childForm);
            this.panelDekstopMenuAdmin.Tag = childForm;
            childForm.BringToFront(); 
            childForm.Show();
            labelHomeAdmin.Text = childForm.Text;        
        }

        private void btnDrug_Click(object sender, EventArgs e)
        {
            OpenChildForm(new View.ManufakturAdmin() , sender);
            btnCloseChildForm.Visible = true;
            if (btnDrug != null)
            {
               btnDrug.BackColor = Color.DarkGreen;
               btnReport.BackColor = Color.FromArgb(51, 51, 76);
            
               btnAbout.BackColor = Color.FromArgb(51, 51, 76);
               btnLogout.BackColor = Color.FromArgb(51, 51, 76);
            }
        }

        private void btnTransaction_Click(object sender, EventArgs e)
        {

        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            OpenChildForm(new View.Report(), sender);
            btnCloseChildForm.Visible = true;
            if (btnReport != null)
            {
                btnDrug.BackColor = Color.FromArgb(51, 51, 76);
                btnReport.BackColor = Color.DarkGreen;
               
                btnAbout.BackColor = Color.FromArgb(51, 51, 76);
                btnLogout.BackColor = Color.FromArgb(51, 51, 76);
            }

        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            OpenChildForm(new View.About() , sender);
            btnCloseChildForm.Visible = true;
            if (btnAbout != null)
            {
                btnDrug.BackColor = Color.FromArgb(51, 51, 76);
                btnReport.BackColor = Color.FromArgb(51, 51, 76);
               
                btnAbout.BackColor = Color.DarkGreen;
                btnLogout.BackColor = Color.FromArgb(51, 51, 76);
            }
        }
        

        private void btnCloseChildForm_Click_1(object sender, EventArgs e)
        {
             if(activeForm != null)
            {
                activeForm.Close();
                Reset();
            }
        }
        private void Reset()
        {
            labelHomeAdmin.Text = "HOME";
            panelTitleHome.BackColor = Color.DarkGreen;
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            btnCloseChildForm.Visible = false;
            btnDrug.BackColor = Color.FromArgb(51, 51, 76);
            btnReport.BackColor = Color.FromArgb(51, 51, 76);
     
            btnAbout.BackColor = Color.FromArgb(51, 51, 76);
            btnLogout.BackColor = Color.FromArgb(51, 51, 76);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            MessageBox.Show("Logout success");
            home.Show();
            this.Hide();
        }
    }
}
