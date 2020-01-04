using Bank_App.Classes;
using Bank_App.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_App.Classes
{
    public class LogInManager
    {
        public static string WhoIsCurrentLoged { get; set; }
        DataBaseManager dataBaseManager = new DataBaseManager();

        public bool LogIn(string login, string password, out bool isAdmin)
        {
            try
            {
                DataTable datatable = dataBaseManager.Get("SELECT * FROM UserTable WHERE Login = " + "'" + login + "' AND PASSWORD = " + "'" + password + "'");

                if (datatable.Rows.Count == 1)
                {
                    int userId = Convert.ToInt32(datatable.Rows[0]["Id"]);
                    DataTable data = dataBaseManager.Get("SELECT * FROM AccountTable WHERE UserId = " + "'" + userId + "'");
                    WhoIsCurrentLoged = data.Rows[0]["AccountNumber"].ToString();
                    if(datatable.Rows[0]["IsAdmin"].ToString() == "1")
                    {
                        isAdmin = true;
                        return true;
                    }
                    else
                    {
                        isAdmin = false;
                        return true;
                    }

                }
                else
                {
                    isAdmin = false;
                    return false;
                }

            }
            catch(IndexOutOfRangeException)
            {
                isAdmin = false;
                return false;
            }
        }
    }
}
