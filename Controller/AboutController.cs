using ApotekPub.Model;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ApotekPub.Controller
{
    internal class AboutController : Model.Connection
    {

        Connection connection = new Connection();
        public DataTable selectPerson()
        {
            DataTable data = new DataTable();


            try
            {
                string show = " SELECT * FROM about ";
                da = new MySqlConnector.MySqlDataAdapter(show, GetCon());
                da.Fill(data);

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return data;
        }



        public void addPerson(string id, string name, string age, string position, byte[] photo)
        {
            string add = " insert into about values(" + "@id,@name, @age , @position  , @photo)";

            try
            {
                cmd = new MySqlConnector.MySqlCommand(add, GetCon());
                cmd.Parameters.Add("@id", MySqlConnector.MySqlDbType.VarChar).Value = id;
                cmd.Parameters.Add("@name", MySqlConnector.MySqlDbType.VarChar).Value = name;
                cmd.Parameters.Add("age", MySqlConnector.MySqlDbType.VarChar).Value = age;
                cmd.Parameters.Add("@position", MySqlConnector.MySqlDbType.VarChar).Value = position;
                cmd.Parameters.Add("@photo", MySqlConnector.MySqlDbType.Blob).Value = photo;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Add Data failed" + ex.Message);
            }
        }



        public void updatePerson(string id, string name, string age, string position, byte[] photo)
        {
               string update = "UPDATE about set"+" name = @name , age = @age , position = @position , photo = @photo "+" where id =" + id;
                
            try
            {
                cmd = new MySqlConnector.MySqlCommand(update, GetCon());
                cmd.Parameters.Add("@id", MySqlConnector.MySqlDbType.VarChar).Value = id;
                cmd.Parameters.Add("@name", MySqlConnector.MySqlDbType.VarChar).Value = name;
                cmd.Parameters.Add("age", MySqlConnector.MySqlDbType.VarChar).Value = age;
                cmd.Parameters.Add("@position", MySqlConnector.MySqlDbType.VarChar).Value = position;
                cmd.Parameters.Add("@photo", MySqlConnector.MySqlDbType.Blob).Value = photo;
                cmd.ExecuteNonQuery();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("update data failed " + ex.Message);
            }

        }


        public void deletePerson( string id)
        {
            string delete = "DELETE  FROM about WHERE id = " + id;

            try
            {
                cmd = new MySqlConnector.MySqlCommand(delete, GetCon());
                cmd.Parameters.Add("@id", MySqlConnector.MySqlDbType.VarChar).Value = id;
                cmd.ExecuteNonQuery();
                 
            }
            catch(Exception ex)
            {
                MessageBox.Show("Delete Failed" + ex.Message);
            }
        }


        public DataTable searchProfile(string search)
        {
            DataTable table = new DataTable();
            try
            {
                MySqlCommand command = new MySqlCommand
               ("SELECT * FROM about  WHERE CONCAT(id ,name , name , age , position , photo) LIKE '%" + search + "%'", connection.GetCon());
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                adapter.Fill(table);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return table;
        }

        public DataTable searchAdmin(string search)
        {
            DataTable table = new DataTable();
            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM about WHERE position ='Admin'", connection.GetCon());
                adapter.Fill(table);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            return table;
        }

        public DataTable searchDeveloper(string search)
        {
            DataTable table = new DataTable();
            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM about WHERE position ='Developer'", connection.GetCon());
                adapter.Fill(table);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            return table;
        }

        public DataTable searchManager(string search)
        {
            DataTable table = new DataTable();
            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM about WHERE position ='Manager'", connection.GetCon());
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
