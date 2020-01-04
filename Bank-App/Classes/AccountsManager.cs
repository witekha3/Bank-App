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
    class AccountsManager
    {
        DataBaseManager dataBaseManager = new DataBaseManager();
        public static Client Client { get; set; }
        public string GenerateAccountNumber()
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

        public bool CheckIfPersonExist(string pesel) 
        {
            bool exist = false;
            if (dataBaseManager.Get("SELECT * FROM PersonTable WHERE Pesel = " + "'" + pesel + "'").Rows.Count > 0)
            {
                exist = true;
            }
            return exist;

        }

        public void CreateAccount()
        {
            int indexOfDate = Client.DateOfBirth.ToString().IndexOf(" ");
            
            string personTableQ = "INSERT INTO PersonTable VALUES("+"'' ," +
                    "'" + Client.Name + "', '" + Client.Surname + "', " +
                    "'" + Client.City + "', '" + Client.ZipCode + "', " +
                    "'" + Client.Email + "', '" + Client.DateOfBirth.ToString("yyyy-MM-dd").Substring(0, indexOfDate) + "', " +
                    "'" + Client.PhoneNumber + "', '" + Client.Pesel + "');" +
                    "SELECT LAST_INSERT_ID();";
            
            string userTableQ = "INSERT INTO UserTable VALUES(" + "'' ," +
                    "'" + Client.Login + "', '" + Client.Password + "', 0); SELECT LAST_INSERT_ID();";

                
            DataTable personId = dataBaseManager.Get(personTableQ);
            DataTable userId = dataBaseManager.Get(userTableQ);

            string createAccountQ = "Insert into AccountTable values('', '"+ personId.Rows[0].ItemArray[0].ToString() + "', '"+ userId.Rows[0].ItemArray[0]+ "', '" + Client.AccountNumber + "', '" + Client.Balance.ToString().Replace(",",".") +"')";
            dataBaseManager.Post(createAccountQ);
                
            
        }

        public DataTable GetAllUsersFromDataBase()
        {

            DataTable data = dataBaseManager.Get("SELECT " +
                "AccountTable.Id, UserTable.Login, " +
               "PersonTable.Email, PersonTable.Pesel, " +
               "AccountTable.AccountNumber " +
               "FROM AccountTable " +
               "INNER JOIN UserTable ON UserTable.Id = AccountTable.UserId " +
               "INNER JOIN PersonTable ON PersonTable.Id = AccountTable.PersonId " +
               "ORDER BY AccountTable.Id ");
            return data;
        }

        public DataTable GetUserDetailByAdmin(string pesel)
        {
            DataTable data = dataBaseManager.Get("SELECT " +
               "UserTable.Id, UserTable.Login, " +
               "PersonTable.Name, PersonTable.Surname, PersonTable.City, PersonTable.CityCode, PersonTable.PhoneNumber, PersonTable.Email, PersonTable.Pesel," +
               "AccountTable.AccountNumber " +
               "FROM AccountTable " +
               "INNER JOIN UserTable ON UserTable.Id = AccountTable.UserId " +
               "INNER JOIN PersonTable ON PersonTable.Id = AccountTable.PersonId " +
               "WHERE PersonTable.Pesel = " + "'" + pesel + "'"); 

            return data;
        }

        public DataTable GetAccountDetails()
        {
            DataTable data = dataBaseManager.Get("SELECT " +
               "UserTable.Id, UserTable.Login, " +
               "PersonTable.Name, PersonTable.Surname, PersonTable.BirthDate, PersonTable.Pesel, PersonTable.Email, PersonTable.PhoneNumber, PersonTable.City, PersonTable.CityCode, " +
               "AccountTable.AccountNumber " +
               "FROM AccountTable " +
               "INNER JOIN UserTable ON UserTable.Id = AccountTable.UserId " +
               "INNER JOIN PersonTable ON PersonTable.Id = AccountTable.PersonId " +
               "WHERE AccountTable.AccountNumber = " + "'" + LogInManager.WhoIsCurrentLoged.ToString() + "'");

            return data;
        }

        public void UpdateUserDetails(string pesel, string login, string name, string surname, string city, string zipCode, string email, string phone)
        {
            DataTable data = dataBaseManager.Get("SELECT " +
                "UserTable.Id, " +
                "PersonTable.Id, PersonTable.Pesel, " +
                "AccountTable.AccountNumber " +
                "FROM AccountTable " +
                "INNER JOIN UserTable ON UserTable.Id = AccountTable.UserId " +
                "INNER JOIN PersonTable ON PersonTable.Id = AccountTable.PersonId " +
                "WHERE PersonTable.Pesel = " + "'" + pesel + "'");
            int userTableId = (int)data.Rows[0].ItemArray[0];
            int personTableId = (int)data.Rows[0].ItemArray[1];

            dataBaseManager.Post("UPDATE UserTable " + 
                "SET Login = " + "'" + login + "'" +
                " WHERE Id = " + "'" + userTableId + "'");

            dataBaseManager.Post("UPDATE PersonTable " +
            "SET Name = " + "'" + name + "'" +
            ", Surname = " + "'" + surname + "'" +
            ", City = " + "'" + city + "'" +
            ", CityCode = " + "'" + zipCode + "'" +
            ", Email = " + "'" + email + "'" +
            ", PhoneNumber = " + "'" + phone + "'" +
            " WHERE Id = " + "'" + personTableId + "'");
        }

        public void DeleteClientFromDataBase(string id)
        {
            dataBaseManager.Post("Delete " +
                "UserTable.*, " +
                "PersonTable.*, " +
                "AccountTable.* " +
                "FROM AccountTable " +
                "INNER JOIN UserTable ON UserTable.Id = AccountTable.UserId " +
                "INNER JOIN PersonTable ON PersonTable.Id = AccountTable.PersonId " +
                "Where AccountTable.Id = " + "'" + id + "'");


        }

        public void DeleteAnotherRecordsRelatedToClient(string accountNumber)
        {
            dataBaseManager.Post("Delete from TransferHistory where ReceiverAccountNumber =  " + "'" + accountNumber + "'");

            dataBaseManager.Post("Delete from InvestmentTable where AccountNumber = " + "'" + accountNumber + "'");
        }
    }
}
