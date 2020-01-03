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
    class TransferManager
    {
        public static void SendMoney(Transfer transfer)
        {
            DataTable SenderData = DataBaseManager.Get("select * from AccountTable where AccountNumber = " + "'" + transfer.SenderAccountNumber + "'");

            decimal saldo = Convert.ToDecimal(SenderData.Rows[0]["Saldo"]);
            decimal currentSaldo = saldo - transfer.TransferValue;

            DataBaseManager.Post("update AccountTable set Saldo = " + "'" + currentSaldo.ToString().Replace(",",".") + "'" + "where AccountNumber =" + "'" + transfer.SenderAccountNumber + "'");
            ReceiveMoney(transfer);
            UpdateTransferList(transfer);
        }
        public static void ReceiveMoney(Transfer transfer)
        {
            DataTable ReceiverData = DataBaseManager.Get("select * from AccountTable where AccountNumber = " + "'" + transfer.ReceiverAccountNumber + "'" + "");

            decimal saldo = Convert.ToDecimal(ReceiverData.Rows[0]["Saldo"]);
            decimal currentSaldo = saldo + transfer.TransferValue;

            DataBaseManager.Post("update AccountTable set Saldo = " + "'" + currentSaldo.ToString().Replace(",", ".") + "'" + "where AccountNumber =" + "'" + transfer.ReceiverAccountNumber + "'");
        }
        public static void UpdateTransferList(Transfer transfer)
        {
            DataBaseManager.Post("INSERT INTO TransferHistory VALUES("+"''," +
                "'" + transfer.Title + "', '" + transfer.TransferValue.ToString().Replace(",", ".") + "', " +
                "'" + transfer.SenderAccountNumber + "', '" + transfer.ReceiverAccountNumber + "', " +
                "'" + transfer.Date.ToString("G") + "')");
        }

        public static DataTable GetTransferHistoryFromDataBase()
        {
            DataTable data = DataBaseManager.Get("Select Title, TransferValue, ReceiverAccountNumber, Date from TransferHistory where SenderAccountNumber = " + LogInManager.WhoIsCurrentLoged);
            return data;
        }
        public static DataTable GetUsersFromDataBase()
        {

            DataTable data = DataBaseManager.Get("SELECT " +
                "UserTable.Id, UserTable.Login, " +
               "PersonTable.Email, PersonTable.Pesel, " +
               "AccountTable.AccountNumber " +
               "FROM AccountTable " +
               "INNER JOIN UserTable ON UserTable.Id = AccountTable.UserId " +
               "INNER JOIN PersonTable ON PersonTable.Id = AccountTable.PersonId "+
               "ORDER BY AccountTable.Id ");
            return data;
        }
        public static void UpdateBalance(decimal saldo, decimal value, char h)
        {
            decimal currentSaldo;
            if (h == '+') currentSaldo = saldo + value;
            else currentSaldo = saldo - value;
            DataBaseManager.Post("update AccountTable set Saldo = " + "'" + currentSaldo.ToString().Replace(",", ".") + "'" + "where AccountNumber =" + "'" + LogInManager.WhoIsCurrentLoged + "'");
        }

        public static DataTable GetSenderData()
        {
            DataTable SenderData = DataBaseManager.Get("select * from AccountTable where AccountNumber = " + "'" + LogInManager.WhoIsCurrentLoged + "'" + "");
            return SenderData;
        }

        public static bool CheckIfExist(string accountNumber)
        {
            DataTable ReceiverData = DataBaseManager.Get("select * from AccountTable where AccountNumber = " + "'" + accountNumber + "'" + "");

            if (ReceiverData.Rows.Count != 0)
                return true;
            else
                return false;
        }

        public static bool CheckBalance(string value)
        {
            DataTable senderData = GetSenderData();
            decimal saldo = Convert.ToDecimal(senderData.Rows[0]["Saldo"]);

            if (saldo >= Convert.ToDecimal(value))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static AutoCompleteStringCollection DefinedTransfer()
        {
            AutoCompleteStringCollection myCollection = new AutoCompleteStringCollection();

            DataTable data = DataBaseManager.Get("Select Title, TransferValue, ReceiverAccountNumber from TransferHistory where SenderAccountNumber = " + LogInManager.WhoIsCurrentLoged);

            for (int i = 0; i < data.Rows.Count; i++)
            {
                string sData = "";
                sData += data.Rows[i].ItemArray[0].ToString() + " Receiver Account: " + data.Rows[i].ItemArray[2].ToString();

                myCollection.Add(sData);
            }

            return myCollection;
        }

        public static DataTable GetDataRelatedToDefinedTransfers(string selectedTransfer)
        {
            int indexOfTitle = selectedTransfer.IndexOf(" Receiver Account: ");

            DataTable data = DataBaseManager.Get("Select Title, TransferValue, ReceiverAccountNumber from TransferHistory where " +
            "SenderAccountNumber = " + LogInManager.WhoIsCurrentLoged + " and Title = '" + selectedTransfer.Substring(0, indexOfTitle) + "'");

            return data;
        }
    }
}
