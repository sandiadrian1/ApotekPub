using ApotekPub.Model;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApotekPub.Controller
{
    internal class TransactionController : Model.Connection
    {
        Connection connection = new Connection();
        public DataTable viewTransaction()
        {
            DataTable data = new DataTable();


            try
            {
                string show = " SELECT transactions.id_transaction,drugs.id_drugs, drugs.NAME AS drug_name,drugs.TYPE AS drug_type, transactions.amount, drugs.price AS price,transactions.total,transactions.purchase_date FROM drugs LEFT JOIN transactions ON drugs.id_drugs = transactions.id_drugs;\r\n";
                da = new MySqlConnector.MySqlDataAdapter(show, GetCon());
                da.Fill(data);

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return data;
        }

        public DataTable viewHistoryTransaction()
        {
            DataTable data = new DataTable();
            try
            {
                string show = "SELECT * FROM history_transactions";
                da = new MySqlConnector.MySqlDataAdapter(show, GetCon());
                da.Fill(data);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return data;
        }

    }
}
