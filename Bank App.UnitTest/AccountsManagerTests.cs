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
            DataTable dataTable = db.Get("Select Pesel from PersonTable");

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
            foreach (DataRow row in db.Get("Select Pesel from PersonTable BY Id DESC LIMIT 1").Rows) 
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
    }
}
