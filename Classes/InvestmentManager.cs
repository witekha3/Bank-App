using Bank_App.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_App.Classes
{
    static class InvestmentManager
    {
        public static decimal Saldo = 0.0M;
        public static double MatchInterestToDuration(string Duration)
        {
            double interest = 0;

            if (Duration == "30 days")
            {
                interest = 0.10;
                return interest;
            }

            else if (Duration == "60 days")
            {
                interest = 0.30;
                return interest;
            }

            else if (Duration == "90 days")
            {
                interest = 0.55;
                return interest;
            }

            else if (Duration == "180 days")
            {
                interest = 0.8;
                return interest;
            }

            else if (Duration == "360 days")
            {
                interest = 1.2;
                return interest;
            }

            else if (Duration == "720 days")
            {
                interest = 2.6;
                return interest;
            }

            else if (Duration == "1800 days")
            {
                interest = 9;
                return interest;
            }

            else if (Duration == "3600 days")
            {
                interest = 12.5;
                return interest;
            }

            else
                return interest;

        }
        public static void AddInvestment(string duration, string name, string type, string value)
        {
            double interest = MatchInterestToDuration(duration);
            DataBaseManager.Post("INSERT INTO InvestmentTable VALUES(" + "''," +
               "'" + name + "', '" + type + "', " +
               "'" + value.Replace(",", ".") + "', '" + interest.ToString() + "', " +
               "'" + DateTime.Now.ToString("yyyy-MM-dd") + "', '" + DateTime.Now.AddDays(Convert.ToInt32(duration.Replace(" days", ""))).ToString("yyyy-MM-dd") + "', '" + duration + "', " +
               "'" + LogInManager.WhoIsCurrentLoged + "')");
        }

        public static bool CheckBalance(string value)
        {
            Saldo = 0.0M;

            DataTable SenderData = DataBaseManager.Get("select * from AccountTable where AccountNumber = " + "'" + LogInManager.WhoIsCurrentLoged + "'" + "");
            Saldo = Convert.ToDecimal(SenderData.Rows[0]["Saldo"]);
            if (Saldo >= Convert.ToDecimal(value))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void RemoveInvestment(int id)
        {
            DataBaseManager.Post("Delete from InvestmentTable where Id =" + "'" + id + "'");
        }

        public static DataTable GetAllInvestmentsFromDataBase()
        {
            DataTable data = DataBaseManager.Get("select * from InvestmentTable where AccountNumber = " + "'" + LogInManager.WhoIsCurrentLoged + "'" + "");
            return data;
        }
    }
}
