using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace Bank_App.Forms
{
    public class DataBaseManager
    {

        private string connectionString = "server=sql7.freesqldatabase.com;user=sql7316377;database=sql7316377;password=IOon5ive!;";

        public DataTable Get(string query) 
        {
            MySqlConnection sqlcon = new MySqlConnection(connectionString);
            DataTable dataTable = new DataTable();
            try
            {
                sqlcon.Open();
                MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(query, sqlcon);
                sqlDataAdapter.Fill(dataTable);
            }
            catch(Exception e)
            {
                //MessageBox.Show(e.ToString());
            }
            finally
            {
                sqlcon.Close();
            }

            return dataTable;

        }

        public void Post(string query) {

            MySqlConnection sqlcon = new MySqlConnection(connectionString);
            try
            {
                sqlcon.Open();
                MySqlCommand command = new MySqlCommand(query, sqlcon);
                command.ExecuteNonQuery();
                
            }
            catch(Exception e) 
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
        }
    }
}
