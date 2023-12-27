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
    public partial class MenuUser : Form
    {
        private Form activeForm;
        public MenuUser()
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
            this.panelMenuHome.Controls.Add(childForm);
            this.panelMenuHome.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            labelTitleMenu.Text = childForm.Text;

        }


        private void btnViewDrug_Click(object sender, EventArgs e)
        {
            OpenChildForm(new View.ViewManufaktur(), sender);
            btnCloseChildFormUser.Visible = true;
            if (btnViewDrug != null)
            {
                btnViewDrug.BackColor = Color.DarkGreen;
                btnProfil.BackColor = Color.FromArgb(51, 51, 76);
            }
        }

       

        


        private void btnProfil_Click(object sender, EventArgs e)
        {
            OpenChildForm(new View.Profil(), sender);
            btnCloseChildFormUser.Visible = true;
            if ( btnProfil!= null)
            {
                btnViewDrug.BackColor = Color.FromArgb(51, 51, 76);
                btnProfil.BackColor = Color.DarkGreen;
            }
        }

        private void btnCloseChildFormUser_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
                Reset();
            }
        }


        private void Reset()
        {
            labelTitleMenu.Text = "HOME";
            panelTitleHomeUser.BackColor = Color.DarkGreen;
            panelLogoUser.BackColor = Color.FromArgb(39, 39, 58);
            btnCloseChildFormUser.Visible = false;
            btnViewDrug.BackColor = Color.FromArgb(51, 51, 76);
            btnProfil.BackColor = Color.FromArgb(51, 51, 76);
        
        }

        private void btnBackUser_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
    }
}
