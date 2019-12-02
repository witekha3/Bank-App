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
        public static DataTable Get(String query) {
            SqlConnection sqlcon = new SqlConnection(ConnectionString);
            sqlcon.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlcon);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            sqlcon.Close();
            return dataTable;
        }

        public static void Post(String query) {

            SqlConnection sqlcon = new SqlConnection(ConnectionString);
            try
            {
                sqlcon.Open();
                SqlCommand command = new SqlCommand(query, sqlcon);
                command.ExecuteNonQuery();
                
            }
            catch(Exception e) {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
        }
    }
}
