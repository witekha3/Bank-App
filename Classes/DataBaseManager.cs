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
        private static string connectionString = "Server=tcp:bankappio.database.windows.net,1433;Initial Catalog=BankAppDatabase;Persist Security Info=False;User ID=bankAdmin;Password=IOon5ive;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        public static string ConnectionString
        {
            get
            {
                return connectionString;
            }
        }

        public static DataTable Get(string query) 
        {
            SqlConnection sqlcon = new SqlConnection(connectionString);
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

            SqlConnection sqlcon = new SqlConnection(connectionString);
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
