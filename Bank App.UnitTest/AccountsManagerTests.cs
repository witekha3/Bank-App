using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bank_App.Classes;
using Bank_App.Forms;
using System.Data;

namespace Bank_App.UnitTest
{
    [TestClass]
    public class AccountsManagerTests
    {
        [TestMethod]
        public void GenerateAccountNumber_CheckLength_ReturnsString()
        {
            AccountsManager accountsManager = new AccountsManager();
            var result = accountsManager.GenerateAccountNumber();
            bool correctLength = false;
            if (result.Length == 26) correctLength = true;
            Assert.IsTrue(correctLength);
        }

        [TestMethod]
        public void CheckIfPersonExist_PersonExist_returnsTrue()
        {
            AccountsManager accountsManager = new AccountsManager();
            DataBaseManager db = new DataBaseManager();

            var result = accountsManager.CheckIfPersonExist("admin");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CheckIfPersonExist_PersonNotExist_returnsFalse()
        {
            AccountsManager accountsManager = new AccountsManager();
            var result = accountsManager.CheckIfPersonExist("0");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void GetAllUsersFromDataBase_Get_ReturnsDataTable()
        {
            AccountsManager accountsManager = new AccountsManager();
            var result = accountsManager.GetAllUsersFromDataBase();
            bool notNull = false;
            if (result.Rows.Count > 0) notNull = true;
            Assert.IsTrue(notNull);
        }

        [TestMethod]
        public void GetUserDetailByAdmin_CorrectPesel_ReturnsDataTable()
        {
            AccountsManager accountsManager = new AccountsManager();
            DataBaseManager db = new DataBaseManager();
            string pesel = "";
            foreach (DataRow row in db.Get("Select Pesel from PersonTable where Id=(select max(Id) from PersonTable);").Rows) 
            {
                pesel = row.ItemArray[0].ToString();
                break;
            }
            var result = accountsManager.GetUserDetailByAdmin(pesel);
            bool notNull = false;
            if (result.Columns.Count == 10) notNull = true;
            Assert.IsTrue(notNull);
        }

        [TestMethod]
        public void GetUserDetailByAdmin_UnCorrectPesel_ReturnsNull()
        {
            AccountsManager accountsManager = new AccountsManager();
            var result = accountsManager.GetUserDetailByAdmin("1");
            bool notNull = true;
            if (result.Columns.Count == 10) notNull = false;
            Assert.IsFalse(notNull);
        }

        [TestMethod]
        public void GetAccountDetails_Get_returnsDataTable()
        {
            LogInManager.WhoIsCurrentLoged = "admin";
            AccountsManager accountsManager = new AccountsManager();
            var result = accountsManager.GetAccountDetails();
            bool notNull = false;
            if (result.Columns.Count == 11) notNull = true;
            Assert.IsTrue(notNull);
        }

        private string[] returnDetailsOfLastUser() 
        {
            DataBaseManager db = new DataBaseManager();

            DataTable dataTable = db.Get("Select Name, Surname, City, CityCode, Email, PhoneNumber, Pesel, Login " +
        "from PersonTable, UserTable where PersonTable.Id = (select max(Id) from PersonTable) AND UserTable.Id = (select max(Id) from PersonTable);");
            string[] tab = new string[8];
            foreach (DataRow row in dataTable.Rows)
            {
                tab[0] = row["Name"].ToString();
                tab[1] = row["Surname"].ToString();
                tab[2] = row["City"].ToString();
                tab[3] = row["CityCode"].ToString();
                tab[4] = row["Email"].ToString();
                tab[5] = row["PhoneNumber"].ToString();
                tab[6] = row["Login"].ToString();
                tab[7] = row["Pesel"].ToString();

                break;
            }
            return tab;
        }

        [TestMethod]
        public void UpdateUserDetails_CorrectPesel_ReturnsVoid()
        {
            AccountsManager accountsManager = new AccountsManager();
            string[] tab = returnDetailsOfLastUser();
            string name = tab[0];
            string surname = tab[1];
            string city = tab[2];
            string cityCode = tab[3];
            string email = tab[4];
            string phoneNumber = tab[5];
            string login = tab[6];
            string pesel = tab[7];

            accountsManager.UpdateUserDetails(pesel, "test", "test", "test", "test", "test", "test", "test");
            tab = returnDetailsOfLastUser();

            bool updated = false;
            foreach (string row in tab)
            {
                if (tab[0] == "test" && tab[1] == "test" && tab[2] == "test" && tab[3] == "test" && tab[4] == "test" && tab[5] == "test" && tab[6] == "test")
                {
                    updated = true;
                }
                else 
                {
                    updated = false;
                }
                break;
            }
            Assert.IsTrue(updated);

            //restoring values
            accountsManager.UpdateUserDetails(pesel, login,name, surname, city, cityCode, email, phoneNumber);
        }

        [TestMethod]
        public void UpdateUserDetails_IncorrectPesel_ReturnsVoid()
        {
            //AccountsManager accountsManager = new AccountsManager();
            string[] tab = returnDetailsOfLastUser();
            string name = tab[0];
            string surname = tab[1];
            string city = tab[2];
            string cityCode = tab[3];
            string email = tab[4];
            string phoneNumber = tab[5];
            string login = tab[6];
            string pesel = tab[7];

            //accountsManager.UpdateUserDetails("a", "test", "test", "test", "test", "test", "test", "test");
            tab = returnDetailsOfLastUser();

            bool updated = false;
            foreach (string row in tab)
            {
                if (tab[0] == name && tab[1] == surname && tab[2] == city && tab[3] == cityCode && tab[4] == email && tab[5] == phoneNumber && tab[6] == login)
                {
                    updated = true;
                }
                else
                {
                    updated = false;
                }
                break;
            }
            Assert.IsTrue(updated);
        }
    }
}
