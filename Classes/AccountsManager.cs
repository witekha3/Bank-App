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
        public static Client newClient { get; set; }
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

        public static void CreateAccount()
        {

            string personTableQ = "INSERT INTO PersonTable VALUES(" +
                "'" + newClient.Name + "', '" + newClient.Surname + "', " +
                "'" + newClient.City + "', '" + newClient.ZipCode + "', " +
                "'" + newClient.Email + "', '" + newClient.DateOfBirth.ToString("dd-M-yyyy", CultureInfo.InvariantCulture) + "', " +
                "'" + newClient.PhoneNumber + "', '" + newClient.Pesel + "')";
            
            string userTableQ = "INSERT INTO UserTable VALUES(" +
                "'" + newClient.Login + "', '" + newClient.Password + "')";

            String createAccountQ = "" +
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
            "    Insert into AccountTable values(@PersonId, @UserId, '" + newClient.AccountNumber + "')" +
            "End";
            DataBaseManager.Post(createAccountQ);
        }
    }
}
