using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bank_App.Classes;
using Bank_App.Forms;

namespace Bank_App.UnitTest
{
    [TestClass]
    public class DataBaseManagerTests
    {
        [TestMethod]
        public void Get_SendCorrectSqlQuery_ReturnsDataTable()
        {
            DataBaseManager databaseManager = new DataBaseManager();
            var result = databaseManager.Get("SELECT * FROM UserTable");
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Get_SendIncorrectSqlQuery_ReturnsZero()
        {
            DataBaseManager databaseManager = new DataBaseManager();
            var result = databaseManager.Get("SELECT * FROM dawdwaf");
            Assert.AreEqual(0, result.Rows.Count);

        }
    }
}
