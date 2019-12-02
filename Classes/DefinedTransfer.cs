using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_App.Classes
{
    class DefinedTransfer
    {
        public string DefinedTransferName { get; set; }
        public decimal LastTransferValue { get; set; }
        public string AccountNumber { get; set; }
        public DateTime LastTransferDate { get; set; }

        public DefinedTransfer()
        {
            DefinedTransferName = "";
            LastTransferValue = 0.0M;
            AccountNumber = "";
            LastTransferDate = DateTime.Now;
        }

        public DefinedTransfer(string definedTransferName, decimal lastTransferValue, string accountNumber, DateTime lastTransferDate)
        {
            DefinedTransferName = definedTransferName;
            LastTransferValue = lastTransferValue;
            AccountNumber = accountNumber;
            LastTransferDate = lastTransferDate;
        }
    }
}
