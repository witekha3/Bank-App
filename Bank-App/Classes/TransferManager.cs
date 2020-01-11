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
    public class TransferManager
    {
        DataBaseManager dataBaseManager = new DataBaseManager();
        public void SendMoney(Transfer transfer)
        {            
            DataTable SenderData = dataBaseManager.Get("select * from AccountTable where AccountNumber = " + "'" + transfer.SenderAccountNumber + "'");

            decimal saldo = Convert.ToDecimal(SenderData.Rows[0]["Saldo"]);
            decimal currentSaldo = saldo - transfer.TransferValue;

            dataBaseManager.Post("update AccountTable set Saldo = " + "'" + currentSaldo.ToString().Replace(",",".") + "'" + "where AccountNumber =" + "'" + transfer.SenderAccountNumber + "'");
            ReceiveMoney(transfer);
            UpdateTransferList(transfer);
        }
        public void ReceiveMoney(Transfer transfer)
        {
            DataTable ReceiverData = dataBaseManager.Get("select * from AccountTable where AccountNumber = " + "'" + transfer.ReceiverAccountNumber + "'" + "");

            decimal saldo = Convert.ToDecimal(ReceiverData.Rows[0]["Saldo"]);
            decimal currentSaldo = saldo + transfer.TransferValue;

            dataBaseManager.Post("update AccountTable set Saldo = " + "'" + currentSaldo.ToString().Replace(",", ".") + "'" + "where AccountNumber =" + "'" + transfer.ReceiverAccountNumber + "'");
        }
        public void UpdateTransferList(Transfer transfer)
        {
            dataBaseManager.Post("INSERT INTO TransferHistory VALUES("+"''," +
                "'" + transfer.Title + "', '" + transfer.TransferValue.ToString().Replace(",", ".") + "', " +
                "'" + transfer.SenderAccountNumber + "', '" + transfer.ReceiverAccountNumber + "', " +
                "'" + transfer.Date.ToString("G") + "')");
        }

        public DataTable GetTransferHistoryFromDataBase()
        {
            DataTable data = dataBaseManager.Get("Select Title, TransferValue, ReceiverAccountNumber, Date from TransferHistory where SenderAccountNumber = " + LogInManager.WhoIsCurrentLoged);
            return data;
        }
        public DataTable GetUsersFromDataBase()
        {

            DataTable data = dataBaseManager.Get("SELECT " +
                "UserTable.Id, UserTable.Login, " +
               "PersonTable.Email, PersonTable.Pesel, " +
               "AccountTable.AccountNumber " +
               "FROM AccountTable " +
               "INNER JOIN UserTable ON UserTable.Id = AccountTable.UserId " +
               "INNER JOIN PersonTable ON PersonTable.Id = AccountTable.PersonId "+
               "ORDER BY AccountTable.Id ");
            return data;
        }
        public void UpdateBalance(decimal saldo, decimal value, char h)
        {
            decimal currentSaldo;
            if (h == '+') currentSaldo = saldo + value;
            else currentSaldo = saldo - value;
            dataBaseManager.Post("update AccountTable set Saldo = " + "'" + currentSaldo.ToString().Replace(",", ".") + "'" + "where AccountNumber =" + "'" + LogInManager.WhoIsCurrentLoged + "'");
        }

        public DataTable GetSenderData()
        {
            DataTable SenderData = dataBaseManager.Get("select * from AccountTable where AccountNumber = " + "'" + LogInManager.WhoIsCurrentLoged + "'" + "");
            return SenderData;
        }

        public bool CheckIfExist(string accountNumber)
        {
            DataTable ReceiverData = dataBaseManager.Get("select * from AccountTable where AccountNumber = " + "'" + accountNumber + "'" + "");

            if (ReceiverData.Rows.Count != 0)
                return true;
            else
                return false;
        }

        public bool CheckBalance(string value)
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
        public AutoCompleteStringCollection DefinedTransfer()
        {
            AutoCompleteStringCollection myCollection = new AutoCompleteStringCollection();

            DataTable data = dataBaseManager.Get("Select Title, TransferValue, ReceiverAccountNumber from TransferHistory where SenderAccountNumber = " + LogInManager.WhoIsCurrentLoged);

            for (int i = 0; i < data.Rows.Count; i++)
            {
                string sData = "";
                sData += data.Rows[i].ItemArray[0].ToString() + " Receiver Account: " + data.Rows[i].ItemArray[2].ToString();

                myCollection.Add(sData);
            }

            return myCollection;
        }

        public DataTable GetDataRelatedToDefinedTransfers(string selectedTransfer)
        {
            int indexOfTitle = selectedTransfer.IndexOf(" Receiver Account: ");

            DataTable data = dataBaseManager.Get("Select Title, TransferValue, ReceiverAccountNumber from TransferHistory where " +
            "SenderAccountNumber = " + LogInManager.WhoIsCurrentLoged + " and Title = '" + selectedTransfer.Substring(0, indexOfTitle) + "'");

            return data;
        }

        public void DeleteFromTransferHistory(string title, string accountNumber, string date)
        {
            dataBaseManager.Post("Delete from TransferHistory where Title = " + "'" + title + "'" + " and ReceiverAccountNumber = "
                   + "'" + accountNumber + "'" + " and Date = " + "'" + date + "'");

        }
    }
}
