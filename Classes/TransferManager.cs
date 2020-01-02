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

    }
}
