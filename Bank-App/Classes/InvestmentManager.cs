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
    class InvestmentManager
    {
        DataBaseManager dataBaseManager = new DataBaseManager();

        public decimal Saldo = 0.0M;
        public double MatchInterestToDuration(string Duration)
        {
            double interest = 0;

            if (Duration == "30 days")
            {
                interest = 0.010;
                return interest;
            }

            else if (Duration == "60 days")
            {
                interest = 0.030;
                return interest;
            }

            else if (Duration == "90 days")
            {
                interest = 0.055;
                return interest;
            }

            else if (Duration == "180 days")
            {
                interest = 0.08;
                return interest;
            }

            else if (Duration == "360 days")
            {
                interest = 0.12;
                return interest;
            }

            else if (Duration == "720 days")
            {
                interest = 0.26;
                return interest;
            }

            else if (Duration == "1800 days")
            {
                interest = 0.9;
                return interest;
            }

            else if (Duration == "3600 days")
            {
                interest = 1.25;
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
        public void UpDateInvestments()
        {
            DataTable InvestmentList = dataBaseManager.Get("select * from InvestmentTable where AccountNumber = " + "'" + LogInManager.WhoIsCurrentLoged + "'");
            int totalrows = InvestmentList.Rows.Count;
            DateTime tk;
            DateTime now = DateTime.Now;
            string start;
            string finish;
            string type;
            double value;
            int id;
            double interest;
            string AccNumber;


            for (int i = 0; i < totalrows; i++)
            {
                start = InvestmentList.Rows[i]["Start"].ToString();
                finish = InvestmentList.Rows[i]["Finish"].ToString();
                type = InvestmentList.Rows[i]["Type"].ToString();
                value = Convert.ToDouble(InvestmentList.Rows[i]["Value"]);
                id = Convert.ToInt32(InvestmentList.Rows[i]["Id"]);
                interest = Convert.ToDouble(InvestmentList.Rows[i]["Interest"]);
                AccNumber = InvestmentList.Rows[i]["AccountNumber"].ToString();
                tk = DateTime.Parse(finish);
                int compare = DateTime.Compare(tk, now);
                switch (type)
                {
                    case "Curerency":
                        if (compare <= 0)
                        {
                            InvestmentEnd(id, start, finish, value, interest, AccNumber);
                        }
                        else
                        {
                            InvestmentUpdate(id, start, finish, value, interest);
                        }
                        break;
                    case "Term":
                        if (compare <= 0)
                        {
                            InvestmentEnd(id,start,finish,value,interest, AccNumber);
                        }
                        break;
                    case "Progress":
                        if (compare <= 0)
                        {
                            InvestmentEnd(id, start, finish, value, interest, AccNumber);
                        }
                        break;
                    case "Daily":
                        if (compare <= 0)
                        {
                            InvestmentEnd(id, start, finish, value, interest, AccNumber);
                        }
                        else
                        {
                            InvestmentUpdate(id, start, finish, value, interest);
                        }
                        break;
                }
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
        public void SetSaldo (decimal value, string AccNumber)
        {
            DataTable SenderData = dataBaseManager.Get("select * from AccountTable where AccountNumber = " + "'" + AccNumber + "'" + "");
            Saldo = Convert.ToDecimal(SenderData.Rows[0]["Saldo"])+value;
            dataBaseManager.Post("update AccountTable set Saldo = " + "'" + Saldo.ToString().Replace(",", ".") + "'" + "where AccountNumber =" + "'" + AccNumber + "'");
            Saldo = 0;
        }
        public void UpdateInvStart(int id, string start)
        {
            dataBaseManager.Post("update InvestmentTable set Start = " + "'" + start + "'" + "where Id =" + "'" + id.ToString() + "'");
        }
        public void UpdateInvValue(int id, double value)
        {
            dataBaseManager.Post("update InvestmentTable set Value = " + "'" + value.ToString().Replace(",", ".") + "'" + "where Id =" + "'" + id.ToString() + "'");
        }
        public void InvestmentEnd(int id, string start, string finish, double value, double interest,string AccNumber)
        {
            DateTime tk = DateTime.Parse(finish);
            DateTime ts = DateTime.Parse(start);
            TimeSpan days = tk.Subtract(ts);
            double months = Convert.ToDouble(days.Days) / 30;
            int j = (int)Math.Floor(months);
            for (int k = 0; k < j; k++)
            {
                value = value * (1 + interest / 100);
            }
            SetSaldo(Convert.ToDecimal(value), AccNumber);
            RemoveInvestment(id);
        }
        public void InvestmentUpdate(int id, string start, string finish, double value, double interest)
        {
            DateTime now = DateTime.Now;
            DateTime ts = DateTime.Parse(start);
            TimeSpan days = now.Subtract(ts);
            double months = Convert.ToDouble(days.Days) / 30;
            int j = (int)Math.Floor(months);
            for (int k = 0; k < j; k++)
            {
                value = value * (1 + interest / 100);
            }
            ts = ts.AddDays(j*30);
            start = ts.ToString("yyyy-MM-dd");
            UpdateInvStart(id, start);
            UpdateInvValue(id, value);
        }
    }
}
