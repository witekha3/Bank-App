using System;
using System.Windows.Forms;
using Bank_App.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bank_App.UnitTest
{
    [TestClass]
    public class TransferManagerTests
    {
        [TestMethod]
        public void GetTransferHistoryFromDataBase_SendCorrectSqlQuery_ReturnsDataTable()
        {
            TransferManager transferManager = new TransferManager();
            var result = transferManager.GetTransferHistoryFromDataBase();
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void GetUsersFromDataBase_GetAll_ReturnsDataTable()
        {
            TransferManager transferManager = new TransferManager();
            var result = transferManager.GetUsersFromDataBase();
            bool res2 = false;
            if (result.Rows.Count > 0)
            {
                res2 = true;
            }
            Assert.IsTrue(res2); ;
        }

        [TestMethod]
        public void GetSenderData_GetDataTable_ReturnsDataTable()
        {
            TransferManager transferManager = new TransferManager();
            var result = transferManager.GetUsersFromDataBase();
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void CheckIfExist_CorrectAccountNumber_ReturnsTrue()
        {
            TransferManager transferManager = new TransferManager();
            var result = transferManager.CheckIfExist("00000000000000000000000000");
            Assert.IsTrue(result); ;
        }

        [TestMethod]
        public void CheckIfExist_IncorrectAccountNumber_ReturnsFalse()
        {
            TransferManager transferManager = new TransferManager();
            var result = transferManager.CheckIfExist("");
            Assert.IsFalse(result); ;
        }

        [TestMethod]
        public void DefinedTransfer_FindTransfers_ReturnsAutoCompleteStringCollection()
        {
            TransferManager transferManager = new TransferManager();
            var result = transferManager.DefinedTransfer();
            Assert.IsInstanceOfType(result, typeof(AutoCompleteStringCollection));
        }


    }
}
