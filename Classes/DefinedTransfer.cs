using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_App.Classes
{
    class DefinedTransfer
    {
        public string DefinedTransferName { get; private set; }
        public decimal LastTransferValue { get; private set; }
        public string AccountNumber { get; private set; }
        public DateTime LastTransferDate { get; private set; }

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
