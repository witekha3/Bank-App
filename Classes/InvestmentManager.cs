using Bank_App.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_App.Classes
{
    class InvestmentManager
    {
        DataBaseManager dataBaseManager = new DataBaseManager();

        public decimal Saldo = 0.0M;
        public double MatchInterestToDuration(string Duration)
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
        public void AddInvestment(string duration, string name, string type, string value)
        {
            double interest = MatchInterestToDuration(duration);
            dataBaseManager.Post("INSERT INTO InvestmentTable VALUES(" + "''," +
               "'" + name + "', '" + type + "', " +
               "'" + value.Replace(",", ".") + "', '" + interest.ToString() + "', " +
               "'" + DateTime.Now.ToString("yyyy-MM-dd") + "', '" + DateTime.Now.AddDays(Convert.ToInt32(duration.Replace(" days", ""))).ToString("yyyy-MM-dd") + "', '" + duration + "', " +
               "'" + LogInManager.WhoIsCurrentLoged + "')");
        }

        public bool CheckBalance(string value)
        {
            Saldo = 0.0M;

            DataTable SenderData = dataBaseManager.Get("select * from AccountTable where AccountNumber = " + "'" + LogInManager.WhoIsCurrentLoged + "'" + "");
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

        public void RemoveInvestment(int id)
        {
            dataBaseManager.Post("Delete from InvestmentTable where Id =" + "'" + id + "'");
        }

        public DataTable GetAllInvestmentsFromDataBase()
        {
            DataTable data = dataBaseManager.Get("select * from InvestmentTable where AccountNumber = " + "'" + LogInManager.WhoIsCurrentLoged + "'" + "");
            return data;
        }
    }
}
