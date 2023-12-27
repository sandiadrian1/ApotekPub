 using System;
using MySqlConnector;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApotekPub.Model;
using System.Data;
using System.Windows.Forms;

namespace ApotekPub.Controller
{
    internal class AdminController :Model.Connection
    {
        Connection connection = new Connection();
        public DataTable getList(MySqlCommand command)
        {
            command.Connection = connection.GetCon();
            DataTable table = new DataTable();
            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                adapter.Fill(table);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return table;
        }
    }
}
