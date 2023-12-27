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
    public partial class LoginAdmin : Form
    {
        AdminController admin;
        public LoginAdmin()
        {
            InitializeComponent();
        }

        private void LoginAdmin_Load(object sender, EventArgs e)
        {
            admin = new AdminController();
            pictureBoxShow.Visible = false;
            pictureBoxHide.Visible = true;
            textBoxPw.MaxLength = 6;
        }
        

        private void btnMin_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private void btnMax_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }

            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


     

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if ((textBoxId.Text == "") && (textBoxPw.Text == ""))
            {
                MessageBox.Show("need data to login");
                textBoxId.Focus();
            }
            if (textBoxPw.Text == "")
            {
                MessageBox.Show("Please Input Password !!!");
                textBoxPw.Focus();
            }

            if(textBoxId.Text == "")
            {
                MessageBox.Show("Please Input username !!!");
                textBoxId.Focus();
            }
            else

            {
                string name = textBoxId.Text;
                string pass = textBoxPw.Text;

                DataTable table = admin.getList(new MySqlCommand("SELECT * FROM admin WHERE username ='" + name + "' AND password = '" + pass + "' "));

                if(table.Rows.Count > 0) 
                {
                    MessageBox.Show("Success Login");
                    MenuAdmin menu = new MenuAdmin();
                    menu.Show();
                    this.Hide();
                }

                else
                {
                    MessageBox.Show("account is not registered");
                }
            }
        }

  

        private void pictureBoxHide_Click(object sender, EventArgs e)
        {
            if(pictureBoxShow.Visible == false)
            {
                pictureBoxShow.Visible = true;
                textBoxPw.UseSystemPasswordChar = false;
                
            }
        }

        private void btnBackLogHome_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void pictureBoxShow_Click_1(object sender, EventArgs e)
        {
            if (pictureBoxShow.Visible == true)
            {
                pictureBoxShow.Visible = false;
                textBoxPw.UseSystemPasswordChar = true;
            }
        }
    }
}
