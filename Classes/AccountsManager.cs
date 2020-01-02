using Bank_App.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_App.Classes
{
    static class AccountsManager
    {
        public static Client Client { get; set; }
        public static string GenerateAccountNumber()
        {
            string accountNumber = "";
            int numberToAdd;

            Random random = new Random();

            for(int i=0; i<26; i++)
            {
                numberToAdd = random.Next(0, 9);
                accountNumber += numberToAdd.ToString();
            }

            return accountNumber;
        }

        public static bool CheckIfPersonExist(String pesel) 
        {
            bool exist = false;
            if (DataBaseManager.Get("SELECT * FROM PersonTable WHERE Pesel = " + "'" + pesel + "'").Rows.Count > 0)
            {
                exist = true;
            }
            return exist;

        }

        public static void CreateAccount()
        {
            if (CheckIfPersonExist(Client.Pesel))
            {
                MessageBox.Show("This person already has account");
            }
            else {
                int indexOfDate = Client.DateOfBirth.ToString().IndexOf(" ");
                
                
                string personTableQ = "INSERT INTO PersonTable VALUES("+"'' ," +
                    "'" + Client.Name + "', '" + Client.Surname + "', " +
                    "'" + Client.City + "', '" + Client.ZipCode + "', " +
                    "'" + Client.Email + "', '" + Client.DateOfBirth.ToString("yyyy-MM-dd").Substring(0, indexOfDate) + "', " +
                    "'" + Client.PhoneNumber + "', '" + Client.Pesel + "');" +
                    "SELECT LAST_INSERT_ID();";
            
                string userTableQ = "INSERT INTO UserTable VALUES(" + "'' ," +
                    "'" + Client.Login + "', '" + Client.Password + "', '" + Client.IsAdmin.ToString() + "'); SELECT LAST_INSERT_ID();";

                
                DataTable personId = DataBaseManager.Get(personTableQ);
                DataTable userId = DataBaseManager.Get(userTableQ);

                string createAccountQ = "Insert into AccountTable values('', '"+ personId.Rows[0].ItemArray[0].ToString() + "', '"+ userId.Rows[0].ItemArray[0]+ "', '" + Client.AccountNumber + "', '" + Client.Balance.ToString().Replace(",",".") +"')";
                DataBaseManager.Post(createAccountQ);
                
                
            }
        }

        public static DataTable GetUsersFromDataBase()
        {

            DataTable data = DataBaseManager.Get("SELECT " +
                "UserTable.Id, UserTable.Login, " +
               "PersonTable.Email, PersonTable.Pesel, " +
               "AccountTable.AccountNumber " +
               "FROM AccountTable " +
               "INNER JOIN UserTable ON UserTable.Id = AccountTable.UserId " +
               "INNER JOIN PersonTable ON PersonTable.Id = AccountTable.PersonId " +
               "ORDER BY AccountTable.Id ");
            return data;
        }
    }
}
