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

namespace ApotekPub.View
{
    public partial class Profil : Form
    {
        AboutController profile = new AboutController();
        public Profil()
        {
            InitializeComponent();
        }

        private void Profil_Load(object sender, EventArgs e)
        {
            showProfile();
        }


        public void showProfile()
        {
            dataGridProfil.DataSource = profile.selectPerson(); ;
            dataGridProfil.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnSearchProfil_Click(object sender, EventArgs e)
        {
            dataGridProfil.DataSource = profile.searchProfile(textBoxSearchProfil.Text);
            dataGridProfil.RowTemplate.Height = 80;
        }

        private void btnSearchAdmin_Click(object sender, EventArgs e)
        {
            dataGridProfil.DataSource = profile.searchAdmin(btnSearchAdmin.Text);
        }

        private void btnSearchDev_Click(object sender, EventArgs e)
        {
            dataGridProfil.DataSource = profile.searchDeveloper(btnSearchDev.Text);

        }

        private void btnSearchManager_Click(object sender, EventArgs e)
        {
            dataGridProfil.DataSource = profile.searchManager(btnSearchManager.Text);

        }
    }
}
