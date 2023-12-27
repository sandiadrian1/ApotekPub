﻿using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApotekPub.Model
{
    internal class Connection
    {

        public MySqlCommand cmd;
        public DataSet ds;
        public MySqlDataAdapter da;

        public MySqlConnection GetCon()
        {
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = "server=localhost;user=root;database=pharmacy;allowzerodatetime=true";
            try
            {
                conn.Open();
            }

            catch (Exception ex)
            {
                MessageBox.Show("koneksi gagal" + ex.Message);
            }
            return conn;

        }
    }
}
