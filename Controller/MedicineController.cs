using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using MySqlConnector;
using ApotekPub.Model;

namespace ApotekPub.Controller
{
    internal class MedicineController : Model.Connection
    {
        Connection connection = new Connection();
        public DataTable selectDrug()
        {
            DataTable data = new DataTable();


            try
            {
                string show = " SELECT * FROM drugs ";
                da = new MySqlConnector.MySqlDataAdapter(show, GetCon());
                da.Fill(data);

            }

            catch (Exception ex)
            {
                 MessageBox.Show(ex.Message);
            }
            return data;
        }
        

        
        public void addDrug(string idDrug, string nameDrug, string type, string stock , string price , DateTime exp)
        {
            string add = " insert into drugs values(" + "@id_drugs,@name, @type , @stock , @price , @expired)";

            try
            {
                cmd = new MySqlConnector.MySqlCommand(add, GetCon());
                cmd.Parameters.Add("@id_drugs", MySqlConnector.MySqlDbType.VarChar).Value = idDrug;
                cmd.Parameters.Add("@name", MySqlConnector.MySqlDbType.VarChar).Value = nameDrug;
                cmd.Parameters.Add("type", MySqlConnector.MySqlDbType.VarChar).Value = type;
                cmd.Parameters.Add("@stock", MySqlConnector.MySqlDbType.VarChar).Value = stock;
                cmd.Parameters.Add("@price", MySqlConnector.MySqlDbType.VarChar).Value = price;
                cmd.Parameters.Add("@expired", MySqlConnector.MySqlDbType.Date).Value = exp;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Add Data failed" + ex.Message);
            }
        }
        

        public void updateDrug(string id, string name,  string type, string stock, string price, DateTime expired)
        {
            string update = "UPDATE drugs set "+"name = @name  , type = @type ,stock = @stock , price= @price, expired = @expired "+"where id_drugs = " + id;
            try
            {
                cmd = new MySqlConnector.MySqlCommand(update, GetCon());
                cmd.Parameters.Add("@id_drugs", MySqlConnector.MySqlDbType.VarChar).Value = id;
                cmd.Parameters.Add("@name", MySqlConnector.MySqlDbType.VarChar).Value = name;
                cmd.Parameters.Add("@type", MySqlConnector.MySqlDbType.VarChar).Value = type;
                cmd.Parameters.Add("@stock", MySqlConnector.MySqlDbType.VarChar).Value = stock;
                cmd.Parameters.Add("@price", MySqlConnector.MySqlDbType.VarChar).Value = price;
                cmd.Parameters.Add("expired", MySqlConnector.MySqlDbType.Date).Value = expired;
                cmd.ExecuteNonQuery();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("update data failed " + ex.Message);
            }
        }


        public void deleteDrug(string id)
        {   
            string delete = "DELETE  FROM drugs WHERE id_drugs = " + id;

            try
            {
                cmd = new MySqlConnector.MySqlCommand(delete, GetCon());
                cmd.Parameters.Add("@id_drugs", MySqlConnector.MySqlDbType.VarChar).Value = id;
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Delete Failed" + ex.Message);
            }
        }


        public DataTable searchDrug(string search)
        {
            DataTable table = new DataTable();
            try
            {
                MySqlCommand command = new MySqlCommand
               ("SELECT * FROM drugs  WHERE CONCAT(id_drugs ,name , type , stock , price , expired) LIKE '%" + search + "%'", connection.GetCon());
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                adapter.Fill(table);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return table;
        }

        public DataTable searchTablet(string search)
        {
            DataTable table = new DataTable();
            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM drugs WHERE type ='Tablet'", connection.GetCon());
                adapter.Fill(table);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            return table;
        }

        public DataTable searchSyrup(string search)
        {
            DataTable table = new DataTable();
            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM drugs WHERE type ='Syrup'", connection.GetCon());
                adapter.Fill(table);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            return table;
        }

        public DataTable searchPowder(string search)
        {
            DataTable table = new DataTable();
            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM drugs WHERE type ='Powder'", connection.GetCon());
                adapter.Fill(table);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            return table;
        }

        public DataTable searchBottle(string search)
        {
            DataTable table = new DataTable();
            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM drugs WHERE type ='Bottle'", connection.GetCon());
                adapter.Fill(table);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            return table;
        }


    }
}
