using Bank_App.Forms;
using System;
using System.Collections.Generic;
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
                string personTableQ = "INSERT INTO PersonTable VALUES("+"'' ," +
                    "'" + Client.Name + "', '" + Client.Surname + "', " +
                    "'" + Client.City + "', '" + Client.ZipCode + "', " +
                    "'" + Client.Email + "', '" + Client.DateOfBirth.ToString() + "', " +
                    "'" + Client.PhoneNumber + "', '" + Client.Pesel + "')";
            
                string userTableQ = "INSERT INTO UserTable VALUES(" + "'' ," +
                    "'" + Client.Login + "', '" + Client.Password + "', '" + Client.IsAdmin.ToString() + "')";
                string createAccountQ = "" +
                "Begin" +
                "    Declare @PersonId int" +
                "    Declare @UserId int" +
                "    if (@PersonId is null)" +
                "                Begin" +
                "                    " + personTableQ +
                "        Select @PersonId = SCOPE_IDENTITY()" +
                "    End" +
                "    if (@UserId is null)" +
                "                Begin" +
                "                    " + userTableQ +
                "        Select @UserID = SCOPE_IDENTITY()" +
                "    End" +
                "    Insert into AccountTable values("+"'', "+"@PersonId, @UserId, '" + Client.AccountNumber + "', '" + Client.Balance.ToString().Replace(",",".") +"')" +
                "End";
                DataBaseManager.Post(createAccountQ);
            }
        }
    }
}
