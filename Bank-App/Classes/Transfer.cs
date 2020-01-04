using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_App.Classes
{
    public class Transfer
    {
        public string Title { get; set; }
        public decimal TransferValue { get; set; }
        public string SenderAccountNumber { get; set; }
        public string ReceiverAccountNumber { get; set; }
        public DateTime Date { get; set; }

        public Transfer()
        {
            Title = "";
            TransferValue = 0.0M;
            SenderAccountNumber = "";
            ReceiverAccountNumber = "";
            Date = DateTime.Now;
        }

        public Transfer(string title, decimal transferValue, string senderAccountNumber, string receiverAccountNumber, DateTime date)
        {
            Title = title;
            TransferValue = transferValue;
            SenderAccountNumber = senderAccountNumber;
            ReceiverAccountNumber = receiverAccountNumber;
            Date = date;
        }

    }
}
