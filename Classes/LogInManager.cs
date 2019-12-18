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
    static class LogInManager
    {
        public static string WhoIsCurrentLoged { get; set; }

        public static bool LogIn(string login, string password, out bool isAdmin)
        {
            DataTable datatable = DataBaseManager.Get("SELECT * FROM UserTable WHERE Login = " + "'" + login + "' AND PASSWORD = " + "'" + password + "'");
            try
            {
                if (datatable.Rows.Count == 1)
                {
                    int userId = Convert.ToInt32(datatable.Rows[0]["Id"]);
                    DataTable data = DataBaseManager.Get("SELECT * FROM AccountTable WHERE UserId = " + "'" + userId + "'");
                    WhoIsCurrentLoged = data.Rows[0]["AccountNumber"].ToString();
                    if(datatable.Rows[0]["isAdmin"].ToString() == "True")
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
