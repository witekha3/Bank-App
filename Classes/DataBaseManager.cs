using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Bank_App.Forms
{
    class DataBaseManager
    {
        private static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=BankAppDatabase;Integrated Security=True";
        public static string ConnectionString
        {
            get
            {
                return connectionString;
            }
        }

        public static DataTable Get(string query) 
        {
            SqlConnection sqlcon = new SqlConnection(ConnectionString);
            DataTable dataTable = new DataTable();
            try
            {
                sqlcon.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlcon);
                sqlDataAdapter.Fill(dataTable);
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                sqlcon.Close();
            }

            return dataTable;

        }

        public static void Post(string query) {

            SqlConnection sqlcon = new SqlConnection(ConnectionString);
            try
            {
                sqlcon.Open();
                SqlCommand command = new SqlCommand(query, sqlcon);
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
