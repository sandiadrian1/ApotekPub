using ApotekPub.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApotekPub
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
             
        }

      
        private void btnadmin_Click_1(object sender, EventArgs e)
        {
            LoginAdmin login = new LoginAdmin();
            login.Show();
            this.Hide();
        }

        private void btnUser_Click_1(object sender, EventArgs e)
        {
            MenuUser user = new MenuUser();
            user.Show();
            this.Hide();
        }
    }
}
